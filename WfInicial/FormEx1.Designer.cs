namespace WfInicial
{
    partial class FormEx1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNota1 = new Label();
            btnCalcular = new Button();
            txtNota1 = new TextBox();
            labelNota2 = new Label();
            txtNota2 = new TextBox();
            SuspendLayout();
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.Location = new Point(183, 96);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(60, 15);
            labelNota1.TabIndex = 0;
            labelNota1.Text = "Numero 1\r\n";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(261, 195);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular Média";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(261, 93);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 2;
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.Location = new Point(183, 141);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(60, 45);
            labelNota2.TabIndex = 3;
            labelNota2.Text = "Numero 2\r\n\r\n\r\n";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(261, 138);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNota2);
            Controls.Add(labelNota2);
            Controls.Add(txtNota1);
            Controls.Add(btnCalcular);
            Controls.Add(labelNota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNota1;
        private Button btnCalcular;
        private TextBox txtNota1;
        private Label labelNota2;
        private TextBox txtNota2;
    }
}
