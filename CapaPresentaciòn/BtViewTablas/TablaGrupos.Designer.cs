namespace CapaPresentaciòn.BtViewTablas
{
    partial class TablaGrupos
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
            this.TxtTitTablaGrupo = new System.Windows.Forms.Label();
            this.textBoxNombreGrupo = new System.Windows.Forms.TextBox();
            this.textBoxIdGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardarGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTitTablaGrupo
            // 
            this.TxtTitTablaGrupo.AutoSize = true;
            this.TxtTitTablaGrupo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtTitTablaGrupo.Location = new System.Drawing.Point(206, 31);
            this.TxtTitTablaGrupo.Name = "TxtTitTablaGrupo";
            this.TxtTitTablaGrupo.Size = new System.Drawing.Size(175, 28);
            this.TxtTitTablaGrupo.TabIndex = 64;
            this.TxtTitTablaGrupo.Text = "Nombre tabla";
            this.TxtTitTablaGrupo.Click += new System.EventHandler(this.TxtTitTablaGrupo_Click);
            // 
            // textBoxNombreGrupo
            // 
            this.textBoxNombreGrupo.Location = new System.Drawing.Point(155, 193);
            this.textBoxNombreGrupo.Name = "textBoxNombreGrupo";
            this.textBoxNombreGrupo.Size = new System.Drawing.Size(252, 23);
            this.textBoxNombreGrupo.TabIndex = 63;
            this.textBoxNombreGrupo.TextChanged += new System.EventHandler(this.textBoxNombreGrupo_TextChanged);
            // 
            // textBoxIdGrupo
            // 
            this.textBoxIdGrupo.Location = new System.Drawing.Point(155, 124);
            this.textBoxIdGrupo.Name = "textBoxIdGrupo";
            this.textBoxIdGrupo.Size = new System.Drawing.Size(252, 23);
            this.textBoxIdGrupo.TabIndex = 62;
            this.textBoxIdGrupo.TextChanged += new System.EventHandler(this.textBoxIdGrupo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(155, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Red;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(155, 233);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 47);
            this.buttonCancelar.TabIndex = 66;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardarGrupo
            // 
            this.buttonGuardarGrupo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonGuardarGrupo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardarGrupo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardarGrupo.Location = new System.Drawing.Point(281, 233);
            this.buttonGuardarGrupo.Name = "buttonGuardarGrupo";
            this.buttonGuardarGrupo.Size = new System.Drawing.Size(126, 47);
            this.buttonGuardarGrupo.TabIndex = 65;
            this.buttonGuardarGrupo.Text = "Guardar";
            this.buttonGuardarGrupo.UseVisualStyleBackColor = false;
            // 
            // TablaGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 324);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardarGrupo);
            this.Controls.Add(this.TxtTitTablaGrupo);
            this.Controls.Add(this.textBoxNombreGrupo);
            this.Controls.Add(this.textBoxIdGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TablaGrupos";
            this.Text = "TablaGrupos";
            this.Load += new System.EventHandler(this.TablaGrupos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TxtTitTablaGrupo;
        private TextBox textBoxNombreGrupo;
        private TextBox textBoxIdGrupo;
        private Label label4;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonGuardarGrupo;
    }
}