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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewPadresMatricula = new DataGridView();
            panel1 = new Panel();
            textBoxIdMatricula = new TextBox();
            label13 = new Label();
            label12 = new Label();
            textBoxGrupos = new TextBox();
            textBoxIdGrupo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonGuardarMatricula = new Button();
            textBoxNombDocente = new TextBox();
            textBoxNumDocente = new TextBox();
            textBoxNombHijo = new TextBox();
            textBoxNombPadre = new TextBox();
            textBoxNumHijo = new TextBox();
            textBoxNumPadre = new TextBox();
            buttonCargarDatos = new Button();
            buttonMatricular = new Button();
            dataGridViewGrupos = new DataGridView();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPadresMatricula).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(624, 32);
            label1.Name = "label1";
            label1.Size = new Size(259, 56);
            label1.TabIndex = 3;
            label1.Text = "Matricular";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // dataGridViewPadresMatricula
            // 
            dataGridViewPadresMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPadresMatricula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPadresMatricula.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPadresMatricula.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPadresMatricula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPadresMatricula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPadresMatricula.Location = new Point(47, 120);
            dataGridViewPadresMatricula.Name = "dataGridViewPadresMatricula";
            dataGridViewPadresMatricula.RowTemplate.Height = 25;
            dataGridViewPadresMatricula.Size = new Size(985, 203);
            dataGridViewPadresMatricula.TabIndex = 4;
            dataGridViewPadresMatricula.CellContentClick += dataGridViewPadresMatricula_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(textBoxIdMatricula);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBoxGrupos);
            panel1.Controls.Add(textBoxIdGrupo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonGuardarMatricula);
            panel1.Controls.Add(textBoxNombDocente);
            panel1.Controls.Add(textBoxNumDocente);
            panel1.Controls.Add(textBoxNombHijo);
            panel1.Controls.Add(textBoxNombPadre);
            panel1.Controls.Add(textBoxNumHijo);
            panel1.Controls.Add(textBoxNumPadre);
            panel1.Location = new Point(1065, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 445);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // textBoxIdMatricula
            // 
            textBoxIdMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxIdMatricula.Location = new Point(24, 89);
            textBoxIdMatricula.Name = "textBoxIdMatricula";
            textBoxIdMatricula.Size = new Size(127, 23);
            textBoxIdMatricula.TabIndex = 20;
            textBoxIdMatricula.TextChanged += textBoxIdMatricula_TextChanged;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(24, 71);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 19;
            label13.Text = "Codigo";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(174, 324);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 18;
            label12.Text = "Grupo";
            // 
            // textBoxGrupos
            // 
            textBoxGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxGrupos.Location = new Point(174, 342);
            textBoxGrupos.Name = "textBoxGrupos";
            textBoxGrupos.Size = new Size(204, 23);
            textBoxGrupos.TabIndex = 17;
            textBoxGrupos.TextChanged += textBoxGrupos_TextChanged;
            // 
            // textBoxIdGrupo
            // 
            textBoxIdGrupo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxIdGrupo.Location = new Point(24, 342);
            textBoxIdGrupo.Name = "textBoxIdGrupo";
            textBoxIdGrupo.Size = new Size(127, 23);
            textBoxIdGrupo.TabIndex = 16;
            textBoxIdGrupo.TextChanged += textBoxIdGrupo_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(24, 324);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 15;
            label9.Text = "ID Grupos";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(174, 257);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 14;
            label8.Text = "Docente";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(24, 257);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 13;
            label7.Text = "N. Documento";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(174, 195);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 12;
            label6.Text = "Hijo";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(24, 195);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 11;
            label5.Text = "N. Documento";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(174, 129);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 10;
            label4.Text = "Padre";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(24, 129);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 9;
            label3.Text = "N. Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(142, 23);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 8;
            label2.Text = "Matricular";
            // 
            // buttonGuardarMatricula
            // 
            buttonGuardarMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGuardarMatricula.BackColor = SystemColors.ActiveCaptionText;
            buttonGuardarMatricula.FlatStyle = FlatStyle.Popup;
            buttonGuardarMatricula.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardarMatricula.ForeColor = SystemColors.ControlLightLight;
            buttonGuardarMatricula.Location = new Point(242, 389);
            buttonGuardarMatricula.Name = "buttonGuardarMatricula";
            buttonGuardarMatricula.Size = new Size(136, 44);
            buttonGuardarMatricula.TabIndex = 7;
            buttonGuardarMatricula.Text = "Guardar";
            buttonGuardarMatricula.UseVisualStyleBackColor = false;
            buttonGuardarMatricula.Click += buttonGuardarMatricula_Click;
            // 
            // textBoxNombDocente
            // 
            textBoxNombDocente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNombDocente.Location = new Point(174, 275);
            textBoxNombDocente.Name = "textBoxNombDocente";
            textBoxNombDocente.Size = new Size(204, 23);
            textBoxNombDocente.TabIndex = 6;
            textBoxNombDocente.TextChanged += textBoxNombDocente_TextChanged;
            // 
            // textBoxNumDocente
            // 
            textBoxNumDocente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNumDocente.Location = new Point(24, 275);
            textBoxNumDocente.Name = "textBoxNumDocente";
            textBoxNumDocente.Size = new Size(127, 23);
            textBoxNumDocente.TabIndex = 5;
            // 
            // textBoxNombHijo
            // 
            textBoxNombHijo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNombHijo.Location = new Point(174, 213);
            textBoxNombHijo.Name = "textBoxNombHijo";
            textBoxNombHijo.Size = new Size(204, 23);
            textBoxNombHijo.TabIndex = 3;
            // 
            // textBoxNombPadre
            // 
            textBoxNombPadre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNombPadre.Location = new Point(174, 147);
            textBoxNombPadre.Name = "textBoxNombPadre";
            textBoxNombPadre.Size = new Size(204, 23);
            textBoxNombPadre.TabIndex = 2;
            textBoxNombPadre.TextChanged += textBox3_TextChanged;
            // 
            // textBoxNumHijo
            // 
            textBoxNumHijo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNumHijo.Location = new Point(24, 213);
            textBoxNumHijo.Name = "textBoxNumHijo";
            textBoxNumHijo.Size = new Size(127, 23);
            textBoxNumHijo.TabIndex = 1;
            textBoxNumHijo.TextChanged += textBox2_TextChanged;
            // 
            // textBoxNumPadre
            // 
            textBoxNumPadre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNumPadre.Location = new Point(24, 147);
            textBoxNumPadre.Name = "textBoxNumPadre";
            textBoxNumPadre.Size = new Size(127, 23);
            textBoxNumPadre.TabIndex = 0;
            textBoxNumPadre.TextChanged += textBox1_TextChanged;
            // 
            // buttonCargarDatos
            // 
            buttonCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCargarDatos.BackColor = Color.Lime;
            buttonCargarDatos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCargarDatos.Location = new Point(744, 584);
            buttonCargarDatos.Name = "buttonCargarDatos";
            buttonCargarDatos.Size = new Size(136, 44);
            buttonCargarDatos.TabIndex = 6;
            buttonCargarDatos.Text = "Cargar datos";
            buttonCargarDatos.UseVisualStyleBackColor = false;
            buttonCargarDatos.Click += buttonCargarDatos_Click;
            // 
            // buttonMatricular
            // 
            buttonMatricular.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMatricular.BackColor = Color.FromArgb(255, 128, 0);
            buttonMatricular.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMatricular.Location = new Point(896, 584);
            buttonMatricular.Name = "buttonMatricular";
            buttonMatricular.Size = new Size(136, 44);
            buttonMatricular.TabIndex = 7;
            buttonMatricular.Text = "Asignar";
            buttonMatricular.UseVisualStyleBackColor = false;
            buttonMatricular.Click += buttonMatricular_Click;
            // 
            // dataGridViewGrupos
            // 
            dataGridViewGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGrupos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewGrupos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.Location = new Point(47, 362);
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.RowTemplate.Height = 25;
            dataGridViewGrupos.Size = new Size(985, 203);
            dataGridViewGrupos.TabIndex = 8;
            dataGridViewGrupos.CellContentClick += dataGridViewGrupos_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(47, 336);
            label10.Name = "label10";
            label10.Size = new Size(96, 23);
            label10.TabIndex = 9;
            label10.Text = "Docentes";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(47, 94);
            label11.Name = "label11";
            label11.Size = new Size(73, 23);
            label11.TabIndex = 10;
            label11.Text = "Padres";
            // 
            // UserNinnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dataGridViewGrupos);
            Controls.Add(buttonMatricular);
            Controls.Add(buttonCargarDatos);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPadresMatricula);
            Controls.Add(label1);
            Name = "UserNinnos";
            Size = new Size(1491, 646);
            Load += UserNinnos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPadresMatricula).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPadresMatricula;
        private Panel panel1;
        private Button buttonCargarDatos;
        private TextBox textBoxNombHijo;
        private TextBox textBoxNombPadre;
        private TextBox textBoxNumHijo;
        private TextBox textBoxNumPadre;
        private Label label2;
        private Button buttonGuardarMatricula;
        private TextBox textBoxNombDocente;
        private TextBox textBoxNumDocente;
        private Button buttonMatricular;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridViewGrupos;
        private Label label12;
        private TextBox textBoxGrupos;
        private TextBox textBoxIdGrupo;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxIdMatricula;
        private Label label13;
    }
}
