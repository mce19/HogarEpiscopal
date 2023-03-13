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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFactura = new System.Windows.Forms.Button();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistorial
            // 
            this.dataGridViewHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorial.Location = new System.Drawing.Point(33, 126);
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.RowTemplate.Height = 25;
            this.dataGridViewHistorial.Size = new System.Drawing.Size(1439, 378);
            this.dataGridViewHistorial.TabIndex = 5;
            this.dataGridViewHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistorial_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(585, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Historial de pagos ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonFactura
            // 
            this.buttonFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFactura.ForeColor = System.Drawing.Color.White;
            this.buttonFactura.Location = new System.Drawing.Point(1310, 551);
            this.buttonFactura.Name = "buttonFactura";
            this.buttonFactura.Size = new System.Drawing.Size(162, 44);
            this.buttonFactura.TabIndex = 7;
            this.buttonFactura.Text = "Imprimir Factura";
            this.buttonFactura.UseVisualStyleBackColor = false;
            this.buttonFactura.Click += new System.EventHandler(this.buttonFactura_Click);
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxBuscador.Location = new System.Drawing.Point(195, 88);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(629, 23);
            this.textBoxBuscador.TabIndex = 9;
            this.textBoxBuscador.TextChanged += new System.EventHandler(this.textBoxBuscador_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar por nombre";
            // 
            // UserHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.buttonFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHistorial);
            this.Name = "UserHistorial";
            this.Size = new System.Drawing.Size(1491, 646);
            this.Load += new System.EventHandler(this.UserHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewHistorial;
        private Label label1;
        private Button buttonFactura;
        private TextBox textBoxBuscador;
        private Label label2;
    }
}
