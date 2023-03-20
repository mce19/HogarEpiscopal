namespace CapaPresentaciòn.BtControles
{
    partial class Bienvenida
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewPágos = new DataGridView();
            buttonNewAbono = new Button();
            textBoxBuscador = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPágos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(573, 22);
            label1.Name = "label1";
            label1.Size = new Size(319, 38);
            label1.TabIndex = 3;
            label1.Text = "Pagos por cancelar";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewPágos
            // 
            dataGridViewPágos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPágos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPágos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPágos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewPágos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPágos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPágos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPágos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPágos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPágos.GridColor = Color.FromArgb(255, 128, 0);
            dataGridViewPágos.Location = new Point(29, 135);
            dataGridViewPágos.Name = "dataGridViewPágos";
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewPágos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPágos.RowTemplate.Height = 25;
            dataGridViewPágos.Size = new Size(1439, 378);
            dataGridViewPágos.TabIndex = 4;
            dataGridViewPágos.CellContentClick += dataGridViewPágos_CellContentClick;
            // 
            // buttonNewAbono
            // 
            buttonNewAbono.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNewAbono.BackColor = Color.FromArgb(0, 192, 0);
            buttonNewAbono.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNewAbono.ForeColor = Color.White;
            buttonNewAbono.Location = new Point(1332, 556);
            buttonNewAbono.Name = "buttonNewAbono";
            buttonNewAbono.Size = new Size(136, 44);
            buttonNewAbono.TabIndex = 5;
            buttonNewAbono.Text = "Abonar";
            buttonNewAbono.UseVisualStyleBackColor = false;
            buttonNewAbono.Click += buttonNewAbono_Click;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.BackColor = SystemColors.InactiveBorder;
            textBoxBuscador.Location = new Point(191, 106);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.Size = new Size(629, 23);
            textBoxBuscador.TabIndex = 10;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 106);
            label2.Name = "label2";
            label2.Size = new Size(156, 19);
            label2.TabIndex = 11;
            label2.Text = "Buscar por nombre";
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(textBoxBuscador);
            Controls.Add(buttonNewAbono);
            Controls.Add(dataGridViewPágos);
            Controls.Add(label1);
            Name = "Bienvenida";
            Size = new Size(1491, 646);
            Load += Bienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPágos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPágos;
        private Button buttonNewAbono;
        private TextBox textBoxBuscador;
        private Label label2;
    }
}
