namespace CapaPresentaciòn.BtViewTablas
{
    partial class TablaMatriculas
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textIdGrpo = new System.Windows.Forms.TextBox();
            this.buttonGuardaDocente = new System.Windows.Forms.Button();
            this.textCedPadre = new System.Windows.Forms.MaskedTextBox();
            this.TxtTitTablaMatricula = new System.Windows.Forms.Label();
            this.textCedDocente = new System.Windows.Forms.TextBox();
            this.textCedHijo = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Red;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(446, 432);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 47);
            this.buttonCancelar.TabIndex = 77;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(376, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "Grupo ID";
            // 
            // textIdGrpo
            // 
            this.textIdGrpo.Location = new System.Drawing.Point(376, 211);
            this.textIdGrpo.Name = "textIdGrpo";
            this.textIdGrpo.Size = new System.Drawing.Size(309, 23);
            this.textIdGrpo.TabIndex = 75;
            this.textIdGrpo.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // buttonGuardaDocente
            // 
            this.buttonGuardaDocente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuardaDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardaDocente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardaDocente.Location = new System.Drawing.Point(572, 432);
            this.buttonGuardaDocente.Name = "buttonGuardaDocente";
            this.buttonGuardaDocente.Size = new System.Drawing.Size(126, 47);
            this.buttonGuardaDocente.TabIndex = 74;
            this.buttonGuardaDocente.Text = "Guardar";
            this.buttonGuardaDocente.UseVisualStyleBackColor = false;
            // 
            // textCedPadre
            // 
            this.textCedPadre.Location = new System.Drawing.Point(43, 297);
            this.textCedPadre.Name = "textCedPadre";
            this.textCedPadre.Size = new System.Drawing.Size(309, 23);
            this.textCedPadre.TabIndex = 73;
            this.textCedPadre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TextCedPadre_MaskInputRejected);
            // 
            // TxtTitTablaMatricula
            // 
            this.TxtTitTablaMatricula.AutoSize = true;
            this.TxtTitTablaMatricula.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtTitTablaMatricula.Location = new System.Drawing.Point(275, 27);
            this.TxtTitTablaMatricula.Name = "TxtTitTablaMatricula";
            this.TxtTitTablaMatricula.Size = new System.Drawing.Size(175, 28);
            this.TxtTitTablaMatricula.TabIndex = 72;
            this.TxtTitTablaMatricula.Text = "Nombre tabla";
            // 
            // textCedDocente
            // 
            this.textCedDocente.Location = new System.Drawing.Point(376, 126);
            this.textCedDocente.Name = "textCedDocente";
            this.textCedDocente.Size = new System.Drawing.Size(309, 23);
            this.textCedDocente.TabIndex = 71;
            this.textCedDocente.TextChanged += new System.EventHandler(this.textCedDocente_TextChanged);
            // 
            // textCedHijo
            // 
            this.textCedHijo.Location = new System.Drawing.Point(43, 211);
            this.textCedHijo.Name = "textCedHijo";
            this.textCedHijo.Size = new System.Drawing.Size(309, 23);
            this.textCedHijo.TabIndex = 70;
            this.textCedHijo.TextChanged += new System.EventHandler(this.textCedHijo_TextChanged);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(43, 126);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(309, 23);
            this.textId.TabIndex = 69;
            this.textId.TextChanged += new System.EventHandler(this.textIdGrupo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(376, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ced. Docente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ced. Padre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Ced. Hijo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "ID";
            // 
            // TablaMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 497);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textIdGrpo);
            this.Controls.Add(this.buttonGuardaDocente);
            this.Controls.Add(this.textCedPadre);
            this.Controls.Add(this.TxtTitTablaMatricula);
            this.Controls.Add(this.textCedDocente);
            this.Controls.Add(this.textCedHijo);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TablaMatriculas";
            this.Text = "TablaMatriculas";
            this.Load += new System.EventHandler(this.TablaMatriculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancelar;
        private Label label5;
        private TextBox textIdGrpo;
        private Button buttonGuardaDocente;
        private MaskedTextBox textCedPadre;
        private Label TxtTitTablaMatricula;
        private TextBox textCedDocente;
        private TextBox textCedHijo;
        private TextBox textId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}