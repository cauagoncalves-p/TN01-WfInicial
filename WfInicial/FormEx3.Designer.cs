﻿namespace WfInicial
{
    partial class FormEx3
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
            txtNumero2 = new TextBox();
            txtNumero1 = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(264, 265);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Mostrar o maior";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(154, 170);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(65, 15);
            lblNumero1.TabIndex = 1;
            lblNumero1.Text = "1º Numero";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(154, 214);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(65, 15);
            lblNumero2.TabIndex = 2;
            lblNumero2.Text = "2º Numero";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(283, 211);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 3;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(283, 170);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 4;
            // 
            // FormEx3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero1);
            Controls.Add(txtNumero2);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(btnCalcular);
            Name = "FormEx3";
            Text = "FormEx3cs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNumero1;
        private Label lblNumero2;
        private TextBox txtNumero2;
        private TextBox txtNumero1;
    }
}