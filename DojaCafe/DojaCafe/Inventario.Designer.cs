
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
            this.cantidad_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbx_prov = new System.Windows.Forms.ComboBox();
            this.prov_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ID_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbx_id = new System.Windows.Forms.ComboBox();
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
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(726, 63);
            this.guna2Panel1.TabIndex = 69;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(-1, -332);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(727, 432);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Location = new System.Drawing.Point(266, 10);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(225, 162);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Animated = true;
            this.dtp_fecha.AutoRoundedCorners = true;
            this.dtp_fecha.BackColor = System.Drawing.Color.Transparent;
            this.dtp_fecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.dtp_fecha.BorderRadius = 17;
            this.dtp_fecha.BorderThickness = 2;
            this.dtp_fecha.CheckedState.Parent = this.dtp_fecha;
            this.dtp_fecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.dtp_fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.HoverState.Parent = this.dtp_fecha;
            this.dtp_fecha.Location = new System.Drawing.Point(166, 389);
            this.dtp_fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.ShadowDecoration.BorderRadius = 22;
            this.dtp_fecha.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.dtp_fecha.ShadowDecoration.Parent = this.dtp_fecha;
            this.dtp_fecha.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.dtp_fecha.Size = new System.Drawing.Size(118, 36);
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
            this.btn_mod.BorderRadius = 17;
            this.btn_mod.BorderThickness = 1;
            this.btn_mod.CheckedState.Parent = this.btn_mod;
            this.btn_mod.CustomImages.Parent = this.btn_mod;
            this.btn_mod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(88)))));
            this.btn_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.ForeColor = System.Drawing.Color.White;
            this.btn_mod.HoverState.Parent = this.btn_mod;
            this.btn_mod.Image = ((System.Drawing.Image)(resources.GetObject("btn_mod.Image")));
            this.btn_mod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_mod.Location = new System.Drawing.Point(601, 135);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_mod.ShadowDecoration.BorderRadius = 22;
            this.btn_mod.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_mod.ShadowDecoration.Enabled = true;
            this.btn_mod.ShadowDecoration.Parent = this.btn_mod;
            this.btn_mod.Size = new System.Drawing.Size(113, 37);
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
            this.btn_add.BorderRadius = 17;
            this.btn_add.BorderThickness = 1;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(88)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_add.Location = new System.Drawing.Point(601, 210);
            this.btn_add.Name = "btn_add";
            this.btn_add.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_add.ShadowDecoration.BorderRadius = 22;
            this.btn_add.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_add.ShadowDecoration.Enabled = true;
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(113, 37);
            this.btn_add.TabIndex = 66;
            this.btn_add.Text = "Registrar";
            this.btn_add.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // fecha_lbl
            // 
            this.fecha_lbl.BackColor = System.Drawing.Color.Transparent;
            this.fecha_lbl.Enabled = false;
            this.fecha_lbl.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_lbl.Location = new System.Drawing.Point(198, 360);
            this.fecha_lbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fecha_lbl.Name = "fecha_lbl";
            this.fecha_lbl.Size = new System.Drawing.Size(54, 24);
            this.fecha_lbl.TabIndex = 65;
            this.fecha_lbl.Text = "Fecha";
            // 
            // cantidad_lbl
            // 
            this.cantidad_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cantidad_lbl.Enabled = false;
            this.cantidad_lbl.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_lbl.Location = new System.Drawing.Point(266, 285);
            this.cantidad_lbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cantidad_lbl.Name = "cantidad_lbl";
            this.cantidad_lbl.Size = new System.Drawing.Size(50, 24);
            this.cantidad_lbl.TabIndex = 63;
            this.cantidad_lbl.Text = "Stock";
            // 
            // cbx_prov
            // 
            this.cbx_prov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.cbx_prov.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_prov.FormattingEnabled = true;
            this.cbx_prov.Location = new System.Drawing.Point(405, 314);
            this.cbx_prov.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_prov.Name = "cbx_prov";
            this.cbx_prov.Size = new System.Drawing.Size(86, 28);
            this.cbx_prov.TabIndex = 62;
            this.cbx_prov.SelectedIndexChanged += new System.EventHandler(this.prov_cbx_SelectedIndexChanged);
            // 
            // prov_lbl
            // 
            this.prov_lbl.BackColor = System.Drawing.Color.Transparent;
            this.prov_lbl.Enabled = false;
            this.prov_lbl.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prov_lbl.Location = new System.Drawing.Point(401, 285);
            this.prov_lbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prov_lbl.Name = "prov_lbl";
            this.prov_lbl.Size = new System.Drawing.Size(90, 24);
            this.prov_lbl.TabIndex = 61;
            this.prov_lbl.Text = "Proveedor";
            // 
            // ID_lbl
            // 
            this.ID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ID_lbl.Enabled = false;
            this.ID_lbl.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lbl.Location = new System.Drawing.Point(57, 285);
            this.ID_lbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(137, 24);
            this.ID_lbl.TabIndex = 60;
            this.ID_lbl.Text = "ID del producto";
            // 
            // cbx_id
            // 
            this.cbx_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.cbx_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_id.FormattingEnabled = true;
            this.cbx_id.Location = new System.Drawing.Point(57, 313);
            this.cbx_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_id.Name = "cbx_id";
            this.cbx_id.Size = new System.Drawing.Size(86, 28);
            this.cbx_id.TabIndex = 59;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Animated = true;
            this.btn_guardar.AutoRoundedCorners = true;
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_guardar.BorderRadius = 17;
            this.btn_guardar.BorderThickness = 1;
            this.btn_guardar.CheckedState.Parent = this.btn_guardar;
            this.btn_guardar.CustomImages.Parent = this.btn_guardar;
            this.btn_guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(88)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.HoverState.Parent = this.btn_guardar;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_guardar.Location = new System.Drawing.Point(601, 285);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_guardar.ShadowDecoration.BorderRadius = 22;
            this.btn_guardar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_guardar.ShadowDecoration.Enabled = true;
            this.btn_guardar.ShadowDecoration.Parent = this.btn_guardar;
            this.btn_guardar.Size = new System.Drawing.Size(113, 37);
            this.btn_guardar.TabIndex = 58;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // pbx_clipboard
            // 
            this.pbx_clipboard.FillColor = System.Drawing.Color.White;
            this.pbx_clipboard.Image = ((System.Drawing.Image)(resources.GetObject("pbx_clipboard.Image")));
            this.pbx_clipboard.Location = new System.Drawing.Point(28, 81);
            this.pbx_clipboard.Name = "pbx_clipboard";
            this.pbx_clipboard.ShadowDecoration.BorderRadius = 3;
            this.pbx_clipboard.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbx_clipboard.ShadowDecoration.Parent = this.pbx_clipboard;
            this.pbx_clipboard.Size = new System.Drawing.Size(24, 24);
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
            this.lbl_productos.ForeColor = System.Drawing.Color.Black;
            this.lbl_productos.Location = new System.Drawing.Point(57, 76);
            this.lbl_productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(109, 32);
            this.lbl_productos.TabIndex = 56;
            this.lbl_productos.Text = "Articulos";
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
            this.dgv_productos.Location = new System.Drawing.Point(22, 110);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(469, 171);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(726, 440);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.fecha_lbl);
            this.Controls.Add(this.cantidad_lbl);
            this.Controls.Add(this.cbx_prov);
            this.Controls.Add(this.prov_lbl);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.cbx_id);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.pbx_clipboard);
            this.Controls.Add(this.lbl_productos);
            this.Controls.Add(this.dgv_productos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Guna.UI2.WinForms.Guna2HtmlLabel cantidad_lbl;
        private System.Windows.Forms.ComboBox cbx_prov;
        private Guna.UI2.WinForms.Guna2HtmlLabel prov_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel ID_lbl;
        private System.Windows.Forms.ComboBox cbx_id;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbx_clipboard;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_productos;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_productos;
    }
}