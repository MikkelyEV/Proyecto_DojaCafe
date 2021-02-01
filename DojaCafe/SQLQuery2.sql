CREATE TABLE CLIENTE(
cliente_id VARCHAR(18) NOT NULL,
nombre VARCHAR(50) NOT NULL,
telefono VARCHAR(10),
direccion VARCHAR(30),
correo VARCHAR(30),
CONSTRAINT PK_cliente_id PRIMARY KEY(cliente_id),
)

CREATE TABLE PUESTO(
puesto_id VARCHAR(20) NOT NULL,
puesto varchar(20) NOT NULL,
salario int NOT NULL,
CONSTRAINT PK_puesto_id PRIMARY KEY(puesto_id),
)

CREATE TABLE EMPLEADO(
empleado_id VARCHAR(18) NOT NULL,
nombre VARCHAR(50) NOT NULL,
telefono VARCHAR(10),
direccion VARCHAR(30) NOT NULL,
correo VARCHAR(25),
puesto_id VARCHAR(20),
fecha_nac DATE,
edad INT NOT NULL,
CONSTRAINT PK_empleado_id PRIMARY KEY(empleado_id),
CONSTRAINT CH_edad CHECK (edad>=18),
FOREIGN KEY (puesto_id) REFERENCES puesto(puesto_id)
)

CREATE TABLE PRODUCTO(
producto_id VARCHAR(18) NOT NULL,
nombre VARCHAR(15),
descripcion VARCHAR(20),
precio INT NOT NULL,
CONSTRAINT PK_producto_id PRIMARY KEY(producto_id),
CONSTRAINT UQ_nombre UNIQUE(nombre)
)

CREATE TABLE PROVEEDOR(
proveedor_id VARCHAR(18) NOT NULL,
nombre VARCHAR(25),
ciudad VARCHAR(20),
telefono VARCHAR(10),
correo VARCHAR(25),
CONSTRAINT PK_proveedor_id PRIMARY KEY(proveedor_id),
)

CREATE TABLE INVENTARIO(
producto_id VARCHAR(18) NOT NULL,
cantidad INT NOT NULL,
proveedor_id VARCHAR(18),
fecha DATE,
FOREIGN KEY (producto_id) REFERENCES producto(producto_id),
FOREIGN KEY (proveedor_id) REFERENCES proveedor(proveedor_id)
)

CREATE TABLE VENTA(
folio VARCHAR(18) NOT NULL,
fecha DATE NOT NULL DEFAULT getDate(),
cliente_id VARCHAR(18),
empleado_id VARCHAR(18) NOT NULL,
producto_id VARCHAR(18) NOT NULL,
cantidad INT NOT NULL,
total INT NOT NULL,
CONSTRAINT PK_folio PRIMARY KEY(folio),
FOREIGN KEY (cliente_id) REFERENCES cliente(cliente_id),
FOREIGN KEY (empleado_id) REFERENCES empleado(empleado_id),
FOREIGN KEY (producto_id) REFERENCES producto(producto_id),
)

CREATE TABLE BITACORA_EMPLEADO(
	empleado_id varchar(18) NULL,
	nombre varchar(50) NULL,
	telefono varchar(10) NULL,
	puesto_id varchar(20) NULL,
	fecha date NULL,
	usuario varchar(30) NULL,
	terminal varchar(30) NULL
)

+-
--VISTAS
create view empleadospuesto
as SELECT EMPLEADO.empleado_id, EMPLEADO.nombre, PUESTO.puesto_id, PUESTO.salario
FROM EMPLEADO INNER JOIN PUESTO ON EMPLEADO.puesto_id = PUESTO.puesto_id


create view ventaempleado
as SELECT EMPLEADO.empleado_id, EMPLEADO.nombre as 'Nombre empleado', VENTA.cliente_id, CLIENTE.nombre as 'Nombre cliente', VENTA.total
FROM EMPLEADO INNER JOIN VENTA ON EMPLEADO.empleado_id = VENTA.empleado_id
INNER JOIN CLIENTE ON VENTA.cliente_id = CLIENTE.cliente_id


