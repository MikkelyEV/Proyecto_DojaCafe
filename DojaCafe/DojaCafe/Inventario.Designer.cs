
namespace DojaCafe
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtp_fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_mod = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.fecha_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_precio = new Guna.UI2.WinForms.Guna2TextBox();
            this.cantidad_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.prov_cbx = new System.Windows.Forms.ComboBox();
            this.prov_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ID_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.id_cbx = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.pbx_clipboard = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_productos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgv_productos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_clipboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(823, 77);
            this.guna2Panel1.TabIndex = 69;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(4, -80);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(823, 411);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Location = new System.Drawing.Point(355, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Animated = true;
            this.dtp_fecha.AutoRoundedCorners = true;
            this.dtp_fecha.BackColor = System.Drawing.Color.Transparent;
            this.dtp_fecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.dtp_fecha.BorderRadius = 21;
            this.dtp_fecha.BorderThickness = 2;
            this.dtp_fecha.CheckedState.Parent = this.dtp_fecha;
            this.dtp_fecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.dtp_fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.HoverState.Parent = this.dtp_fecha;
            this.dtp_fecha.Location = new System.Drawing.Point(383, 386);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.ShadowDecoration.BorderRadius = 22;
            this.dtp_fecha.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.dtp_fecha.ShadowDecoration.Parent = this.dtp_fecha;
            this.dtp_fecha.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.dtp_fecha.Size = new System.Drawing.Size(157, 44);
            this.dtp_fecha.TabIndex = 68;
            this.dtp_fecha.UseTransparentBackground = true;
            this.dtp_fecha.Value = new System.DateTime(2021, 1, 30, 20, 9, 59, 22);
            // 
            // btn_mod
            // 
            this.btn_mod.Animated = true;
            this.btn_mod.AutoRoundedCorners = true;
            this.btn_mod.BackColor = System.Drawing.Color.Transparent;
            this.btn_mod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_mod.BorderRadius = 22;
            this.btn_mod.BorderThickness = 1;
            this.btn_mod.CheckedState.Parent = this.btn_mod;
            this.btn_mod.CustomImages.Parent = this.btn_mod;
            this.btn_mod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(88)))));
            this.btn_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.ForeColor = System.Drawing.Color.White;
            this.btn_mod.HoverState.Parent = this.btn_mod;
            this.btn_mod.Image = ((System.Drawing.Image)(resources.GetObject("btn_mod.Image")));
            this.btn_mod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_mod.Location = new System.Drawing.Point(644, 287);
            this.btn_mod.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_mod.ShadowDecoration.BorderRadius = 22;
            this.btn_mod.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_mod.ShadowDecoration.Enabled = true;
            this.btn_mod.ShadowDecoration.Parent = this.btn_mod;
            this.btn_mod.Size = new System.Drawing.Size(151, 46);
            this.btn_mod.TabIndex = 67;
            this.btn_mod.Text = "Modificar";
            this.btn_mod.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btn_add
            // 
            this.btn_add.Animated = true;
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_add.BorderRadius = 22;
            this.btn_add.BorderThickness = 1;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(88)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_add.Location = new System.Drawing.Point(644, 364);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_add.ShadowDecoration.BorderRadius = 22;
            this.btn_add.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_add.ShadowDecoration.Enabled = true;
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(151, 46);
            this.btn_add.TabIndex = 66;
            this.btn_add.Text = "Registrar";
            this.btn_add.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // fecha_lbl
            // 
            this.fecha_lbl.BackColor = System.Drawing.Color.Transparent;
            this.fecha_lbl.Enabled = false;
            this.fecha_lbl.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_lbl.Location = new System.Drawing.Point(383, 351);
            this.fecha_lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fecha_lbl.Name = "fecha_lbl";
            this.fecha_lbl.Size = new System.Drawing.Size(68, 30);
            this.fecha_lbl.TabIndex = 65;
            this.fecha_lbl.Text = "Fecha";
            // 
            // txb_precio
            // 
            this.txb_precio.Animated = true;
            this.txb_precio.BackColor = System.Drawing.Color.Transparent;
            this.txb_precio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(88)))));
            this.txb_precio.BorderRadius = 1;
            this.txb_precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_precio.DefaultText = "";
            this.txb_precio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_precio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_precio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_precio.DisabledState.Parent = this.txb_precio;
            this.txb_precio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_precio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.txb_precio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_precio.FocusedState.Parent = this.txb_precio;
            this.txb_precio.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txb_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_precio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_precio.HoverState.Parent = this.txb_precio;
            this.txb_precio.Location = new System.Drawing.Point(214, 396);
            this.txb_precio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_precio.Name = "txb_precio";
            this.txb_precio.PasswordChar = '\0';
            this.txb_precio.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(137)))), ((int)(((byte)(129)))));
            this.txb_precio.PlaceholderText = "";
            this.txb_precio.SelectedText = "";
            this.txb_precio.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(41)))), ((int)(((byte)(31)))));
            this.txb_precio.ShadowDecoration.Depth = 15;
            this.txb_precio.ShadowDecoration.Enabled = true;
            this.txb_precio.ShadowDecoration.Parent = this.txb_precio;
            this.txb_precio.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.txb_precio.Size = new System.Drawing.Size(123, 23);
            this.txb_precio.TabIndex = 64;
            this.txb_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cantidad_lbl
            // 
            this.cantidad_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cantidad_lbl.Enabled = false;
            this.cantidad_lbl.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_lbl.Location = new System.Drawing.Point(231, 351);
            this.cantidad_lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cantidad_lbl.Name = "cantidad_lbl";
            this.cantidad_lbl.Size = new System.Drawing.Size(62, 30);
            this.cantidad_lbl.TabIndex = 63;
            this.cantidad_lbl.Text = "Stock";
            // 
            // prov_cbx
            // 
            this.prov_cbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.prov_cbx.FormattingEnabled = true;
            this.prov_cbx.Location = new System.Drawing.Point(34, 451);
            this.prov_cbx.Name = "prov_cbx";
            this.prov_cbx.Size = new System.Drawing.Size(114, 24);
            this.prov_cbx.TabIndex = 62;
            // 
            // prov_lbl
            // 
            this.prov_lbl.BackColor = System.Drawing.Color.Transparent;
            this.prov_lbl.Enabled = false;
            this.prov_lbl.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prov_lbl.Location = new System.Drawing.Point(34, 416);
            this.prov_lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prov_lbl.Name = "prov_lbl";
            this.prov_lbl.Size = new System.Drawing.Size(114, 30);
            this.prov_lbl.TabIndex = 61;
            this.prov_lbl.Text = "Proveedor";
            // 
            // ID_lbl
            // 
            this.ID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ID_lbl.Enabled = false;
            this.ID_lbl.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lbl.Location = new System.Drawing.Point(34, 351);
            this.ID_lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(173, 30);
            this.ID_lbl.TabIndex = 60;
            this.ID_lbl.Text = "ID del producto";
            // 
            // id_cbx
            // 
            this.id_cbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.id_cbx.FormattingEnabled = true;
            this.id_cbx.Location = new System.Drawing.Point(34, 386);
            this.id_cbx.Name = "id_cbx";
            this.id_cbx.Size = new System.Drawing.Size(114, 24);
            this.id_cbx.TabIndex = 59;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Animated = true;
            this.btn_guardar.AutoRoundedCorners = true;
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_guardar.BorderRadius = 22;
            this.btn_guardar.BorderThickness = 1;
            this.btn_guardar.CheckedState.Parent = this.btn_guardar;
            this.btn_guardar.CustomImages.Parent = this.btn_guardar;
            this.btn_guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(88)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.HoverState.Parent = this.btn_guardar;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_guardar.Location = new System.Drawing.Point(644, 429);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_guardar.ShadowDecoration.BorderRadius = 22;
            this.btn_guardar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_guardar.ShadowDecoration.Enabled = true;
            this.btn_guardar.ShadowDecoration.Parent = this.btn_guardar;
            this.btn_guardar.Size = new System.Drawing.Size(151, 46);
            this.btn_guardar.TabIndex = 58;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // pbx_clipboard
            // 
            this.pbx_clipboard.FillColor = System.Drawing.Color.White;
            this.pbx_clipboard.Image = ((System.Drawing.Image)(resources.GetObject("pbx_clipboard.Image")));
            this.pbx_clipboard.Location = new System.Drawing.Point(37, 100);
            this.pbx_clipboard.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_clipboard.Name = "pbx_clipboard";
            this.pbx_clipboard.ShadowDecoration.BorderRadius = 3;
            this.pbx_clipboard.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbx_clipboard.ShadowDecoration.Parent = this.pbx_clipboard;
            this.pbx_clipboard.Size = new System.Drawing.Size(32, 30);
            this.pbx_clipboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_clipboard.TabIndex = 57;
            this.pbx_clipboard.TabStop = false;
            this.pbx_clipboard.UseTransparentBackground = true;
            // 
            // lbl_productos
            // 
            this.lbl_productos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_productos.Enabled = false;
            this.lbl_productos.Font = new System.Drawing.Font("Montserrat Alternates", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.Location = new System.Drawing.Point(76, 93);
            this.lbl_productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(72, 39);
            this.lbl_productos.TabIndex = 56;
            this.lbl_productos.Text = "Lista";
            // 
            // dgv_productos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productos.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productos.EnableHeadersVisualStyles = false;
            this.dgv_productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_productos.Location = new System.Drawing.Point(30, 136);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(584, 211);
            this.dgv_productos.TabIndex = 55;
            this.dgv_productos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_productos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_productos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_productos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_productos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_productos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_productos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.dgv_productos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_productos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_productos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_productos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_productos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_productos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_productos.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_productos.ThemeStyle.ReadOnly = true;
            this.dgv_productos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_productos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_productos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_productos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.dgv_productos.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_productos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_productos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(823, 491);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.fecha_lbl);
            this.Controls.Add(this.txb_precio);
            this.Controls.Add(this.cantidad_lbl);
            this.Controls.Add(this.prov_cbx);
            this.Controls.Add(this.prov_lbl);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.id_cbx);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.pbx_clipboard);
            this.Controls.Add(this.lbl_productos);
            this.Controls.Add(this.dgv_productos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_clipboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fecha;
        private Guna.UI2.WinForms.Guna2Button btn_mod;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2HtmlLabel fecha_lbl;
        private Guna.UI2.WinForms.Guna2TextBox txb_precio;
        private Guna.UI2.WinForms.Guna2HtmlLabel cantidad_lbl;
        private System.Windows.Forms.ComboBox prov_cbx;
        private Guna.UI2.WinForms.Guna2HtmlLabel prov_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel ID_lbl;
        private System.Windows.Forms.ComboBox id_cbx;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbx_clipboard;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_productos;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_productos;
    }
}