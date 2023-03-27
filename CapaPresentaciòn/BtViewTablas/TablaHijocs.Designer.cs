namespace CapaPresentaciòn.BtViewTablas
{
    partial class TablaHijocs
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxNumDocuHijo = new TextBox();
            textBoxnNombCompletoHijo = new TextBox();
            textBoxEdadHijo = new TextBox();
            dateTimePickerHijo = new DateTimePicker();
            labelnombreHijos = new Label();
            buttonGuardarHijo = new Button();
            label8 = new Label();
            textBoxPadreId = new TextBox();
            textBoxSegInicHijo = new TextBox();
            textBoxSubsidio = new TextBox();
            buttonCancelarPago = new Button();
            textBoxGeneroHijo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 101);
            label1.Name = "label1";
            label1.Size = new Size(192, 19);
            label1.TabIndex = 0;
            label1.Text = "Numero de Documento";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 180);
            label2.Name = "label2";
            label2.Size = new Size(154, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre Completo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 261);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 2;
            label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 347);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 3;
            label4.Text = "Edad";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(426, 101);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 4;
            label5.Text = "Género";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(426, 180);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 5;
            label6.Text = "Segun Inec";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(426, 261);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 6;
            label7.Text = "Subsidio";
            // 
            // textBoxNumDocuHijo
            // 
            textBoxNumDocuHijo.Location = new Point(63, 123);
            textBoxNumDocuHijo.Name = "textBoxNumDocuHijo";
            textBoxNumDocuHijo.Size = new Size(252, 23);
            textBoxNumDocuHijo.TabIndex = 7;
            textBoxNumDocuHijo.TextChanged += textBoxNumDocuHijo_TextChanged;
            // 
            // textBoxnNombCompletoHijo
            // 
            textBoxnNombCompletoHijo.Location = new Point(63, 202);
            textBoxnNombCompletoHijo.Name = "textBoxnNombCompletoHijo";
            textBoxnNombCompletoHijo.Size = new Size(252, 23);
            textBoxnNombCompletoHijo.TabIndex = 8;
            // 
            // textBoxEdadHijo
            // 
            textBoxEdadHijo.Location = new Point(63, 369);
            textBoxEdadHijo.Name = "textBoxEdadHijo";
            textBoxEdadHijo.Size = new Size(252, 23);
            textBoxEdadHijo.TabIndex = 12;
            textBoxEdadHijo.TextChanged += textBox3_TextChanged;
            // 
            // dateTimePickerHijo
            // 
            dateTimePickerHijo.Location = new Point(63, 287);
            dateTimePickerHijo.Name = "dateTimePickerHijo";
            dateTimePickerHijo.Size = new Size(252, 23);
            dateTimePickerHijo.TabIndex = 13;
            dateTimePickerHijo.ValueChanged += dateTimePickerHijo_ValueChanged;
            // 
            // labelnombreHijos
            // 
            labelnombreHijos.AutoSize = true;
            labelnombreHijos.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelnombreHijos.Location = new Point(251, 29);
            labelnombreHijos.Name = "labelnombreHijos";
            labelnombreHijos.Size = new Size(175, 28);
            labelnombreHijos.TabIndex = 14;
            labelnombreHijos.Text = "Nombre tabla";
            labelnombreHijos.Click += labelnombreHijos_Click;
            // 
            // buttonGuardarHijo
            // 
            buttonGuardarHijo.BackColor = SystemColors.GradientActiveCaption;
            buttonGuardarHijo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardarHijo.ForeColor = SystemColors.ButtonHighlight;
            buttonGuardarHijo.Location = new Point(552, 417);
            buttonGuardarHijo.Name = "buttonGuardarHijo";
            buttonGuardarHijo.Size = new Size(126, 47);
            buttonGuardarHijo.TabIndex = 15;
            buttonGuardarHijo.Text = "Guardar";
            buttonGuardarHijo.UseVisualStyleBackColor = false;
            buttonGuardarHijo.Click += buttonGuardarHijo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(426, 347);
            label8.Name = "label8";
            label8.Size = new Size(146, 19);
            label8.TabIndex = 16;
            label8.Text = "Cédula del Padre";
            label8.Click += label8_Click;
            // 
            // textBoxPadreId
            // 
            textBoxPadreId.Location = new Point(426, 369);
            textBoxPadreId.Name = "textBoxPadreId";
            textBoxPadreId.Size = new Size(252, 23);
            textBoxPadreId.TabIndex = 17;
            textBoxPadreId.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSegInicHijo
            // 
            textBoxSegInicHijo.Location = new Point(426, 202);
            textBoxSegInicHijo.Name = "textBoxSegInicHijo";
            textBoxSegInicHijo.Size = new Size(252, 23);
            textBoxSegInicHijo.TabIndex = 20;
            // 
            // textBoxSubsidio
            // 
            textBoxSubsidio.Location = new Point(426, 287);
            textBoxSubsidio.Name = "textBoxSubsidio";
            textBoxSubsidio.Size = new Size(252, 23);
            textBoxSubsidio.TabIndex = 21;
            // 
            // buttonCancelarPago
            // 
            buttonCancelarPago.BackColor = Color.Red;
            buttonCancelarPago.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelarPago.ForeColor = Color.White;
            buttonCancelarPago.Location = new Point(426, 417);
            buttonCancelarPago.Name = "buttonCancelarPago";
            buttonCancelarPago.Size = new Size(120, 47);
            buttonCancelarPago.TabIndex = 51;
            buttonCancelarPago.Text = "Cancelar";
            buttonCancelarPago.UseVisualStyleBackColor = false;
            buttonCancelarPago.Click += buttonCancelarPago_Click;
            // 
            // textBoxGeneroHijo
            // 
            textBoxGeneroHijo.FormattingEnabled = true;
            textBoxGeneroHijo.Location = new Point(426, 123);
            textBoxGeneroHijo.Name = "textBoxGeneroHijo";
            textBoxGeneroHijo.Size = new Size(146, 23);
            textBoxGeneroHijo.TabIndex = 52;
            textBoxGeneroHijo.SelectedIndexChanged += textBoxGeneroHijo_SelectedIndexChanged;
            // 
            // TablaHijocs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 488);
            ControlBox = false;
            Controls.Add(textBoxGeneroHijo);
            Controls.Add(buttonCancelarPago);
            Controls.Add(textBoxSubsidio);
            Controls.Add(textBoxSegInicHijo);
            Controls.Add(textBoxPadreId);
            Controls.Add(label8);
            Controls.Add(buttonGuardarHijo);
            Controls.Add(labelnombreHijos);
            Controls.Add(dateTimePickerHijo);
            Controls.Add(textBoxEdadHijo);
            Controls.Add(textBoxnNombCompletoHijo);
            Controls.Add(textBoxNumDocuHijo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TablaHijocs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TablaHijocs";
            TopMost = true;
            Load += TablaHijocs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxNumDocuHijo;
        private TextBox textBoxnNombCompletoHijo;
        private TextBox textBoxEdadHijo;
        private DateTimePicker dateTimePickerHijo;
        private Label labelnombreHijos;
        private Button buttonGuardarHijo;
        private Label label8;
        private TextBox textBoxPadreId;
        private TextBox textBoxSegInicHijo;
        private TextBox textBoxSubsidio;
        private Button buttonCancelarPago;
        private ComboBox textBoxGeneroHijo;
    }
}