create view VentasCliente
as select folio, fecha, CLIENTE.cliente_id, empleado_id, producto_id, cantidad, total 
from VENTA inner join CLIENTE on  VENTA    .cliente_id = CLIENTE.cliente_id



create view VerInventario
as select PRODUCTO.producto_id, cantidad, descripcion
from INVENTARIO inner join PRODUCTO on PRODUCTO.producto_id = INVENTARIO.producto_id

--FUNCIONES

 CREATE FUNCTION DBO.preciototal()
RETURNS FLOAT
AS
    BEGIN
        DECLARE @total float
        SELECT @total = SUM(precio) FROM PRODUCTO
        RETURN @total
    END

create function DBO.SalarioPromedio()
returns float
as
    begin
        declare @nosalario float
        declare @noempleado float
        declare @suma float
        select @noempleado = count(puesto_id) from EMPLEADO
        select @nosalario = sum(salario) from PUESTO
        select @suma = @nosalario / @noempleado
        return @suma
    end

CREATE FUNCTION DBO.SalarioTotal()
RETURNS FLOAT
AS
    BEGIN
        DECLARE @total float
        SELECT @total = SUM(salario) FROM PUESTO
        RETURN @total
    END

CREATE FUNCTION DBO.PRECIOPROMEDIO()
RETURNS FLOAT
AS
	BEGIN
	DECLARE @PROMEDIO FLOAT
	SELECT @PROMEDIO = total / cantidad FROM VENTA
	RETURN @PROMEDIO
END


--TRIGGERS

create trigger eliminar_cliente
on CLIENTE
for delete
as
if exists (select * from VENTA where VENTA.cliente_id = (select deleted.cliente_id from deleted))
begin
    rollback transaction
print 'El cliente tiene ventas registradas no puede eliminarse'
    end 
else
    print 'cliente eliminado'
go

create trigger AvisoCliente
on CLIENTE
after insert, update
as
print 'Se modifico o actualizo la tabla de clientes'

CREATE TRIGGER TRIGGER_BITACORA_EMPLEADO
ON EMPLEADO 
AFTER INSERT
AS
BEGIN
INSERT INTO BITACORA_EMPLEADO(empleado_id,nombre, telefono, puesto_id,usuario,fecha,terminal)
SELECT empleado_id,nombre, telefono, puesto_id, system_user,getdate(),host_name() FROM INSERTED
END;


CREATE TRIGGER TRIGGER_INVENTARIOSTOCK
ON VENTA
FOR INSERT
AS
DECLARE @STOCK INT
SELECT @STOCK = INVENTARIO.cantidad FROM INVENTARIO
JOIN INSERTED ON INVENTARIO.producto_id=INSERTED.producto_id
BEGIN
	IF (@STOCK>=(SELECT cantidad FROM INSERTED))
		BEGIN
			UPDATE INVENTARIO SET cantidad = INVENTARIO.cantidad - inserted.cantidad FROM INVENTARIO JOIN INSERTED ON INSERTED.producto_id = INVENTARIO.producto_id
			PRINT 'ADQUIRIDO CORRECTAMENTE'
		END
	ELSE
		BEGIN
			ROLLBACK TRANSACTION
			PRINT 'NO HAY STOCK DEL PRODUCTO'
		END
END	

--PROCEDIMIENTOS

create procedure InsertarCliente
@CClave varchar(18),
@CNombre varchar(50),
@CTelefono varchar(10),
@CDireccion varchar (30),
@CCorreo varchar(30)
AS BEGIN
    IF EXISTS (SELECT * FROM CLIENTE WHERE cliente_id = @CClave)
        BEGIN
            PRINT 'Cliente ya existe'
            RETURN
        END
    INSERT INTO CLIENTE(cliente_id,nombre,telefono,direccion,correo) VALUES (@CClave,@CNombre,@CTelefono,@CDireccion,@CCorreo);
END 

 create procedure InsertarEmpleado
