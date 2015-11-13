namespace UTN.SistemaAlumnos.UI
{
    partial class FrmMateriaDivision
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
            this.btn_mostrar_listado = new System.Windows.Forms.Button();
            this.cbo_division = new System.Windows.Forms.ComboBox();
            this.cbo_materia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mostrar_listado
            // 
            this.btn_mostrar_listado.Location = new System.Drawing.Point(92, 109);
            this.btn_mostrar_listado.Name = "btn_mostrar_listado";
            this.btn_mostrar_listado.Size = new System.Drawing.Size(101, 51);
            this.btn_mostrar_listado.TabIndex = 9;
            this.btn_mostrar_listado.Text = "Mostrar listado";
            this.btn_mostrar_listado.UseVisualStyleBackColor = true;
            this.btn_mostrar_listado.Click += new System.EventHandler(this.btn_mostrar_listado_Click);
            // 
            // cbo_division
            // 
            this.cbo_division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_division.FormattingEnabled = true;
            this.cbo_division.Location = new System.Drawing.Point(92, 64);
            this.cbo_division.Name = "cbo_division";
            this.cbo_division.Size = new System.Drawing.Size(121, 21);
            this.cbo_division.TabIndex = 8;
            // 
            // cbo_materia
            // 
            this.cbo_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_materia.FormattingEnabled = true;
            this.cbo_materia.Location = new System.Drawing.Point(92, 34);
            this.cbo_materia.Name = "cbo_materia";
            this.cbo_materia.Size = new System.Drawing.Size(121, 21);
            this.cbo_materia.TabIndex = 7;
            this.cbo_materia.SelectedIndexChanged += new System.EventHandler(this.cbo_materia_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "División:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Materia:";
            // 
            // FrmMateriaDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 178);
            this.Controls.Add(this.btn_mostrar_listado);
            this.Controls.Add(this.cbo_division);
            this.Controls.Add(this.cbo_materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMateriaDivision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elija materia y división";
            this.Load += new System.EventHandler(this.FrmMateriaDivision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrar_listado;
        private System.Windows.Forms.ComboBox cbo_division;
        private System.Windows.Forms.ComboBox cbo_materia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}