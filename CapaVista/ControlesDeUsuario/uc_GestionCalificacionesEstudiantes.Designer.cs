
namespace CapaVista.ControlesdeUsuario
{
    partial class uc_GestionCalificacionesEstudiantes
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
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.btnVerCalificaciones = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpCalificaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.flpCalificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvCalificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvCalificaciones.Location = new System.Drawing.Point(233, 0);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.Size = new System.Drawing.Size(924, 759);
            this.dgvCalificaciones.TabIndex = 86;
            // 
            // btnVerCalificaciones
            // 
            this.btnVerCalificaciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerCalificaciones.BackColor = System.Drawing.Color.Navy;
            this.btnVerCalificaciones.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnVerCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCalificaciones.ForeColor = System.Drawing.Color.Aqua;
            this.btnVerCalificaciones.Location = new System.Drawing.Point(6, 368);
            this.btnVerCalificaciones.Name = "btnVerCalificaciones";
            this.btnVerCalificaciones.Size = new System.Drawing.Size(221, 45);
            this.btnVerCalificaciones.TabIndex = 47;
            this.btnVerCalificaciones.Text = "Ver Calificaciones";
            this.btnVerCalificaciones.UseVisualStyleBackColor = false;
            // 
            // btnCalificar
            // 
            this.btnCalificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalificar.BackColor = System.Drawing.Color.Navy;
            this.btnCalificar.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnCalificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificar.ForeColor = System.Drawing.Color.Aqua;
            this.btnCalificar.Location = new System.Drawing.Point(6, 317);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(221, 45);
            this.btnCalificar.TabIndex = 46;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "CALIFICACIONES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Período Vigente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpCalificaciones
            // 
            this.flpCalificaciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCalificaciones.BackColor = System.Drawing.Color.Indigo;
            this.flpCalificaciones.Controls.Add(this.label3);
            this.flpCalificaciones.Controls.Add(this.label1);
            this.flpCalificaciones.Controls.Add(this.label2);
            this.flpCalificaciones.Controls.Add(this.label8);
            this.flpCalificaciones.Controls.Add(this.cmbCarrera);
            this.flpCalificaciones.Controls.Add(this.label7);
            this.flpCalificaciones.Controls.Add(this.cmbNivel);
            this.flpCalificaciones.Controls.Add(this.label5);
            this.flpCalificaciones.Controls.Add(this.cmbMateria);
            this.flpCalificaciones.Controls.Add(this.label6);
            this.flpCalificaciones.Controls.Add(this.cmbCurso);
            this.flpCalificaciones.Controls.Add(this.btnCalificar);
            this.flpCalificaciones.Controls.Add(this.btnVerCalificaciones);
            this.flpCalificaciones.Controls.Add(this.btnCerrar);
            this.flpCalificaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpCalificaciones.Location = new System.Drawing.Point(0, 0);
            this.flpCalificaciones.Name = "flpCalificaciones";
            this.flpCalificaciones.Padding = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.flpCalificaciones.Size = new System.Drawing.Size(234, 759);
            this.flpCalificaciones.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Ciclo Lectivo Actual";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 20);
            this.label8.TabIndex = 103;
            this.label8.Text = "Carrera";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(6, 131);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(221, 21);
            this.cmbCarrera.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "Nivel";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(6, 184);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(221, 21);
            this.cmbNivel.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Materia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(6, 237);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(221, 21);
            this.cmbMateria.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 20);
            this.label6.TabIndex = 99;
            this.label6.Text = "Curso";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(6, 290);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(221, 21);
            this.cmbCurso.TabIndex = 100;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrar.BackColor = System.Drawing.Color.Navy;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Aqua;
            this.btnCerrar.Location = new System.Drawing.Point(6, 419);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(221, 45);
            this.btnCerrar.TabIndex = 97;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // uc_GestionCalificacionesEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dgvCalificaciones);
            this.Controls.Add(this.flpCalificaciones);
            this.Name = "uc_GestionCalificacionesEstudiantes";
            this.Size = new System.Drawing.Size(1157, 759);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.flpCalificaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.Button btnVerCalificaciones;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpCalificaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Button btnCerrar;
    }
}
