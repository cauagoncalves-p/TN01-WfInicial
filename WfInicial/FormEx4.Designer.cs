namespace WfInicial
{
    partial class FormEx4
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
            btnCalcular = new Button();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            lblNumero3 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtNumero3 = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(294, 263);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular maior";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(226, 127);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(57, 15);
            lblNumero1.TabIndex = 1;
            lblNumero1.Text = "Numero1";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(223, 166);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(60, 15);
            lblNumero2.TabIndex = 2;
            lblNumero2.Text = "Numero 2";
            // 
            // lblNumero3
            // 
            lblNumero3.AutoSize = true;
            lblNumero3.Location = new Point(223, 214);
            lblNumero3.Name = "lblNumero3";
            lblNumero3.Size = new Size(57, 15);
            lblNumero3.TabIndex = 3;
            lblNumero3.Text = "Numero3";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(289, 124);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 4;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(289, 166);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 5;
            // 
            // txtNumero3
            // 
            txtNumero3.Location = new Point(289, 211);
            txtNumero3.Name = "txtNumero3";
            txtNumero3.Size = new Size(100, 23);
            txtNumero3.TabIndex = 6;
            // 
            // FormEx4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero3);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero3);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(btnCalcular);
            Name = "FormEx4";
            Text = "FormEx4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblNumero3;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtNumero3;
    }
}