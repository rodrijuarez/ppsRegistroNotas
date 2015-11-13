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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTurnos = new System.Windows.Forms.TextBox();
            this.txtDiaDictado = new System.Windows.Forms.TextBox();
            this.txtDivisión = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "\"Nombre de la Materia\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dia dictado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "División:";
            // 
            // txtTurnos
            // 
            this.txtTurnos.Location = new System.Drawing.Point(98, 56);
            this.txtTurnos.Name = "txtTurnos";
            this.txtTurnos.Size = new System.Drawing.Size(121, 20);
            this.txtTurnos.TabIndex = 7;
          //  this.txtTurnos.TextChanged += new System.EventHandler(this.txtTurnos_keypress);
           // this.txtTurnos.TextChanged += new System.EventHandler(this.txtTurnos_keypress);
            //this.txtTurnos.TextChanged += new System.EventHandler(this.txtTurnos_keypress);
            // 
            // txtDiaDictado
            // 
            this.txtDiaDictado.Location = new System.Drawing.Point(98, 94);
            this.txtDiaDictado.Name = "txtDiaDictado";
            this.txtDiaDictado.Size = new System.Drawing.Size(121, 2-0);
            this.txtDiaDictado.TabIndex = 8;
            // 
            // txtDivisión
            // 
            this.txtDivisión.Location = new System.Drawing.Point(98, 133);
            this.txtDivisión.Name = "txtDivisión";
            this.txtDivisión.Size = new System.Drawing.Size(121, 20);
            this.txtDivisión.TabIndex = 9;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(98, 172);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(121, 20);
            this.txtDuracion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 175);
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
            this.Controls.Add(this.txtDuracion);
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
            this.Name = "FrmValidacionMaterias";
            this.Text = "FrmValidacionMaterias";
            this.Load += new System.EventHandler(this.FrmValidacionMaterias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTurnos;
        private System.Windows.Forms.TextBox txtDiaDictado;
        private System.Windows.Forms.TextBox txtDivisión;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label5;
    }
}