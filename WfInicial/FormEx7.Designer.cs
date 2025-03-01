namespace WfInicial
{
    partial class FormEx7
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
            lblProduto = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            txtProduto = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(155, 221);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(62, 124);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 1;
            lblProduto.Text = "Produto";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(62, 178);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(130, 170);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 3;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(130, 121);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(100, 23);
            txtProduto.TabIndex = 4;
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProduto);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(lblProduto);
            Controls.Add(btnCalcular);
            Name = "FormEx7";
            Text = "FormEx7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblProduto;
        private Label lblValor;
        private TextBox txtValor;
        private TextBox txtProduto;
    }
}