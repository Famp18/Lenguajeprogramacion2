namespace WinFormsApp1
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            programasToolStripMenuItem = new ToolStripMenuItem();
            formulario2ToolStripMenuItem = new ToolStripMenuItem();
            formulario3ToolStripMenuItem = new ToolStripMenuItem();
            formulario4ToolStripMenuItem = new ToolStripMenuItem();
            fOrmulario5ToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            BtnHola = new Button();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(855, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programasToolStripMenuItem, salirToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formulario2ToolStripMenuItem, formulario3ToolStripMenuItem, formulario4ToolStripMenuItem, fOrmulario5ToolStripMenuItem });
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new Size(163, 26);
            programasToolStripMenuItem.Text = "Programas";
            // 
            // formulario2ToolStripMenuItem
            // 
            formulario2ToolStripMenuItem.Name = "formulario2ToolStripMenuItem";
            formulario2ToolStripMenuItem.Size = new Size(224, 26);
            formulario2ToolStripMenuItem.Text = "Formulario 2";
            formulario2ToolStripMenuItem.Click += formulario2ToolStripMenuItem_Click;
            // 
            // formulario3ToolStripMenuItem
            // 
            formulario3ToolStripMenuItem.Name = "formulario3ToolStripMenuItem";
            formulario3ToolStripMenuItem.Size = new Size(224, 26);
            formulario3ToolStripMenuItem.Text = "Formulario 3";
            formulario3ToolStripMenuItem.Click += formulario3ToolStripMenuItem_Click;
            // 
            // formulario4ToolStripMenuItem
            // 
            formulario4ToolStripMenuItem.Name = "formulario4ToolStripMenuItem";
            formulario4ToolStripMenuItem.Size = new Size(224, 26);
            formulario4ToolStripMenuItem.Text = "Formulario 4";
            formulario4ToolStripMenuItem.Click += formulario4ToolStripMenuItem_Click;
            // 
            // fOrmulario5ToolStripMenuItem
            // 
            fOrmulario5ToolStripMenuItem.Name = "fOrmulario5ToolStripMenuItem";
            fOrmulario5ToolStripMenuItem.Size = new Size(224, 26);
            fOrmulario5ToolStripMenuItem.Text = "Formulario 5";
            fOrmulario5ToolStripMenuItem.Click += fOrmulario5ToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(163, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(93, 73);
            label1.Name = "label1";
            label1.Size = new Size(641, 33);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido al formulario de Francisco Mateo SD-1820045";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(34, 150);
            label2.Name = "label2";
            label2.Size = new Size(779, 31);
            label2.TabIndex = 2;
            label2.Text = "Para Visualizar los proyectos dar clip en Opciones y luego en programas";
            // 
            // BtnHola
            // 
            BtnHola.BackColor = SystemColors.GradientActiveCaption;
            BtnHola.ForeColor = SystemColors.ActiveCaptionText;
            BtnHola.Location = new Point(348, 324);
            BtnHola.Name = "BtnHola";
            BtnHola.Size = new Size(94, 29);
            BtnHola.TabIndex = 3;
            BtnHola.Text = "Hola";
            BtnHola.UseVisualStyleBackColor = false;
            BtnHola.Click += BtnHola_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(348, 287);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 4;
            label3.Text = "Mandato 10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(34, 222);
            label4.Name = "label4";
            label4.Size = new Size(792, 25);
            label4.TabIndex = 5;
            label4.Text = "Al momento que visialice cada pestaña La tarea esta sonbolizada con el titutlo de mandatos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(855, 475);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnHola);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem programasToolStripMenuItem;
        private ToolStripMenuItem formulario2ToolStripMenuItem;
        private ToolStripMenuItem formulario3ToolStripMenuItem;
        private ToolStripMenuItem formulario4ToolStripMenuItem;
        private ToolStripMenuItem fOrmulario5ToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Button BtnHola;
        private Label label3;
        private Label label4;
    }
}
