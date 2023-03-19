namespace CapaPresentaciòn.BtViewTablas
{
    partial class GuardarAistente
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
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            txtIdDocente = new MaskedTextBox();
            textTitulo = new Label();
            textBoxNombreAsistente = new TextBox();
            textBoxNumAsistente = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Red;
            buttonCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(154, 395);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(120, 47);
            buttonCancelar.TabIndex = 88;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = SystemColors.ActiveCaption;
            buttonGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardar.ForeColor = SystemColors.ControlLightLight;
            buttonGuardar.Location = new Point(337, 395);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(126, 47);
            buttonGuardar.TabIndex = 87;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // txtIdDocente
            // 
            txtIdDocente.Location = new Point(154, 339);
            txtIdDocente.Name = "txtIdDocente";
            txtIdDocente.Size = new Size(309, 23);
            txtIdDocente.TabIndex = 86;
            txtIdDocente.MaskInputRejected += txtIdDocente_MaskInputRejected;
            // 
            // textTitulo
            // 
            textTitulo.AutoSize = true;
            textTitulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textTitulo.Location = new Point(204, 32);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(175, 28);
            textTitulo.TabIndex = 85;
            textTitulo.Text = "Nombre tabla";
            // 
            // textBoxNombreAsistente
            // 
            textBoxNombreAsistente.Location = new Point(154, 253);
            textBoxNombreAsistente.Name = "textBoxNombreAsistente";
            textBoxNombreAsistente.Size = new Size(309, 23);
            textBoxNombreAsistente.TabIndex = 84;
            textBoxNombreAsistente.TextChanged += textBoxNombreAsistente_TextChanged;
            // 
            // textBoxNumAsistente
            // 
            textBoxNumAsistente.Location = new Point(154, 168);
            textBoxNumAsistente.Name = "textBoxNumAsistente";
            textBoxNumAsistente.Size = new Size(309, 23);
            textBoxNumAsistente.TabIndex = 83;
            textBoxNumAsistente.TextChanged += textBoxNumAsistente_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(154, 317);
            label7.Name = "label7";
            label7.Size = new Size(94, 19);
            label7.TabIndex = 82;
            label7.Text = "N. Docente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(154, 231);
            label8.Name = "label8";
            label8.Size = new Size(152, 19);
            label8.TabIndex = 81;
            label8.Text = "Nombre completo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(154, 146);
            label9.Name = "label9";
            label9.Size = new Size(167, 19);
            label9.TabIndex = 80;
            label9.Text = "Numero Documento";
            // 
            // GuardarAistente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 474);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(txtIdDocente);
            Controls.Add(textTitulo);
            Controls.Add(textBoxNombreAsistente);
            Controls.Add(textBoxNumAsistente);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Name = "GuardarAistente";
            Text = "GuardarAistente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonGuardar;
        private MaskedTextBox txtIdDocente;
        private Label textTitulo;
        private TextBox textBoxNombreAsistente;
        private TextBox textBoxNumAsistente;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}