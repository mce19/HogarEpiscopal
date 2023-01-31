namespace CapaPresentaciòn.BtControles
{
    partial class UserNinnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPadresMatricula = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGuardarMatricula = new System.Windows.Forms.Button();
            this.textBoxNombDocente = new System.Windows.Forms.TextBox();
            this.textBoxNumDocente = new System.Windows.Forms.TextBox();
            this.comboBoxGrupos = new System.Windows.Forms.ComboBox();
            this.textBoxNombHijo = new System.Windows.Forms.TextBox();
            this.textBoxNombPadre = new System.Windows.Forms.TextBox();
            this.textBoxNumHijo = new System.Windows.Forms.TextBox();
            this.textBoxNumPadre = new System.Windows.Forms.TextBox();
            this.buttonCargarDatos = new System.Windows.Forms.Button();
            this.buttonMatricular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPadresMatricula)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(624, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matricular";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewPadresMatricula
            // 
            this.dataGridViewPadresMatricula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPadresMatricula.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPadresMatricula.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPadresMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPadresMatricula.Location = new System.Drawing.Point(47, 144);
            this.dataGridViewPadresMatricula.Name = "dataGridViewPadresMatricula";
            this.dataGridViewPadresMatricula.RowTemplate.Height = 25;
            this.dataGridViewPadresMatricula.Size = new System.Drawing.Size(985, 412);
            this.dataGridViewPadresMatricula.TabIndex = 4;
            this.dataGridViewPadresMatricula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPadresMatricula_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonGuardarMatricula);
            this.panel1.Controls.Add(this.textBoxNombDocente);
            this.panel1.Controls.Add(this.textBoxNumDocente);
            this.panel1.Controls.Add(this.comboBoxGrupos);
            this.panel1.Controls.Add(this.textBoxNombHijo);
            this.panel1.Controls.Add(this.textBoxNombPadre);
            this.panel1.Controls.Add(this.textBoxNumHijo);
            this.panel1.Controls.Add(this.textBoxNumPadre);
            this.panel1.Location = new System.Drawing.Point(1065, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 412);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Grupo asigando";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Docente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "N. Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hijo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "N. Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Padre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "N. Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(133, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matricular";
            // 
            // buttonGuardarMatricula
            // 
            this.buttonGuardarMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardarMatricula.Location = new System.Drawing.Point(235, 337);
            this.buttonGuardarMatricula.Name = "buttonGuardarMatricula";
            this.buttonGuardarMatricula.Size = new System.Drawing.Size(136, 44);
            this.buttonGuardarMatricula.TabIndex = 7;
            this.buttonGuardarMatricula.Text = "Guardar";
            this.buttonGuardarMatricula.UseVisualStyleBackColor = true;
            // 
            // textBoxNombDocente
            // 
            this.textBoxNombDocente.Location = new System.Drawing.Point(167, 224);
            this.textBoxNombDocente.Name = "textBoxNombDocente";
            this.textBoxNombDocente.Size = new System.Drawing.Size(204, 23);
            this.textBoxNombDocente.TabIndex = 6;
            this.textBoxNombDocente.TextChanged += new System.EventHandler(this.textBoxNombDocente_TextChanged);
            // 
            // textBoxNumDocente
            // 
            this.textBoxNumDocente.Location = new System.Drawing.Point(17, 224);
            this.textBoxNumDocente.Name = "textBoxNumDocente";
            this.textBoxNumDocente.Size = new System.Drawing.Size(127, 23);
            this.textBoxNumDocente.TabIndex = 5;
            // 
            // comboBoxGrupos
            // 
            this.comboBoxGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrupos.FormattingEnabled = true;
            this.comboBoxGrupos.Location = new System.Drawing.Point(17, 278);
            this.comboBoxGrupos.MaxDropDownItems = 10;
            this.comboBoxGrupos.Name = "comboBoxGrupos";
            this.comboBoxGrupos.Size = new System.Drawing.Size(354, 23);
            this.comboBoxGrupos.TabIndex = 4;
            this.comboBoxGrupos.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupos_SelectedIndexChanged);
            // 
            // textBoxNombHijo
            // 
            this.textBoxNombHijo.Location = new System.Drawing.Point(167, 169);
            this.textBoxNombHijo.Name = "textBoxNombHijo";
            this.textBoxNombHijo.Size = new System.Drawing.Size(204, 23);
            this.textBoxNombHijo.TabIndex = 3;
            // 
            // textBoxNombPadre
            // 
            this.textBoxNombPadre.Location = new System.Drawing.Point(167, 114);
            this.textBoxNombPadre.Name = "textBoxNombPadre";
            this.textBoxNombPadre.Size = new System.Drawing.Size(204, 23);
            this.textBoxNombPadre.TabIndex = 2;
            this.textBoxNombPadre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxNumHijo
            // 
            this.textBoxNumHijo.Location = new System.Drawing.Point(17, 169);
            this.textBoxNumHijo.Name = "textBoxNumHijo";
            this.textBoxNumHijo.Size = new System.Drawing.Size(127, 23);
            this.textBoxNumHijo.TabIndex = 1;
            this.textBoxNumHijo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxNumPadre
            // 
            this.textBoxNumPadre.Location = new System.Drawing.Point(17, 114);
            this.textBoxNumPadre.Name = "textBoxNumPadre";
            this.textBoxNumPadre.Size = new System.Drawing.Size(127, 23);
            this.textBoxNumPadre.TabIndex = 0;
            this.textBoxNumPadre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCargarDatos.Location = new System.Drawing.Point(736, 571);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.Size = new System.Drawing.Size(136, 44);
            this.buttonCargarDatos.TabIndex = 6;
            this.buttonCargarDatos.Text = "Cargar datos";
            this.buttonCargarDatos.UseVisualStyleBackColor = true;
            this.buttonCargarDatos.Click += new System.EventHandler(this.buttonCargarDatos_Click);
            // 
            // buttonMatricular
            // 
            this.buttonMatricular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMatricular.Location = new System.Drawing.Point(896, 571);
            this.buttonMatricular.Name = "buttonMatricular";
            this.buttonMatricular.Size = new System.Drawing.Size(136, 44);
            this.buttonMatricular.TabIndex = 7;
            this.buttonMatricular.Text = "Matricular";
            this.buttonMatricular.UseVisualStyleBackColor = true;
            this.buttonMatricular.Click += new System.EventHandler(this.buttonMatricular_Click);
            // 
            // UserNinnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMatricular);
            this.Controls.Add(this.buttonCargarDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewPadresMatricula);
            this.Controls.Add(this.label1);
            this.Name = "UserNinnos";
            this.Size = new System.Drawing.Size(1491, 646);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPadresMatricula)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPadresMatricula;
        private Panel panel1;
        private Button buttonCargarDatos;
        private ComboBox comboBoxGrupos;
        private TextBox textBoxNombHijo;
        private TextBox textBoxNombPadre;
        private TextBox textBoxNumHijo;
        private TextBox textBoxNumPadre;
        private Label label2;
        private Button buttonGuardarMatricula;
        private TextBox textBoxNombDocente;
        private TextBox textBoxNumDocente;
        private Button buttonMatricular;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
