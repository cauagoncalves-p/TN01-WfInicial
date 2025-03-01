namespace WfInicial
{
    partial class FormEx5
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
            txtNumero3 = new TextBox();
            txtNumero2 = new TextBox();
            txtNumero1 = new TextBox();
            lblNumero3 = new Label();
            lblNumero2 = new Label();
            lblNumero1 = new Label();
            btnNumeros = new Button();
            SuspendLayout();
            // 
            // txtNumero3
            // 
            txtNumero3.Location = new Point(388, 226);
            txtNumero3.Name = "txtNumero3";
            txtNumero3.Size = new Size(100, 23);
            txtNumero3.TabIndex = 13;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(388, 181);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 12;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(388, 139);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 11;
            // 
            // lblNumero3
            // 
            lblNumero3.AutoSize = true;
            lblNumero3.Location = new Point(289, 234);
            lblNumero3.Name = "lblNumero3";
            lblNumero3.Size = new Size(57, 15);
            lblNumero3.TabIndex = 10;
            lblNumero3.Text = "Numero3";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(286, 184);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(60, 15);
            lblNumero2.TabIndex = 9;
            lblNumero2.Text = "Numero 2";
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(286, 139);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(57, 15);
            lblNumero1.TabIndex = 8;
            lblNumero1.Text = "Numero1";
            // 
            // btnNumeros
            // 
            btnNumeros.Location = new Point(360, 288);
            btnNumeros.Name = "btnNumeros";
            btnNumeros.Size = new Size(128, 53);
            btnNumeros.TabIndex = 14;
            btnNumeros.Text = "Calcular Maior ou Menor";
            btnNumeros.UseVisualStyleBackColor = true;
            btnNumeros.Click += btnNumeros_Click_1;
            // 
            // FormEx5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNumeros);
            Controls.Add(txtNumero3);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero3);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Name = "FormEx5";
            Text = "FormEx5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero3;
        private TextBox txtNumero2;
        private TextBox txtNumero1;
        private Label lblNumero3;
        private Label lblNumero2;
        private Label lblNumero1;
        private Button btnCalcular;
        private Button btnNumeros;
    }
}