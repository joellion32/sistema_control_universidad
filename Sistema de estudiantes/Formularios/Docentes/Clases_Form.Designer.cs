namespace Sistema_de_estudiantes.Formularios.Docentes
{
    partial class Clases_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clases_Form));
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxHora = new System.Windows.Forms.DateTimePicker();
            this.tbxFechaT = new System.Windows.Forms.DateTimePicker();
            this.tbxFechaI = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCarrera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDocente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNombreClase = new System.Windows.Forms.Label();
            this.pickFecha_I = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBusqueda.Location = new System.Drawing.Point(483, 46);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(97, 71);
            this.btnBusqueda.TabIndex = 8;
            this.btnBusqueda.Text = "BUSCAR";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(59, 25);
            this.tbxBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(402, 29);
            this.tbxBuscar.TabIndex = 6;
            this.tbxBuscar.Text = "MATERIA";
            this.tbxBuscar.Enter += new System.EventHandler(this.tbxBuscar_Enter);
            this.tbxBuscar.Leave += new System.EventHandler(this.tbxBuscar_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(18, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 324);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrar.Location = new System.Drawing.Point(18, 506);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(541, 38);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar todos los resultados";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(189, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Todas las clases disponibles";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tbxHora);
            this.panel1.Controls.Add(this.tbxFechaT);
            this.panel1.Controls.Add(this.tbxFechaI);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxCarrera);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxDocente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxMateria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbNombreClase);
            this.panel1.Location = new System.Drawing.Point(600, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 570);
            this.panel1.TabIndex = 12;
            // 
            // tbxHora
            // 
            this.tbxHora.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.tbxHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tbxHora.Location = new System.Drawing.Point(135, 359);
            this.tbxHora.Name = "tbxHora";
            this.tbxHora.Size = new System.Drawing.Size(200, 22);
            this.tbxHora.TabIndex = 3;
            // 
            // tbxFechaT
            // 
            this.tbxFechaT.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.tbxFechaT.Checked = false;
            this.tbxFechaT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbxFechaT.Location = new System.Drawing.Point(135, 316);
            this.tbxFechaT.Name = "tbxFechaT";
            this.tbxFechaT.Size = new System.Drawing.Size(200, 22);
            this.tbxFechaT.TabIndex = 3;
            // 
            // tbxFechaI
            // 
            this.tbxFechaI.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.tbxFechaI.Checked = false;
            this.tbxFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbxFechaI.Location = new System.Drawing.Point(135, 276);
            this.tbxFechaI.Name = "tbxFechaI";
            this.tbxFechaI.Size = new System.Drawing.Size(200, 22);
            this.tbxFechaI.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha Termino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha Inicio:";
            // 
            // tbxCarrera
            // 
            this.tbxCarrera.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxCarrera.Location = new System.Drawing.Point(135, 182);
            this.tbxCarrera.Multiline = true;
            this.tbxCarrera.Name = "tbxCarrera";
            this.tbxCarrera.ReadOnly = true;
            this.tbxCarrera.Size = new System.Drawing.Size(200, 22);
            this.tbxCarrera.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Carrera:";
            // 
            // tbxDocente
            // 
            this.tbxDocente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxDocente.Location = new System.Drawing.Point(135, 142);
            this.tbxDocente.Multiline = true;
            this.tbxDocente.Name = "tbxDocente";
            this.tbxDocente.ReadOnly = true;
            this.tbxDocente.Size = new System.Drawing.Size(200, 22);
            this.tbxDocente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Docente:";
            // 
            // tbxMateria
            // 
            this.tbxMateria.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxMateria.Location = new System.Drawing.Point(135, 101);
            this.tbxMateria.Multiline = true;
            this.tbxMateria.Name = "tbxMateria";
            this.tbxMateria.ReadOnly = true;
            this.tbxMateria.Size = new System.Drawing.Size(200, 22);
            this.tbxMateria.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "dia:";
            // 
            // lbNombreClase
            // 
            this.lbNombreClase.AutoSize = true;
            this.lbNombreClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreClase.Location = new System.Drawing.Point(96, 36);
            this.lbNombreClase.Name = "lbNombreClase";
            this.lbNombreClase.Size = new System.Drawing.Size(128, 20);
            this.lbNombreClase.TabIndex = 0;
            this.lbNombreClase.Text = "Nombre Clase";
            // 
            // pickFecha_I
            // 
            this.pickFecha_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.pickFecha_I.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickFecha_I.Location = new System.Drawing.Point(59, 100);
            this.pickFecha_I.Name = "pickFecha_I";
            this.pickFecha_I.Size = new System.Drawing.Size(402, 29);
            this.pickFecha_I.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(56, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha Inicio";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_de_estudiantes.Properties.Resources.calendar__1_;
            this.pictureBox2.Location = new System.Drawing.Point(10, 100);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_estudiantes.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Clases_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(953, 567);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pickFecha_I);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Clases_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clases por Impartir";
            this.Load += new System.EventHandler(this.Clases_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNombreClase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDocente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tbxHora;
        private System.Windows.Forms.DateTimePicker tbxFechaT;
        private System.Windows.Forms.DateTimePicker tbxFechaI;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker pickFecha_I;
        private System.Windows.Forms.Label label8;
    }
}