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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(297, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(227, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar ganancias";
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPelicula.Location = new Point(41, 90);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(170, 21);
            lblPelicula.TabIndex = 1;
            lblPelicula.Text = "Seleccione una pelicula";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSucursal.Location = new Point(578, 90);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(174, 21);
            lblSucursal.TabIndex = 2;
            lblSucursal.Text = "Seleccione una sucursal";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNomSuc, ColNomPel, ColGanancias });
            dataGridView1.Location = new Point(41, 171);
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
            cboPelicula.Location = new Point(41, 133);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(170, 23);
            cboPelicula.TabIndex = 4;
            cboPelicula.SelectedIndexChanged += cboPelicula_SelectedIndexChanged;
            // 
            // cboSucursal
            // 
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(578, 133);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(174, 23);
            cboSucursal.TabIndex = 5;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(41, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 41);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(650, 388);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(102, 41);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // ConsultaGanancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 441);
            Controls.Add(btnConsultar);
            Controls.Add(btnSalir);
            Controls.Add(cboSucursal);
            Controls.Add(cboPelicula);
            Controls.Add(dataGridView1);
            Controls.Add(lblSucursal);
            Controls.Add(lblPelicula);
            Controls.Add(lblTitulo);
            Name = "ConsultaGanancia";
            Text = "ConsultaGanancia";
            Load += ConsultaGanancia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}