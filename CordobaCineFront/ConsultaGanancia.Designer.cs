namespace CineCordobaFront.Presentacion
{
    partial class ConsultaGanancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaGanancia));
            lblTitulo = new Label();
            lblPelicula = new Label();
            lblSucursal = new Label();
            dataGridView1 = new DataGridView();
            ColNomSuc = new DataGridViewTextBoxColumn();
            ColNomPel = new DataGridViewTextBoxColumn();
            ColGanancias = new DataGridViewTextBoxColumn();
            cboPelicula = new ComboBox();
            cboSucursal = new ComboBox();
            btnSalir = new Button();
            btnConsultar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(400, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(169, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar ganancias";
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.BackColor = Color.Transparent;
            lblPelicula.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPelicula.Location = new Point(182, 90);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(198, 19);
            lblPelicula.TabIndex = 1;
            lblPelicula.Text = "Seleccione una pelicula";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.BackColor = Color.Transparent;
            lblSucursal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSucursal.Location = new Point(645, 90);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(196, 19);
            lblSucursal.TabIndex = 2;
            lblSucursal.Text = "Seleccione una sucursal";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNomSuc, ColNomPel, ColGanancias });
            dataGridView1.Location = new Point(130, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(711, 211);
            dataGridView1.TabIndex = 3;
            // 
            // ColNomSuc
            // 
            ColNomSuc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNomSuc.HeaderText = "Nombre sucursal";
            ColNomSuc.Name = "ColNomSuc";
            ColNomSuc.ReadOnly = true;
            // 
            // ColNomPel
            // 
            ColNomPel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNomPel.HeaderText = "Nombre pelicula";
            ColNomPel.Name = "ColNomPel";
            ColNomPel.ReadOnly = true;
            // 
            // ColGanancias
            // 
            ColGanancias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColGanancias.HeaderText = "Ganancia";
            ColGanancias.Name = "ColGanancias";
            ColGanancias.ReadOnly = true;
            // 
            // cboPelicula
            // 
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(182, 133);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(170, 23);
            cboPelicula.TabIndex = 4;
            cboPelicula.SelectedIndexChanged += cboPelicula_SelectedIndexChanged;
            // 
            // cboSucursal
            // 
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(645, 133);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(174, 23);
            cboSucursal.TabIndex = 5;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 448);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 41);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(830, 448);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(102, 41);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-46, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ConsultaGanancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 501);
            Controls.Add(btnConsultar);
            Controls.Add(btnSalir);
            Controls.Add(cboSucursal);
            Controls.Add(cboPelicula);
            Controls.Add(dataGridView1);
            Controls.Add(lblSucursal);
            Controls.Add(lblPelicula);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "ConsultaGanancia";
            Text = "ConsultaGanancia";
            TopMost = true;
            Load += ConsultaGanancia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPelicula;
        private Label lblSucursal;
        private DataGridView dataGridView1;
        private ComboBox cboPelicula;
        private ComboBox cboSucursal;
        private Button btnSalir;
        private Button btnConsultar;
        private DataGridViewTextBoxColumn ColNomSuc;
        private DataGridViewTextBoxColumn ColNomPel;
        private DataGridViewTextBoxColumn ColGanancias;
        private PictureBox pictureBox1;
    }
}