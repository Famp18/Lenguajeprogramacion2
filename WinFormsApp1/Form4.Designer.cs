namespace WinFormsApp1
{
    partial class Form4
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
            txtagregar = new TextBox();
            btnConvertir = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnInciar = new Button();
            progressBar1 = new ProgressBar();
            btnCancelar = new Button();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label3 = new Label();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // txtagregar
            // 
            txtagregar.Location = new Point(23, 147);
            txtagregar.Name = "txtagregar";
            txtagregar.Size = new Size(188, 27);
            txtagregar.TabIndex = 0;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(66, 260);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(94, 29);
            btnConvertir.TabIndex = 1;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 28);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 101);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "Mandato 12";
            // 
            // btnInciar
            // 
            btnInciar.Location = new Point(244, 346);
            btnInciar.Name = "btnInciar";
            btnInciar.Size = new Size(104, 41);
            btnInciar.TabIndex = 4;
            btnInciar.Text = "Iniciar";
            btnInciar.UseVisualStyleBackColor = true;
            btnInciar.Click += btnInciar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(244, 272);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(221, 29);
            progressBar1.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(361, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 41);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 214);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 7;
            label2.Text = "Mandato 13";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(518, 105);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(250, 171);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(242, 138);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 138);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(592, 60);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 9;
            label3.Text = "Mandato 14";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(progressBar1);
            Controls.Add(btnInciar);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnConvertir);
            Controls.Add(txtagregar);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtagregar;
        private Button btnConvertir;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnInciar;
        private ProgressBar progressBar1;
        private Button btnCancelar;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
    }
}