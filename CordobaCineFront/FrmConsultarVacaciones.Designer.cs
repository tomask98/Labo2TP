namespace CineFront.Presentacion
{
    partial class FrmConsultarVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarVacaciones));
            button1 = new Button();
            btnBuscar = new Button();
            dgvconsulta = new DataGridView();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColGenero = new DataGridViewTextBoxColumn();
            ColClasificacion = new DataGridViewTextBoxColumn();
            ColIdioma = new DataGridViewTextBoxColumn();
            ColEntradas = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            cboGenero = new ComboBox();
            txtVacaciones = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvconsulta).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(984, 526);
            button1.Name = "button1";
            button1.Size = new Size(99, 37);
            button1.TabIndex = 0;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(745, 149);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 25);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvconsulta
            // 
            dgvconsulta.AllowUserToAddRows = false;
            dgvconsulta.AllowUserToDeleteRows = false;
            dgvconsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvconsulta.BackgroundColor = Color.WhiteSmoke;
            dgvconsulta.BorderStyle = BorderStyle.None;
            dgvconsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvconsulta.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColGenero, ColClasificacion, ColIdioma, ColEntradas });
            dgvconsulta.Location = new Point(149, 225);
            dgvconsulta.Name = "dgvconsulta";
            dgvconsulta.ReadOnly = true;
            dgvconsulta.RowTemplate.Height = 25;
            dgvconsulta.Size = new Size(856, 241);
            dgvconsulta.TabIndex = 2;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            // 
            // ColGenero
            // 
            ColGenero.HeaderText = "Genero";
            ColGenero.Name = "ColGenero";
            ColGenero.ReadOnly = true;
            // 
            // ColClasificacion
            // 
            ColClasificacion.HeaderText = "Clasificacion";
            ColClasificacion.Name = "ColClasificacion";
            ColClasificacion.ReadOnly = true;
            // 
            // ColIdioma
            // 
            ColIdioma.HeaderText = "Idioma";
            ColIdioma.Name = "ColIdioma";
            ColIdioma.ReadOnly = true;
            // 
            // ColEntradas
            // 
            ColEntradas.HeaderText = "Cantidad de entradas vendidas";
            ColEntradas.Name = "ColEntradas";
            ColEntradas.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboGenero);
            groupBox1.Controls.Add(txtVacaciones);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(149, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 194);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 61);
            label3.Name = "label3";
            label3.Size = new Size(102, 16);
            label3.TabIndex = 6;
            label3.Text = "verano/invierno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 119);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 5;
            label2.Text = "Género";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(209, 115);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(138, 24);
            cboGenero.TabIndex = 4;
            // 
            // txtVacaciones
            // 
            txtVacaciones.Location = new Point(209, 41);
            txtVacaciones.Name = "txtVacaciones";
            txtVacaciones.Size = new Size(321, 23);
            txtVacaciones.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 41);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 2;
            label1.Text = "Vacaciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(199, 487);
            label4.Name = "label4";
            label4.Size = new Size(625, 17);
            label4.TabIndex = 4;
            label4.Text = "Esta consulta traera las peliculas mas vistas durante las vacaciones de verano o de invieno ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-83, 396);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultarVacaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1097, 576);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(dgvconsulta);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmConsultarVacaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funciones en vacaciones";
            Load += FrmConsultarVacaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvconsulta).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnBuscar;
        private DataGridView dgvconsulta;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private ComboBox cboGenero;
        private TextBox txtVacaciones;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColGenero;
        private DataGridViewTextBoxColumn ColClasificacion;
        private DataGridViewTextBoxColumn ColIdioma;
        private DataGridViewTextBoxColumn ColEntradas;
        private PictureBox pictureBox1;
    }
}