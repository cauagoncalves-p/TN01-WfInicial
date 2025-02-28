namespace WfInicial
{
    partial class FormEx2
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
            btnEscolher = new Button();
            lblDiaSemana = new Label();
            txtDiaSemana = new TextBox();
            SuspendLayout();
            // 
            // btnEscolher
            // 
            btnEscolher.Location = new Point(378, 87);
            btnEscolher.Name = "btnEscolher";
            btnEscolher.Size = new Size(75, 23);
            btnEscolher.TabIndex = 0;
            btnEscolher.Text = "Escolher";
            btnEscolher.UseVisualStyleBackColor = true;
            btnEscolher.Click += btnEscolher_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(88, 90);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(85, 15);
            lblDiaSemana.TabIndex = 1;
            lblDiaSemana.Text = "Dia da Semana";
            // 
            // txtDiaSemana
            // 
            txtDiaSemana.Location = new Point(179, 87);
            txtDiaSemana.Name = "txtDiaSemana";
            txtDiaSemana.Size = new Size(178, 23);
            txtDiaSemana.TabIndex = 2;
            // 
            // FormEx2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 453);
            Controls.Add(txtDiaSemana);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnEscolher);
            Name = "FormEx2";
            Text = "FormEx2";
            Load += FormEx2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEscolher;
        private Label lblDiaSemana;
        private TextBox txtDiaSemana;
    }
}