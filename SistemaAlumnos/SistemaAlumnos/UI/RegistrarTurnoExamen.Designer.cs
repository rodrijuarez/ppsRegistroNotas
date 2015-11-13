namespace UTN.SistemaAlumnos.UI
{
    partial class RegistrarTurnoExamen
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
            this.gbxContenedor = new System.Windows.Forms.GroupBox();
            this.dtpSegllamado = new System.Windows.Forms.DateTimePicker();
            this.dtpPriLlamado = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbMañana = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMatria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxContenedor
            // 
            this.gbxContenedor.Controls.Add(this.dtpSegllamado);
            this.gbxContenedor.Controls.Add(this.dtpPriLlamado);
            this.gbxContenedor.Controls.Add(this.btnLimpiar);
            this.gbxContenedor.Controls.Add(this.btnAceptar);
            this.gbxContenedor.Controls.Add(this.btnCancel);
            this.gbxContenedor.Controls.Add(this.label5);
            this.gbxContenedor.Controls.Add(this.label4);
            this.gbxContenedor.Controls.Add(this.rdbTarde);
            this.gbxContenedor.Controls.Add(this.rdbMañana);
            this.gbxContenedor.Controls.Add(this.label3);
            this.gbxContenedor.Controls.Add(this.cmbMatria);
            this.gbxContenedor.Controls.Add(this.label2);
            this.gbxContenedor.Controls.Add(this.cmbCarrera);
            this.gbxContenedor.Controls.Add(this.label1);
            this.gbxContenedor.Location = new System.Drawing.Point(12, 12);
            this.gbxContenedor.Name = "gbxContenedor";
            this.gbxContenedor.Size = new System.Drawing.Size(300, 317);
            this.gbxContenedor.TabIndex = 0;
            this.gbxContenedor.TabStop = false;
            this.gbxContenedor.Text = "Consulta";
            // 
            // dtpSegllamado
            // 
            this.dtpSegllamado.Location = new System.Drawing.Point(130, 218);
            this.dtpSegllamado.Name = "dtpSegllamado";
            this.dtpSegllamado.Size = new System.Drawing.Size(144, 20);
            this.dtpSegllamado.TabIndex = 15;
            // 
            // dtpPriLlamado
            // 
            this.dtpPriLlamado.Location = new System.Drawing.Point(130, 186);
            this.dtpPriLlamado.Name = "dtpPriLlamado";
            this.dtpPriLlamado.Size = new System.Drawing.Size(144, 20);
            this.dtpPriLlamado.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(111, 282);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 29);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(11, 282);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 29);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(202, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Segundo llamado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Primer llamado:";
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(34, 156);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(53, 17);
            this.rdbTarde.TabIndex = 6;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbMañana
            // 
            this.rdbMañana.AutoSize = true;
            this.rdbMañana.Location = new System.Drawing.Point(34, 133);
            this.rdbMañana.Name = "rdbMañana";
            this.rdbMañana.Size = new System.Drawing.Size(64, 17);
            this.rdbMañana.TabIndex = 5;
            this.rdbMañana.TabStop = true;
            this.rdbMañana.Text = "Mañana";
            this.rdbMañana.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno:";
            // 
            // cmbMatria
            // 
            this.cmbMatria.FormattingEnabled = true;
            this.cmbMatria.Location = new System.Drawing.Point(28, 93);
            this.cmbMatria.Name = "cmbMatria";
            this.cmbMatria.Size = new System.Drawing.Size(196, 21);
            this.cmbMatria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materia:";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(28, 53);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(196, 21);
            this.cmbCarrera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera:";
            // 
            // RegistrarTurnoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 341);
            this.Controls.Add(this.gbxContenedor);
            this.Name = "RegistrarTurnoExamen";
            this.Text = "RegistrarTurnoExamen";
            this.Load += new System.EventHandler(this.RegistrarTurnoExamen_Load);
            this.gbxContenedor.ResumeLayout(false);
            this.gbxContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxContenedor;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPriLlamado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbMañana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMatria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSegllamado;
    }
}