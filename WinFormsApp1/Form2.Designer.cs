namespace WinFormsApp1
{
    partial class Form2
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
            lblReflejo = new Label();
            btnButton = new Button();
            btnPreciona = new Button();
            txtPreciona = new TextBox();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            btnSumar = new Button();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            btnAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblReflejo
            // 
            lblReflejo.AutoSize = true;
            lblReflejo.Location = new Point(27, 85);
            lblReflejo.Name = "lblReflejo";
            lblReflejo.Size = new Size(130, 20);
            lblReflejo.TabIndex = 0;
            lblReflejo.Text = "Precione el Button";
            // 
            // btnButton
            // 
            btnButton.Location = new Point(39, 140);
            btnButton.Name = "btnButton";
            btnButton.Size = new Size(100, 39);
            btnButton.TabIndex = 1;
            btnButton.Text = "Button";
            btnButton.UseVisualStyleBackColor = true;
            btnButton.Click += btnButton_Click;
            // 
            // btnPreciona
            // 
            btnPreciona.Location = new Point(45, 322);
            btnPreciona.Name = "btnPreciona";
            btnPreciona.Size = new Size(94, 29);
            btnPreciona.TabIndex = 2;
            btnPreciona.Text = "Preciona";
            btnPreciona.UseVisualStyleBackColor = true;
            btnPreciona.Click += btnPreciona_Click;
            // 
            // txtPreciona
            // 
            txtPreciona.Location = new Point(27, 264);
            txtPreciona.Name = "txtPreciona";
            txtPreciona.Size = new Size(149, 27);
            txtPreciona.TabIndex = 3;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(307, 118);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(125, 27);
            txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(307, 187);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(125, 27);
            txtValor2.TabIndex = 5;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(318, 260);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(94, 29);
            btnSumar.TabIndex = 6;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(610, 140);
            rb1.Name = "rb1";
            rb1.Size = new Size(85, 24);
            rb1.TabIndex = 7;
            rb1.TabStop = true;
            rb1.Text = "Hombre";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(610, 183);
            rb2.Name = "rb2";
            rb2.Size = new Size(68, 24);
            rb2.TabIndex = 8;
            rb2.TabStop = true;
            rb2.Text = "Mujer";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(610, 229);
            rb3.Name = "rb3";
            rb3.Size = new Size(83, 24);
            rb3.TabIndex = 9;
            rb3.TabStop = true;
            rb3.Text = "Soy Gay";
            rb3.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(610, 288);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(117, 29);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 11;
            label1.Text = "Mandato 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 208);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 12;
            label2.Text = "Mandato 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 57);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 13;
            label3.Text = "Mandato 4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(614, 85);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 14;
            label4.Text = "Mandato 5";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(rb3);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Controls.Add(btnSumar);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(txtPreciona);
            Controls.Add(btnPreciona);
            Controls.Add(btnButton);
            Controls.Add(lblReflejo);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReflejo;
        private Button btnButton;
        private Button btnPreciona;
        private TextBox txtPreciona;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Button btnSumar;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3;
        private Button btnAceptar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}