namespace Sistema_de_estudiantes.Formularios.Estudiantes
{
    partial class Seleccionar_Materias_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccionar_Materias_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbcredito = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.checkedListMaterias = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDia = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listFecha = new System.Windows.Forms.ListBox();
            this.listBoxMateria = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbcredito);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 120);
            this.panel1.TabIndex = 0;
            // 
            // lbcredito
            // 
            this.lbcredito.AutoSize = true;
            this.lbcredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcredito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcredito.Location = new System.Drawing.Point(95, 80);
            this.lbcredito.Name = "lbcredito";
            this.lbcredito.Size = new System.Drawing.Size(18, 20);
            this.lbcredito.TabIndex = 1;
            this.lbcredito.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Creditos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(374, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Materias";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(12, 491);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(950, 46);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "GUARDAR CAMBIOS";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // checkedListMaterias
            // 
            this.checkedListMaterias.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListMaterias.CheckOnClick = true;
            this.checkedListMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListMaterias.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListMaterias.FormattingEnabled = true;
            this.checkedListMaterias.Location = new System.Drawing.Point(12, 178);
            this.checkedListMaterias.Name = "checkedListMaterias";
            this.checkedListMaterias.Size = new System.Drawing.Size(115, 286);
            this.checkedListMaterias.TabIndex = 15;
            this.checkedListMaterias.SelectedIndexChanged += new System.EventHandler(this.checkedListMaterias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dia";
            // 
            // listBoxDia
            // 
            this.listBoxDia.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.listBoxDia.FormattingEnabled = true;
            this.listBoxDia.ItemHeight = 20;
            this.listBoxDia.Location = new System.Drawing.Point(490, 178);
            this.listBoxDia.Name = "listBoxDia";
            this.listBoxDia.Size = new System.Drawing.Size(195, 280);
            this.listBoxDia.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(806, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha";
            // 
            // listFecha
            // 
            this.listFecha.BackColor = System.Drawing.SystemColors.Control;
            this.listFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.listFecha.FormattingEnabled = true;
            this.listFecha.ItemHeight = 20;
            this.listFecha.Location = new System.Drawing.Point(754, 178);
            this.listFecha.Name = "listFecha";
            this.listFecha.Size = new System.Drawing.Size(191, 280);
            this.listFecha.TabIndex = 17;
            // 
            // listBoxMateria
            // 
            this.listBoxMateria.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.listBoxMateria.FormattingEnabled = true;
            this.listBoxMateria.ItemHeight = 20;
            this.listBoxMateria.Location = new System.Drawing.Point(182, 178);
            this.listBoxMateria.Name = "listBoxMateria";
            this.listBoxMateria.Size = new System.Drawing.Size(277, 280);
            this.listBoxMateria.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Materia";
            // 
            // Seleccionar_Materias_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 550);
            this.Controls.Add(this.listFecha);
            this.Controls.Add(this.listBoxMateria);
            this.Controls.Add(this.listBoxDia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListMaterias);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Seleccionar_Materias_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Materias";
            this.Load += new System.EventHandler(this.Seleccionar_Materias_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckedListBox checkedListMaterias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listFecha;
        private System.Windows.Forms.ListBox listBoxMateria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbcredito;
        private System.Windows.Forms.Label label6;
    }
}