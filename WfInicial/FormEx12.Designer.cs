namespace WfInicial
{
    partial class FormEx12
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblContador = new Label();
            btnCadastrar = new Button();
            lblNumeros = new Label();
            lblPar = new Label();
            lblImpar = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 26);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(94, 26);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(338, 26);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(13, 15);
            lblContador.TabIndex = 0;
            lblContador.Text = "0";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(141, 107);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Adicionar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNumeros
            // 
            lblNumeros.BorderStyle = BorderStyle.Fixed3D;
            lblNumeros.Location = new Point(7, 162);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(344, 41);
            lblNumeros.TabIndex = 4;
            lblNumeros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPar
            // 
            lblPar.BorderStyle = BorderStyle.Fixed3D;
            lblPar.Location = new Point(7, 233);
            lblPar.Name = "lblPar";
            lblPar.Size = new Size(344, 38);
            lblPar.TabIndex = 5;
            lblPar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImpar
            // 
            lblImpar.BorderStyle = BorderStyle.Fixed3D;
            lblImpar.Location = new Point(7, 309);
            lblImpar.Name = "lblImpar";
            lblImpar.Size = new Size(344, 40);
            lblImpar.TabIndex = 6;
            lblImpar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEx12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 379);
            Controls.Add(lblImpar);
            Controls.Add(lblPar);
            Controls.Add(lblNumeros);
            Controls.Add(btnCadastrar);
            Controls.Add(lblContador);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "FormEx12";
            Text = "FormEx12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblContador;
        private Button btnCadastrar;
        private Label lblNumeros;
        private Label lblPar;
        private Label lblImpar;
    }
}