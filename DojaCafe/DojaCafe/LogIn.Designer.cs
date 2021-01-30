namespace DojaCafe
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                new Menu();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txtb_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtb_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DojaCafe.Properties.Resources.loginpng;
            this.pictureBox1.Location = new System.Drawing.Point(119, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Sienna;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aceptar.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.Peru;
            this.btn_aceptar.Location = new System.Drawing.Point(82, 431);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(98, 38);
            this.btn_aceptar.TabIndex = 12;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_usuario.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_usuario.Location = new System.Drawing.Point(65, 253);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(0, 17);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Click += new System.EventHandler(this.lbl_usuario_Click);
            // 
            // txtb_usuario
            // 
            this.txtb_usuario.BackColor = System.Drawing.Color.SandyBrown;
            this.txtb_usuario.BorderColor = System.Drawing.Color.Transparent;
            this.txtb_usuario.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtb_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_usuario.DefaultText = "";
            this.txtb_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtb_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtb_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_usuario.DisabledState.Parent = this.txtb_usuario;
            this.txtb_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_usuario.FillColor = System.Drawing.Color.Sienna;
            this.txtb_usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_usuario.FocusedState.Parent = this.txtb_usuario;
            this.txtb_usuario.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_usuario.HoverState.Parent = this.txtb_usuario;
            this.txtb_usuario.Location = new System.Drawing.Point(104, 253);
            this.txtb_usuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtb_usuario.MaxLength = 5;
            this.txtb_usuario.Name = "txtb_usuario";
            this.txtb_usuario.PasswordChar = '\0';
            this.txtb_usuario.PlaceholderForeColor = System.Drawing.Color.Peru;
            this.txtb_usuario.PlaceholderText = "usuario";
            this.txtb_usuario.SelectedText = "";
            this.txtb_usuario.ShadowDecoration.Parent = this.txtb_usuario;
            this.txtb_usuario.Size = new System.Drawing.Size(220, 32);
            this.txtb_usuario.TabIndex = 19;
            this.txtb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_usuario.TextChanged += new System.EventHandler(this.txtb_usuario_TextChanged_1);
            // 
            // txtb_password
            // 
            this.txtb_password.BackColor = System.Drawing.Color.SandyBrown;
            this.txtb_password.BorderColor = System.Drawing.Color.Transparent;
            this.txtb_password.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_password.DefaultText = "";
            this.txtb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_password.DisabledState.Parent = this.txtb_password;
            this.txtb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_password.FillColor = System.Drawing.Color.Sienna;
            this.txtb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_password.FocusedState.Parent = this.txtb_password;
            this.txtb_password.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_password.HoverState.Parent = this.txtb_password;
            this.txtb_password.Location = new System.Drawing.Point(104, 315);
            this.txtb_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtb_password.MaxLength = 3;
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.PasswordChar = '*';
            this.txtb_password.PlaceholderForeColor = System.Drawing.Color.Peru;
            this.txtb_password.PlaceholderText = "contraseña";
            this.txtb_password.SelectedText = "";
            this.txtb_password.ShadowDecoration.Parent = this.txtb_password;
            this.txtb_password.Size = new System.Drawing.Size(220, 32);
            this.txtb_password.TabIndex = 20;
            this.txtb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_password.TextChanged += new System.EventHandler(this.txtb_password_TextChanged_1);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Sienna;
            this.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Peru;
            this.btn_salir.Location = new System.Drawing.Point(245, 431);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(98, 38);
            this.btn_salir.TabIndex = 21;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.CancelButton = this.btn_salir;
            this.ClientSize = new System.Drawing.Size(416, 503);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txtb_password);
            this.Controls.Add(this.txtb_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lbl_usuario;
        private Guna.UI2.WinForms.Guna2TextBox txtb_usuario;
        private Guna.UI2.WinForms.Guna2TextBox txtb_password;
        private System.Windows.Forms.Button btn_salir;
    }
}

