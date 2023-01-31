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
            this.buttonCargarDatos = new System.Windows.Forms.Button();
            this.textBoxNumPadre = new System.Windows.Forms.TextBox();
            this.textBoxNumHijo = new System.Windows.Forms.TextBox();
            this.textBoxNombPadre = new System.Windows.Forms.TextBox();
            this.textBoxNombHijo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxNumDocente = new System.Windows.Forms.TextBox();
            this.textBoxNombDocente = new System.Windows.Forms.TextBox();
            this.buttonGuardarMatricula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPadresMatricula)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(650, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "niños";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewPadresMatricula
            // 
            this.dataGridViewPadresMatricula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPadresMatricula.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPadresMatricula.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPadresMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPadresMatricula.Location = new System.Drawing.Point(60, 185);
            this.dataGridViewPadresMatricula.Name = "dataGridViewPadresMatricula";
            this.dataGridViewPadresMatricula.RowTemplate.Height = 25;
            this.dataGridViewPadresMatricula.Size = new System.Drawing.Size(985, 412);
            this.dataGridViewPadresMatricula.TabIndex = 4;
            this.dataGridViewPadresMatricula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPadresMatricula_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonGuardarMatricula);
            this.panel1.Controls.Add(this.textBoxNombDocente);
            this.panel1.Controls.Add(this.textBoxNumDocente);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBoxNombHijo);
            this.panel1.Controls.Add(this.textBoxNombPadre);
            this.panel1.Controls.Add(this.textBoxNumHijo);
            this.panel1.Controls.Add(this.textBoxNumPadre);
            this.panel1.Location = new System.Drawing.Point(1078, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 412);
            this.panel1.TabIndex = 5;
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCargarDatos.Location = new System.Drawing.Point(60, 126);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.Size = new System.Drawing.Size(136, 44);
            this.buttonCargarDatos.TabIndex = 6;
            this.buttonCargarDatos.Text = "Cargar datos";
            this.buttonCargarDatos.UseVisualStyleBackColor = true;
            this.buttonCargarDatos.Click += new System.EventHandler(this.buttonCargarDatos_Click);
            // 
            // textBoxNumPadre
            // 
            this.textBoxNumPadre.Location = new System.Drawing.Point(17, 114);
            this.textBoxNumPadre.Name = "textBoxNumPadre";
            this.textBoxNumPadre.Size = new System.Drawing.Size(127, 23);
            this.textBoxNumPadre.TabIndex = 0;
            this.textBoxNumPadre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNumHijo
            // 
            this.textBoxNumHijo.Location = new System.Drawing.Point(17, 169);
            this.textBoxNumHijo.Name = "textBoxNumHijo";
            this.textBoxNumHijo.Size = new System.Drawing.Size(127, 23);
            this.textBoxNumHijo.TabIndex = 1;
            this.textBoxNumHijo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxNombPadre
            // 
            this.textBoxNombPadre.Location = new System.Drawing.Point(167, 114);
            this.textBoxNombPadre.Name = "textBoxNombPadre";
            this.textBoxNombPadre.Size = new System.Drawing.Size(204, 23);
            this.textBoxNombPadre.TabIndex = 2;
            this.textBoxNombPadre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxNombHijo
            // 
            this.textBoxNombHijo.Location = new System.Drawing.Point(167, 169);
            this.textBoxNombHijo.Name = "textBoxNombHijo";
            this.textBoxNombHijo.Size = new System.Drawing.Size(204, 23);
            this.textBoxNombHijo.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(354, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // textBoxNumDocente
            // 
            this.textBoxNumDocente.Location = new System.Drawing.Point(17, 224);
            this.textBoxNumDocente.Name = "textBoxNumDocente";
            this.textBoxNumDocente.Size = new System.Drawing.Size(127, 23);
            this.textBoxNumDocente.TabIndex = 5;
            // 
            // textBoxNombDocente
            // 
            this.textBoxNombDocente.Location = new System.Drawing.Point(167, 224);
            this.textBoxNombDocente.Name = "textBoxNombDocente";
            this.textBoxNombDocente.Size = new System.Drawing.Size(204, 23);
            this.textBoxNombDocente.TabIndex = 6;
            // 
            // buttonGuardarMatricula
            // 
            this.buttonGuardarMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardarMatricula.Location = new System.Drawing.Point(268, 351);
            this.buttonGuardarMatricula.Name = "buttonGuardarMatricula";
            this.buttonGuardarMatricula.Size = new System.Drawing.Size(103, 36);
            this.buttonGuardarMatricula.TabIndex = 7;
            this.buttonGuardarMatricula.Text = "Guardar";
            this.buttonGuardarMatricula.UseVisualStyleBackColor = true;
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
            // UserNinnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private ComboBox comboBox1;
        private TextBox textBoxNombHijo;
        private TextBox textBoxNombPadre;
        private TextBox textBoxNumHijo;
        private TextBox textBoxNumPadre;
        private Label label2;
        private Button buttonGuardarMatricula;
        private TextBox textBoxNombDocente;
        private TextBox textBoxNumDocente;
    }
}
