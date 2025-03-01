namespace WfInicial
{
    partial class FormEx6
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
            lblNome = new Label();
            lblhoraTrabalhada = new Label();
            lblSalario = new Label();
            txtSalario = new TextBox();
            txtHoraTrabalhada = new TextBox();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(177, 305);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(175, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular salario bruto";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(135, 140);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(94, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Qual seu Nome?";
            // 
            // lblhoraTrabalhada
            // 
            lblhoraTrabalhada.AutoSize = true;
            lblhoraTrabalhada.Location = new Point(135, 190);
            lblhoraTrabalhada.Name = "lblhoraTrabalhada";
            lblhoraTrabalhada.Size = new Size(173, 15);
            lblhoraTrabalhada.TabIndex = 2;
            lblhoraTrabalhada.Text = "Quantas horas você trabalhou ?";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(135, 240);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(98, 15);
            lblSalario.TabIndex = 3;
            lblSalario.Text = "Qual seu salario ?";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(265, 237);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 4;
            // 
            // txtHoraTrabalhada
            // 
            txtHoraTrabalhada.Location = new Point(314, 187);
            txtHoraTrabalhada.Name = "txtHoraTrabalhada";
            txtHoraTrabalhada.Size = new Size(100, 23);
            txtHoraTrabalhada.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(252, 137);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 6;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(txtHoraTrabalhada);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(lblhoraTrabalhada);
            Controls.Add(lblNome);
            Controls.Add(btnCalcular);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNome;
        private Label lblhoraTrabalhada;
        private Label lblSalario;
        private TextBox txtSalario;
        private TextBox txtHoraTrabalhada;
        private TextBox txtNome;
    }
}