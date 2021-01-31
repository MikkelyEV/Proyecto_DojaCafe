
namespace DojaCafe
{
    partial class Bitacora_ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora_ventas));
            this.dgv_ventas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_volver = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_mod = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ventas
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgv_ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ventas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ventas.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ventas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ventas.EnableHeadersVisualStyles = false;
            this.dgv_ventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgv_ventas.Location = new System.Drawing.Point(12, 3);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.RowHeadersVisible = false;
            this.dgv_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ventas.Size = new System.Drawing.Size(564, 444);
            this.dgv_ventas.TabIndex = 0;
            this.dgv_ventas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.dgv_ventas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgv_ventas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_ventas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_ventas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_ventas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_ventas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ventas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgv_ventas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.dgv_ventas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ventas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.dgv_ventas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_ventas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ventas.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_ventas.ThemeStyle.ReadOnly = false;
            this.dgv_ventas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dgv_ventas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ventas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_ventas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_ventas.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_ventas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.dgv_ventas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btn_volver
            // 
            this.btn_volver.Animated = true;
            this.btn_volver.AutoRoundedCorners = true;
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            this.btn_volver.BorderRadius = 17;
            this.btn_volver.BorderThickness = 1;
            this.btn_volver.CheckedState.Parent = this.btn_volver;
            this.btn_volver.CustomImages.Parent = this.btn_volver;
            this.btn_volver.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.btn_volver.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(65)))));
            this.btn_volver.HoverState.Parent = this.btn_volver;
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_volver.Location = new System.Drawing.Point(656, 298);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_volver.ShadowDecoration.BorderRadius = 22;
            this.btn_volver.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_volver.ShadowDecoration.Enabled = true;
            this.btn_volver.ShadowDecoration.Parent = this.btn_volver;
            this.btn_volver.Size = new System.Drawing.Size(113, 37);
            this.btn_volver.TabIndex = 62;
            this.btn_volver.Text = "Volver";
            this.btn_volver.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Animated = true;
            this.btn_guardar.AutoRoundedCorners = true;
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            this.btn_guardar.BorderRadius = 17;
            this.btn_guardar.BorderThickness = 1;
            this.btn_guardar.CheckedState.Parent = this.btn_guardar;
            this.btn_guardar.CustomImages.Parent = this.btn_guardar;
            this.btn_guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.btn_guardar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(65)))));
            this.btn_guardar.HoverState.Parent = this.btn_guardar;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_guardar.Location = new System.Drawing.Point(656, 221);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_guardar.ShadowDecoration.BorderRadius = 22;
            this.btn_guardar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_guardar.ShadowDecoration.Enabled = true;
            this.btn_guardar.ShadowDecoration.Parent = this.btn_guardar;
            this.btn_guardar.Size = new System.Drawing.Size(113, 37);
            this.btn_guardar.TabIndex = 61;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btn_mod
            // 
            this.btn_mod.Animated = true;
            this.btn_mod.AutoRoundedCorners = true;
            this.btn_mod.BackColor = System.Drawing.Color.Transparent;
            this.btn_mod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            this.btn_mod.BorderRadius = 17;
            this.btn_mod.BorderThickness = 1;
            this.btn_mod.CheckedState.Parent = this.btn_mod;
            this.btn_mod.CustomImages.Parent = this.btn_mod;
            this.btn_mod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.btn_mod.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(65)))));
            this.btn_mod.HoverState.Parent = this.btn_mod;
            this.btn_mod.Image = ((System.Drawing.Image)(resources.GetObject("btn_mod.Image")));
            this.btn_mod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_mod.Location = new System.Drawing.Point(656, 143);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_mod.ShadowDecoration.BorderRadius = 22;
            this.btn_mod.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_mod.ShadowDecoration.Enabled = true;
            this.btn_mod.ShadowDecoration.Parent = this.btn_mod;
            this.btn_mod.Size = new System.Drawing.Size(113, 37);
            this.btn_mod.TabIndex = 60;
            this.btn_mod.Text = "Modificar";
            this.btn_mod.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.AutoRoundedCorners = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(145)))));
            this.btn_delete.BorderRadius = 17;
            this.btn_delete.BorderThickness = 1;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(161)))));
            this.btn_delete.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(65)))));
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_delete.Location = new System.Drawing.Point(656, 76);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_delete.ShadowDecoration.BorderRadius = 22;
            this.btn_delete.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_delete.ShadowDecoration.Enabled = true;
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(113, 37);
            this.btn_delete.TabIndex = 59;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // Bitacora_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(122)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bitacora_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_ventas;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2Button btn_mod;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_volver;
    }
}