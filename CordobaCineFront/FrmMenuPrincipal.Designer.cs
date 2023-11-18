namespace CordobaCineFront.Presentación
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            menuStrip1 = new MenuStrip();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            consulta1ToolStripMenuItem = new ToolStripMenuItem();
            consulta2ToolStripMenuItem = new ToolStripMenuItem();
            consulta3ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(914, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consulta1ToolStripMenuItem, consulta2ToolStripMenuItem, consulta3ToolStripMenuItem });
            consultasToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(74, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consulta1ToolStripMenuItem
            // 
            consulta1ToolStripMenuItem.Name = "consulta1ToolStripMenuItem";
            consulta1ToolStripMenuItem.Size = new Size(137, 22);
            consulta1ToolStripMenuItem.Text = "Consulta 1";
            consulta1ToolStripMenuItem.Click += consulta1ToolStripMenuItem_Click;
            // 
            // consulta2ToolStripMenuItem
            // 
            consulta2ToolStripMenuItem.Name = "consulta2ToolStripMenuItem";
            consulta2ToolStripMenuItem.Size = new Size(137, 22);
            consulta2ToolStripMenuItem.Text = "Consulta 2";
            consulta2ToolStripMenuItem.Click += consulta2ToolStripMenuItem_Click;
            // 
            // consulta3ToolStripMenuItem
            // 
            consulta3ToolStripMenuItem.Name = "consulta3ToolStripMenuItem";
            consulta3ToolStripMenuItem.Size = new Size(137, 22);
            consulta3ToolStripMenuItem.Text = "Consulta 3 ";
            consulta3ToolStripMenuItem.Click += consulta3ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 119);
            label1.Name = "label1";
            label1.Size = new Size(197, 36);
            label1.TabIndex = 1;
            label1.Text = "Participantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(47, 251);
            label2.Name = "label2";
            label2.Size = new Size(311, 184);
            label2.TabIndex = 2;
            label2.Text = "Köhler Tomas Eduardo - 113845\r\n\r\nMedina Claribel - 113879\r\n\r\nRodriguez Lisandro - 111161\r\n\r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(805, 418);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 33);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(427, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(273, 201);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 480);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem consulta1ToolStripMenuItem;
        private ToolStripMenuItem consulta2ToolStripMenuItem;
        private ToolStripMenuItem consulta3ToolStripMenuItem;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private PictureBox pictureBox2;
    }
}