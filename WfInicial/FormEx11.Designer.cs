namespace WfInicial
{
    partial class FormEx11
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
            lblSalario = new Label();
            txtSalario = new TextBox();
            btnCalcular = new Button();
            txtResultado = new RichTextBox();
            SuspendLayout();
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(249, 46);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(74, 15);
            lblSalario.TabIndex = 0;
            lblSalario.Text = "Salario Bruto";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(249, 78);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(249, 359);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(249, 123);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(192, 211);
            txtResultado.TabIndex = 3;
            txtResultado.Text = "";
            // 
            // FormEx11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Name = "FormEx11";
            Text = "FormEx11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalario;
        private TextBox txtSalario;
        private Button btnCalcular;
        private RichTextBox txtResultado;
    }
}