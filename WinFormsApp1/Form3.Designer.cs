namespace WinFormsApp1
{
    partial class Form3
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            lbxAgregar = new ListBox();
            btnAgregar = new Button();
            txtAgregar = new TextBox();
            label2 = new Label();
            btnConteo = new Button();
            label3 = new Label();
            txtPrecionar = new TextBox();
            btnPrecionar = new Button();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            btnFecha = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AccessibleDescription = "cbColor";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Rojo", "Verde", "Azul" });
            comboBox1.Location = new Point(36, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 61);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Mandato 6";
            // 
            // lbxAgregar
            // 
            lbxAgregar.FormattingEnabled = true;
            lbxAgregar.Location = new Point(36, 233);
            lbxAgregar.Name = "lbxAgregar";
            lbxAgregar.Size = new Size(163, 144);
            lbxAgregar.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(71, 402);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(36, 187);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(163, 27);
            txtAgregar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 155);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 5;
            label2.Text = "Mandato 7";
            // 
            // btnConteo
            // 
            btnConteo.Location = new Point(284, 137);
            btnConteo.Name = "btnConteo";
            btnConteo.Size = new Size(123, 35);
            btnConteo.TabIndex = 6;
            btnConteo.Text = "Conteo";
            btnConteo.UseVisualStyleBackColor = true;
            btnConteo.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 101);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 7;
            label3.Text = "Mandato 8";
            // 
            // txtPrecionar
            // 
            txtPrecionar.Location = new Point(284, 308);
            txtPrecionar.Name = "txtPrecionar";
            txtPrecionar.Size = new Size(166, 27);
            txtPrecionar.TabIndex = 8;
            // 
            // btnPrecionar
            // 
            btnPrecionar.Location = new Point(317, 355);
            btnPrecionar.Name = "btnPrecionar";
            btnPrecionar.Size = new Size(94, 29);
            btnPrecionar.TabIndex = 9;
            btnPrecionar.Text = "Precionar";
            btnPrecionar.UseVisualStyleBackColor = true;
            btnPrecionar.Click += btnPrecionar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 259);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 10;
            label4.Text = "Mandato 9";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(496, 185);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 11;
            // 
            // btnFecha
            // 
            btnFecha.Location = new Point(563, 250);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(94, 29);
            btnFecha.TabIndex = 12;
            btnFecha.Text = "Precionar";
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFecha_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(btnFecha);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(btnPrecionar);
            Controls.Add(txtPrecionar);
            Controls.Add(label3);
            Controls.Add(btnConteo);
            Controls.Add(label2);
            Controls.Add(txtAgregar);
            Controls.Add(btnAgregar);
            Controls.Add(lbxAgregar);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ListBox lbxAgregar;
        private Button btnAgregar;
        private TextBox txtAgregar;
        private Label label2;
        private Button btnConteo;
        private Label label3;
        private TextBox txtPrecionar;
        private Button btnPrecionar;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Button btnFecha;
    }
}