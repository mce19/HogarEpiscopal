namespace CapaPresentaciòn.BtControles
{
    partial class UserHistorial
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewHistorial = new DataGridView();
            label1 = new Label();
            buttonFactura = new Button();
            textBoxBuscador = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistorial
            // 
            dataGridViewHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewHistorial.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorial.Location = new Point(33, 126);
            dataGridViewHistorial.Name = "dataGridViewHistorial";
            dataGridViewHistorial.RowTemplate.Height = 25;
            dataGridViewHistorial.Size = new Size(1439, 378);
            dataGridViewHistorial.TabIndex = 5;
            dataGridViewHistorial.CellContentClick += dataGridViewHistorial_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(585, 32);
            label1.Name = "label1";
            label1.Size = new Size(303, 38);
            label1.TabIndex = 6;
            label1.Text = "Historial de pagos ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonFactura
            // 
            buttonFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFactura.BackColor = Color.FromArgb(0, 192, 0);
            buttonFactura.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFactura.ForeColor = Color.White;
            buttonFactura.Location = new Point(1310, 551);
            buttonFactura.Name = "buttonFactura";
            buttonFactura.Size = new Size(162, 44);
            buttonFactura.TabIndex = 7;
            buttonFactura.Text = "Imprimir Factura";
            buttonFactura.UseVisualStyleBackColor = false;
            buttonFactura.Click += buttonFactura_Click;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.BackColor = SystemColors.InactiveBorder;
            textBoxBuscador.Location = new Point(195, 88);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.Size = new Size(629, 23);
            textBoxBuscador.TabIndex = 9;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 87);
            label2.Name = "label2";
            label2.Size = new Size(156, 19);
            label2.TabIndex = 12;
            label2.Text = "Buscar por nombre";
            // 
            // UserHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(textBoxBuscador);
            Controls.Add(buttonFactura);
            Controls.Add(label1);
            Controls.Add(dataGridViewHistorial);
            Name = "UserHistorial";
            Size = new Size(1491, 646);
            Load += UserHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHistorial;
        private Label label1;
        private Button buttonFactura;
        private TextBox textBoxBuscador;
        private Label label2;
    }
}
