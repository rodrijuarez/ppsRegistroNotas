namespace UTN.SistemaAlumnos.UI
{
    partial class FrmValidacionMaterias
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
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTurnos = new System.Windows.Forms.TextBox();
            this.txtDiaDictado = new System.Windows.Forms.TextBox();
            this.txtDivisión = new System.Windows.Forms.TextBox();
            this.txtDuración = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(100, 33);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(121, 21);
            this.cboMaterias.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(31, 227);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(138, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dia dictado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "División:";
            // 
            // txtTurnos
            // 
            this.txtTurnos.Location = new System.Drawing.Point(100, 71);
            this.txtTurnos.Name = "txtTurnos";
            this.txtTurnos.Size = new System.Drawing.Size(121, 20);
            this.txtTurnos.TabIndex = 7;
            this.txtTurnos.TextChanged += new System.EventHandler(this.txtTurnos_TextChanged);
            // 
            // txtDiaDictado
            // 
            this.txtDiaDictado.Location = new System.Drawing.Point(100, 106);
            this.txtDiaDictado.Name = "txtDiaDictado";
            this.txtDiaDictado.Size = new System.Drawing.Size(121, 20);
            this.txtDiaDictado.TabIndex = 8;
            this.txtDiaDictado.TextChanged += new System.EventHandler(this.txtDiaDictado_TextChanged);
            // 
            // txtDivisión
            // 
            this.txtDivisión.Location = new System.Drawing.Point(100, 144);
            this.txtDivisión.Name = "txtDivisión";
            this.txtDivisión.Size = new System.Drawing.Size(121, 20);
            this.txtDivisión.TabIndex = 9;
            this.txtDivisión.TextChanged += new System.EventHandler(this.txtDivisión_TextChanged);
            // 
            // txtDuración
            // 
            this.txtDuración.Location = new System.Drawing.Point(100, 180);
            this.txtDuración.Name = "txtDuración";
            this.txtDuración.Size = new System.Drawing.Size(121, 20);
            this.txtDuración.TabIndex = 11;
            this.txtDuración.TextChanged += new System.EventHandler(this.txtDuración_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Duración:";
            // 
            // FrmValidacionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 262);
            this.Controls.Add(this.txtDuración);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDivisión);
            this.Controls.Add(this.txtDiaDictado);
            this.Controls.Add(this.txtTurnos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboMaterias);
            this.Name = "FrmValidacionMaterias";
            this.Text = "FrmValidacionMaterias";
            this.Load += new System.EventHandler(this.FrmValidacionMaterias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTurnos;
        private System.Windows.Forms.TextBox txtDiaDictado;
        private System.Windows.Forms.TextBox txtDivisión;
        private System.Windows.Forms.TextBox txtDuración;
        private System.Windows.Forms.Label label5;
    }
}