@EClave varchar(18),
@ENombre varchar(50),
@ETelefono varchar(10),
@EDireccion varchar (30),
@ECorreo varchar(30),
@EPuesto varchar(20),
@EFecha date,
@EEdad int
AS BEGIN
    IF EXISTS (SELECT * FROM EMPLEADO WHERE empleado_id = @EClave)
        BEGIN
            PRINT 'Empleado ya existe'
            RETURN
        END
    INSERT INTO EMPLEADO(empleado_id,nombre,telefono,direccion,correo,puesto_id,fecha_nac,edad) VALUES (@EClave,@ENombre,@ETelefono,@EDireccion,@ECorreo,@EPuesto,@EFecha,@EEdad);
END 

CREATE PROCEDURE ConsultaVentaDia
@fecha DATETIME AS BEGIN
 SELECT * FROM venta WHERE fecha = @fecha END

CREATE PROCEDURE ConsultaStock
AS BEGIN
	SELECT INVENTARIO.cantidad, PRODUCTO.nombre FROM INVENTARIO INNER JOIN PRODUCTO ON INVENTARIO.producto_id = PRODUCTO.producto_id
	RETURN
END

CREATE PROCEDURE ELIMINAR_EMPLEADO
@ID VARCHAR(18)
AS
begin
If not exists(SELECT * FROM EMPLEADO where empleado_id=@ID) BEGIN
Print 'Este empleado no existe'
RETURN
END
If exists(SELECT * FROM EMPLEADO where empleado_id=@ID)
BEGIN
DELETE EMPLEADO WHERE empleado_id=@ID
PRINT 'Se eliminó EMPLEADO correctamente'
RETURN
END
END

CREATE PROCEDURE PROC_ELIMINARCLIENTE
@ID VARCHAR(18)
AS
begin
If not exists(SELECT * FROM CLIENTE where cliente_id=@ID) BEGIN
Print 'Este CLIENTE no existe'
RETURN
END
If exists(SELECT * FROM CLIENTE where cliente_id=@ID)
BEGIN
DELETE CLIENTE where cliente_id=@ID
PRINT 'Se eliminó CLIENTE correctamente'
RETURN
END
END

CREATE PROCEDURE PROC_ELIMINARPRODUCTO
@ID VARCHAR(18)
AS
begin
If not exists(SELECT * FROM PRODUCTO where producto_id=@ID) BEGIN
Print 'Este PRODUCTO no existe'
RETURN
END
If exists(SELECT * FROM PRODUCTO where producto_id=@ID)
BEGIN
DELETE PRODUCTO where producto_id=@ID
PRINT 'Se eliminó PRODUCTO correctamente'
RETURN
END
END

CREATE PROCEDURE ELIMINAR_VENTA
@ID VARCHAR(18)
AS
begin
If not exists(SELECT * FROM VENTA where folio=@ID) BEGIN
Print 'Esta venta no existe'
RETURN
END
If exists(SELECT * FROM VENTA where folio=@ID)
BEGIN
DELETE VENTA WHERE folio=@ID
PRINT 'Se eliminó la venta correctamente'
RETURN
END
END

CREATE PROCEDURE InsertarVenta
@VFolio varchar(18),
@VFecha date,
@VCliente varchar(18),
@VEmpleado varchar(18),
@VProducto varchar(18),
@VCantidad int,
@VTotal int
AS BEGIN
    IF EXISTS (SELECT * FROM VENTA WHERE folio = @VFolio)
        BEGIN
            PRINT 'Venta ya existente'
            RETURN
        END
    INSERT INTO VENTA(folio,fecha,cliente_id,empleado_id,producto_id,cantidad,total) VALUES(@VFolio,@VFecha,@VCliente,@VEmpleado,@VProducto,@VCantidad,@VTotal)
END

CREATE PROCEDURE InsertarProducto
@PClave varchar(18),
@PNombre varchar(15),
@PDescripcion varchar(20),
@PPrecio int
AS BEGIN
    IF EXISTS (SELECT * FROM PRODUCTO WHERE producto_id = @PClave)
        BEGIN
            PRINT 'Producto ya existente'
            RETURN
        END
    INSERT INTO PRODUCTO VALUES(@PClave,@PNombre,@PDescripcion,@PPrecio)
END