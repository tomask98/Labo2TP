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
            button2 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ColId = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColGenero = new DataGridViewTextBoxColumn();
            ColClasificacion = new DataGridViewTextBoxColumn();
            ColIdioma = new DataGridViewTextBoxColumn();
            ColEntradas = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(886, 500);
            button1.Name = "button1";
            button1.Size = new Size(62, 28);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(661, 137);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColPelicula, ColGenero, ColClasificacion, ColIdioma, ColEntradas });
            dataGridView1.Location = new Point(130, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(714, 226);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(130, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 182);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 38);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 2;
            label1.Text = "Vacacion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 23);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(183, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 112);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 5;
            label2.Text = "Genero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 57);
            label3.Name = "label3";
            label3.Size = new Size(102, 16);
            label3.TabIndex = 6;
            label3.Text = "verano/invierno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 440);
            label4.Name = "label4";
            label4.Size = new Size(480, 15);
            label4.TabIndex = 4;
            label4.Text = "Esta consulta traera las peliculas mas vistas durante las vacaciones de verano o de invieno ";
            // 
            // ColId
            // 
            ColId.HeaderText = "idCol";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(381, 458);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultarVacaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(960, 540);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarVacaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funciones en vacaciones";
            Load += FrmConsultarVacaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColGenero;
        private DataGridViewTextBoxColumn ColClasificacion;
        private DataGridViewTextBoxColumn ColIdioma;
        private DataGridViewTextBoxColumn ColEntradas;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private PictureBox pictureBox1;
    }
}