namespace WfInicial
{
    partial class FormEx10
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
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(106, 9);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(104, 23);
            txtNumero.TabIndex = 0;
            txtNumero.Leave += txtNumero_Leave;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(22, 9);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(57, 114);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(173, 224);
            txtResultado.TabIndex = 3;
            // 
            // FormEx10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 479);
            Controls.Add(txtResultado);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Name = "FormEx10";
            Text = "FormEx10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtResultado;
    }
}