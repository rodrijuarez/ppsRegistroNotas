namespace UTN.SistemaAlumnos.UI
{
    partial class frmBusquedaPagoCuotas
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
            this.dvgBusqueda = new System.Windows.Forms.DataGridView();
            this.btnAceptarBusqueda = new System.Windows.Forms.Button();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgBusqueda
            // 
            this.dvgBusqueda.AllowUserToAddRows = false;
            this.dvgBusqueda.AllowUserToDeleteRows = false;
            this.dvgBusqueda.AllowUserToResizeRows = false;
            this.dvgBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.Nombre,
            this.Apellido});
            this.dvgBusqueda.Location = new System.Drawing.Point(12, 12);
            this.dvgBusqueda.MultiSelect = false;
            this.dvgBusqueda.Name = "dvgBusqueda";
            this.dvgBusqueda.ReadOnly = true;
            this.dvgBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgBusqueda.Size = new System.Drawing.Size(241, 229);
            this.dvgBusqueda.TabIndex = 0;
            // 
            // btnAceptarBusqueda
            // 
            this.btnAceptarBusqueda.Location = new System.Drawing.Point(107, 264);
            this.btnAceptarBusqueda.Name = "btnAceptarBusqueda";
            this.btnAceptarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarBusqueda.TabIndex = 1;
            this.btnAceptarBusqueda.Text = "Aceptar";
            this.btnAceptarBusqueda.UseVisualStyleBackColor = true;
            this.btnAceptarBusqueda.Click += new System.EventHandler(this.btnAceptarBusqueda_Click);
            // 
            // legajo
            // 
            this.legajo.HeaderText = "legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // frmBusquedaPagoCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 300);
            this.Controls.Add(this.btnAceptarBusqueda);
            this.Controls.Add(this.dvgBusqueda);
            this.Name = "frmBusquedaPagoCuotas";
            this.Text = "BusquedaPagoCuotas";
            this.Load += new System.EventHandler(this.frmBusquedaPagoCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgBusqueda;
        private System.Windows.Forms.Button btnAceptarBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}