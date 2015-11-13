namespace UI
{
    partial class Main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaActasExámenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosAcademicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosDeExamenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoDeCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlarInscripcionesDeLosAlumnosParaCursarMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAsistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 325);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(608, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaActasExámenToolStripMenuItem,
            this.datosAcademicosToolStripMenuItem,
            this.cargarTurnosToolStripMenuItem,
            this.turnosDeExamenesToolStripMenuItem,
            this.pagoDeCuotaToolStripMenuItem,
            this.registrarProfesorToolStripMenuItem,
            this.consultaAlumnosToolStripMenuItem,
            this.registroNotasToolStripMenuItem,
            this.controlarInscripcionesDeLosAlumnosParaCursarMateriasToolStripMenuItem,
            this.listadoDeAsistenciasToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem.Text = "&Gestión";
            // 
            // consultaActasExámenToolStripMenuItem
            // 
            this.consultaActasExámenToolStripMenuItem.Name = "consultaActasExámenToolStripMenuItem";
            this.consultaActasExámenToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.consultaActasExámenToolStripMenuItem.Text = "Consulta actas exámen";
            this.consultaActasExámenToolStripMenuItem.Click += new System.EventHandler(this.consultaActasExámenToolStripMenuItem_Click);
            // 
            // datosAcademicosToolStripMenuItem
            // 
            this.datosAcademicosToolStripMenuItem.Name = "datosAcademicosToolStripMenuItem";
            this.datosAcademicosToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.datosAcademicosToolStripMenuItem.Text = "Datos Academicos";
            this.datosAcademicosToolStripMenuItem.Click += new System.EventHandler(this.datosAcademicosToolStripMenuItem_Click);
            // 
            // cargarTurnosToolStripMenuItem
            // 
            this.cargarTurnosToolStripMenuItem.Name = "cargarTurnosToolStripMenuItem";
            this.cargarTurnosToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.cargarTurnosToolStripMenuItem.Text = "Cargar Turnos";
            this.cargarTurnosToolStripMenuItem.Click += new System.EventHandler(this.cargarTurnosToolStripMenuItem_Click);
            // 
            // turnosDeExamenesToolStripMenuItem
            // 
            this.turnosDeExamenesToolStripMenuItem.Name = "turnosDeExamenesToolStripMenuItem";
            this.turnosDeExamenesToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.turnosDeExamenesToolStripMenuItem.Text = "Turnos de examenes";
            this.turnosDeExamenesToolStripMenuItem.Click += new System.EventHandler(this.turnosDeExamenesToolStripMenuItem_Click);
            // 
            // pagoDeCuotaToolStripMenuItem
            // 
            this.pagoDeCuotaToolStripMenuItem.Name = "pagoDeCuotaToolStripMenuItem";
            this.pagoDeCuotaToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.pagoDeCuotaToolStripMenuItem.Text = "&Pago de cuota";
            this.pagoDeCuotaToolStripMenuItem.Click += new System.EventHandler(this.pagoDeCuotaToolStripMenuItem_Click);
            // 
            // registrarProfesorToolStripMenuItem
            // 
            this.registrarProfesorToolStripMenuItem.Name = "registrarProfesorToolStripMenuItem";
            this.registrarProfesorToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.registrarProfesorToolStripMenuItem.Text = "Registrar  Profesor";
            this.registrarProfesorToolStripMenuItem.Click += new System.EventHandler(this.registrarProfesorToolStripMenuItem_Click);
            // 
            // consultaAlumnosToolStripMenuItem
            // 
            this.consultaAlumnosToolStripMenuItem.Name = "consultaAlumnosToolStripMenuItem";
            this.consultaAlumnosToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.consultaAlumnosToolStripMenuItem.Text = "Consulta Alumnos";
            this.consultaAlumnosToolStripMenuItem.Click += new System.EventHandler(this.consultaAlumnosToolStripMenuItem_Click_1);
            // 
            // registroNotasToolStripMenuItem
            // 
            this.registroNotasToolStripMenuItem.Name = "registroNotasToolStripMenuItem";
            this.registroNotasToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.registroNotasToolStripMenuItem.Text = "Registro Notas";
            this.registroNotasToolStripMenuItem.Click += new System.EventHandler(this.registroNotasToolStripMenuItem_Click);
            // 
            // controlarInscripcionesDeLosAlumnosParaCursarMateriasToolStripMenuItem
            // 
            this.controlarInscripcionesDeLosAlumnosParaCursarMateriasToolStripMenuItem.Name = "controlarInscripcionesDeLosAlumnosParaCursarMateriasToolStripMenuItem";
            this.controlarInscripcionesDeLosAlumnosParaCursarMateriasToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.controlarInscripcionesDeLosAlumnosParaCursarMateriasToolStripMenuItem.Text = "Controlar correlatividades para examen";
            // 
            // listadoDeAsistenciasToolStripMenuItem
            // 
            this.listadoDeAsistenciasToolStripMenuItem.Name = "listadoDeAsistenciasToolStripMenuItem";
            this.listadoDeAsistenciasToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.listadoDeAsistenciasToolStripMenuItem.Text = "Listado de asistencias";
            this.listadoDeAsistenciasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeAsistenciasToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 347);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Sistema de Alumnos";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosDeExamenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoDeCuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaActasExámenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosAcademicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeCorrelativasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlarInscripcionesDeLosAlumnosParaCursarMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAsistenciasToolStripMenuItem;
    }
}

