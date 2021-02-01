
namespace DojaCafe
{
    partial class Bitacora_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora_Empleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_volver = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_empleado = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).BeginInit();
            this.SuspendLayout();
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
            this.btn_volver.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(119)))), ((int)(((byte)(80)))));
            this.btn_volver.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(65)))));
            this.btn_volver.HoverState.Parent = this.btn_volver;
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_volver.Location = new System.Drawing.Point(666, 298);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btn_volver.ShadowDecoration.BorderRadius = 22;
            this.btn_volver.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btn_volver.ShadowDecoration.Enabled = true;
            this.btn_volver.ShadowDecoration.Parent = this.btn_volver;
            this.btn_volver.Size = new System.Drawing.Size(113, 37);
            this.btn_volver.TabIndex = 72;
            this.btn_volver.Text = "Volver";
            this.btn_volver.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // dgv_empleado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_empleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_empleado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_empleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_empleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_empleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_empleado.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_empleado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_empleado.EnableHeadersVisualStyles = false;
            this.dgv_empleado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_empleado.Location = new System.Drawing.Point(22, 3);
            this.dgv_empleado.Name = "dgv_empleado";
            this.dgv_empleado.ReadOnly = true;
            this.dgv_empleado.RowHeadersVisible = false;
            this.dgv_empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_empleado.Size = new System.Drawing.Size(564, 444);
            this.dgv_empleado.TabIndex = 68;
            this.dgv_empleado.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgv_empleado.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgv_empleado.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_empleado.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_empleado.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_empleado.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_empleado.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_empleado.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgv_empleado.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgv_empleado.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_empleado.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_empleado.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_empleado.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_empleado.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_empleado.ThemeStyle.ReadOnly = true;
            this.dgv_empleado.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgv_empleado.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_empleado.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_empleado.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_empleado.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_empleado.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgv_empleado.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Bitacora_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(183)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dgv_empleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bitacora_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_volver;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_empleado;
    }
}