﻿
namespace CapaVista.Directivo
{
    partial class FrmDirectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDirectivo));
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnGrilla = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnPreceptores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDirectivo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMatricula.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMatricula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMatricula.Location = new System.Drawing.Point(13, 130);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(109, 81);
            this.btnMatricula.TabIndex = 12;
            this.btnMatricula.Text = "Matrícula";
            this.btnMatricula.UseVisualStyleBackColor = false;
            this.btnMatricula.Click += new System.EventHandler(this.BtnCalificaciones_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEstudiantes.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEstudiantes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstudiantes.Location = new System.Drawing.Point(13, 391);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(109, 81);
            this.btnEstudiantes.TabIndex = 10;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.BtnEstudiantes_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAsistencia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAsistencia.Location = new System.Drawing.Point(13, 217);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(109, 81);
            this.btnAsistencia.TabIndex = 9;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            // 
            // btnGrilla
            // 
            this.btnGrilla.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGrilla.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnGrilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGrilla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGrilla.Location = new System.Drawing.Point(13, 652);
            this.btnGrilla.Name = "btnGrilla";
            this.btnGrilla.Size = new System.Drawing.Size(109, 81);
            this.btnGrilla.TabIndex = 14;
            this.btnGrilla.Text = "Grilla Semanal";
            this.btnGrilla.UseVisualStyleBackColor = false;
            this.btnGrilla.Click += new System.EventHandler(this.BtnGrilla_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.btnMatricula);
            this.flowLayoutPanel1.Controls.Add(this.btnAsistencia);
            this.flowLayoutPanel1.Controls.Add(this.btnCalificaciones);
            this.flowLayoutPanel1.Controls.Add(this.btnEstudiantes);
            this.flowLayoutPanel1.Controls.Add(this.btnDocentes);
            this.flowLayoutPanel1.Controls.Add(this.btnPreceptores);
            this.flowLayoutPanel1.Controls.Add(this.btnGrilla);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 828);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 114;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 113;
            this.label1.Text = "INSTITUTO ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalificaciones.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalificaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalificaciones.Location = new System.Drawing.Point(13, 304);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(109, 81);
            this.btnCalificaciones.TabIndex = 111;
            this.btnCalificaciones.Text = "Calificaciones";
            this.btnCalificaciones.UseVisualStyleBackColor = false;
            // 
            // btnDocentes
            // 
            this.btnDocentes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDocentes.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDocentes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDocentes.Location = new System.Drawing.Point(13, 478);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(109, 81);
            this.btnDocentes.TabIndex = 109;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = false;
            this.btnDocentes.Click += new System.EventHandler(this.BtnDocentes_Click);
            // 
            // btnPreceptores
            // 
            this.btnPreceptores.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPreceptores.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnPreceptores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPreceptores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreceptores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPreceptores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPreceptores.Location = new System.Drawing.Point(13, 565);
            this.btnPreceptores.Name = "btnPreceptores";
            this.btnPreceptores.Size = new System.Drawing.Size(109, 81);
            this.btnPreceptores.TabIndex = 110;
            this.btnPreceptores.Text = "Preceptores";
            this.btnPreceptores.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblUsuarioLogueado);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(130, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 54);
            this.panel1.TabIndex = 19;
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogueado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(928, 5);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(193, 20);
            this.lblUsuarioLogueado.TabIndex = 21;
            this.lblUsuarioLogueado.Text = "NombrePersonaLogueada";
            this.lblUsuarioLogueado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLogout.Location = new System.Drawing.Point(1015, 19);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 29);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1130, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1287, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 774);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(130, 813);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1157, 15);
            this.panel3.TabIndex = 20;
            // 
            // panelDirectivo
            // 
            this.panelDirectivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDirectivo.BackColor = System.Drawing.Color.Indigo;
            this.panelDirectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDirectivo.Location = new System.Drawing.Point(130, 54);
            this.panelDirectivo.Name = "panelDirectivo";
            this.panelDirectivo.Size = new System.Drawing.Size(1157, 759);
            this.panelDirectivo.TabIndex = 21;
            // 
            // frmDirectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1302, 828);
            this.Controls.Add(this.panelDirectivo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmDirectivo";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnGrilla;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDirectivo;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnPreceptores;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}