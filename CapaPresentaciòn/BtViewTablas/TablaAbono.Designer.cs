namespace CapaPresentaciòn.BtViewTablas
{
    partial class TablaAbono
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
            this.buttonCancelarPago = new System.Windows.Forms.Button();
            this.buttonGuardarPago = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDetalles = new System.Windows.Forms.TextBox();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxAbono = new System.Windows.Forms.TextBox();
            this.textBoxnMensual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.nombrepadres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelarPago
            // 
            this.buttonCancelarPago.BackColor = System.Drawing.Color.Red;
            this.buttonCancelarPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelarPago.ForeColor = System.Drawing.Color.White;
            this.buttonCancelarPago.Location = new System.Drawing.Point(421, 406);
            this.buttonCancelarPago.Name = "buttonCancelarPago";
            this.buttonCancelarPago.Size = new System.Drawing.Size(120, 47);
            this.buttonCancelarPago.TabIndex = 50;
            this.buttonCancelarPago.Text = "Cancelar";
            this.buttonCancelarPago.UseVisualStyleBackColor = false;
            this.buttonCancelarPago.Click += new System.EventHandler(this.buttonCancelarPago_Click);
            // 
            // buttonGuardarPago
            // 
            this.buttonGuardarPago.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonGuardarPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardarPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarPago.Location = new System.Drawing.Point(547, 406);
            this.buttonGuardarPago.Name = "buttonGuardarPago";
            this.buttonGuardarPago.Size = new System.Drawing.Size(126, 47);
            this.buttonGuardarPago.TabIndex = 49;
            this.buttonGuardarPago.Text = "Guardar";
            this.buttonGuardarPago.UseVisualStyleBackColor = false;
            this.buttonGuardarPago.Click += new System.EventHandler(this.buttonGuardarPago_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(194, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 51;
            this.label3.Text = "Abono :";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(54, 114);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(252, 23);
            this.textBoxId.TabIndex = 67;
            this.textBoxId.UseWaitCursor = true;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(54, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 19);
            this.label9.TabIndex = 66;
            this.label9.Text = "ID";
            // 
            // textBoxDetalles
            // 
            this.textBoxDetalles.Location = new System.Drawing.Point(421, 261);
            this.textBoxDetalles.Name = "textBoxDetalles";
            this.textBoxDetalles.Size = new System.Drawing.Size(252, 23);
            this.textBoxDetalles.TabIndex = 65;
            this.textBoxDetalles.TextChanged += new System.EventHandler(this.textBoxDetalles_TextChanged);
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(421, 114);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.ReadOnly = true;
            this.textBoxSaldo.Size = new System.Drawing.Size(252, 23);
            this.textBoxSaldo.TabIndex = 64;
            this.textBoxSaldo.TextChanged += new System.EventHandler(this.textBoxSaldo_TextChanged);
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Location = new System.Drawing.Point(421, 176);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(252, 23);
            this.dateTimeFecha.TabIndex = 62;
            this.dateTimeFecha.ValueChanged += new System.EventHandler(this.dateTimeFecha_ValueChanged);
            // 
            // textBoxAbono
            // 
            this.textBoxAbono.Location = new System.Drawing.Point(54, 346);
            this.textBoxAbono.Name = "textBoxAbono";
            this.textBoxAbono.Size = new System.Drawing.Size(252, 23);
            this.textBoxAbono.TabIndex = 61;
            this.textBoxAbono.TextChanged += new System.EventHandler(this.textBoxAbono_TextChanged);
            // 
            // textBoxnMensual
            // 
            this.textBoxnMensual.Location = new System.Drawing.Point(54, 261);
            this.textBoxnMensual.Name = "textBoxnMensual";
            this.textBoxnMensual.ReadOnly = true;
            this.textBoxnMensual.Size = new System.Drawing.Size(252, 23);
            this.textBoxnMensual.TabIndex = 60;
            this.textBoxnMensual.TextChanged += new System.EventHandler(this.textBoxnMensual_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(421, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "Detalles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(421, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Saldo Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Abono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(421, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Monto mensual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(54, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 19);
            this.label8.TabIndex = 52;
            this.label8.Text = "Nombre completo";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(54, 182);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.ReadOnly = true;
            this.textBoxnombre.Size = new System.Drawing.Size(252, 23);
            this.textBoxnombre.TabIndex = 69;
            this.textBoxnombre.TextChanged += new System.EventHandler(this.textBoxnombre_TextChanged);
            // 
            // nombrepadres
            // 
            this.nombrepadres.AutoSize = true;
            this.nombrepadres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nombrepadres.Location = new System.Drawing.Point(304, 30);
            this.nombrepadres.Name = "nombrepadres";
            this.nombrepadres.Size = new System.Drawing.Size(56, 19);
            this.nombrepadres.TabIndex = 70;
            this.nombrepadres.Text = "name";
            this.nombrepadres.Click += new System.EventHandler(this.nombrepadres_Click);
            // 
            // TablaAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 497);
            this.ControlBox = false;
            this.Controls.Add(this.nombrepadres);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDetalles);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.textBoxAbono);
            this.Controls.Add(this.textBoxnMensual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelarPago);
            this.Controls.Add(this.buttonGuardarPago);
            this.Name = "TablaAbono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaAbono";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.namepadre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonCancelarPago;
        private Button buttonGuardarPago;
        private Label label3;
        private TextBox textBoxId;
        private Label label9;
        private TextBox textBoxDetalles;
        private TextBox textBoxSaldo;
        private DateTimePicker dateTimeFecha;
        private TextBox textBoxAbono;
        private TextBox textBoxnMensual;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label8;
        private TextBox textBoxnombre;
        private Label nombrepadres;
    }
}