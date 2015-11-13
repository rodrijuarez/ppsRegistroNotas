namespace UTN.SistemaAlumnos.UI
{
    partial class FrmListadoDeAsistencias
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
            this.btn_filtrado = new System.Windows.Forms.Button();
            this.btn_completo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_filtrado
            // 
            this.btn_filtrado.Location = new System.Drawing.Point(152, 39);
            this.btn_filtrado.Name = "btn_filtrado";
            this.btn_filtrado.Size = new System.Drawing.Size(110, 61);
            this.btn_filtrado.TabIndex = 3;
            this.btn_filtrado.Text = "Listado filtrado";
            this.btn_filtrado.UseVisualStyleBackColor = true;
            this.btn_filtrado.Click += new System.EventHandler(this.btn_filtrado_Click);
            // 
            // btn_completo
            // 
            this.btn_completo.Location = new System.Drawing.Point(2, 39);
            this.btn_completo.Name = "btn_completo";
            this.btn_completo.Size = new System.Drawing.Size(110, 61);
            this.btn_completo.TabIndex = 2;
            this.btn_completo.Text = "Listado completo";
            this.btn_completo.UseVisualStyleBackColor = true;
            this.btn_completo.Click += new System.EventHandler(this.btn_completo_Click);
            // 
            // FrmListadoDeAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 138);
            this.Controls.Add(this.btn_filtrado);
            this.Controls.Add(this.btn_completo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmListadoDeAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de asistencias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_filtrado;
        private System.Windows.Forms.Button btn_completo;



    }
}