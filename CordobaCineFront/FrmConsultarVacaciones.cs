
using CineCordobaBack.Entidades;
using CordobaCineBack.Entidades;
using CordobaCineBack.Fachada;
using CordobaCineBack.Fachada.Interfaz;
using CordobaCineFront.Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace CineFront.Presentacion
{
    public partial class FrmConsultarVacaciones : Form
    {
        private IAplicacion oAplicacion;
        public FrmConsultarVacaciones(FabricaAplicacion oFabrica)
        {

            InitializeComponent();
            oAplicacion = oFabrica.CrearAplicacion();

        }

        private async void FrmConsultarVacaciones_Load(object sender, EventArgs e)
        {
            await CargarGeneroAsync();
            Limpiar();
        }

        private void Limpiar()
        {
            txtVacaciones.Text = "";
            cboGenero.SelectedValue = -1;
            dgvconsulta.Rows.Clear();
        }

        private async Task CargarGeneroAsync()
        {
            string url = "https://localhost:7273/generos";
            var DataJson = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Generos> lgenero = JsonConvert.DeserializeObject<List<Generos>>(DataJson);

            cboGenero.DataSource = lgenero;
            cboGenero.ValueMember = "id_genero";
            cboGenero.DisplayMember = "genero";
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int genero = Convert.ToInt32(cboGenero.SelectedValue);
                dgvconsulta.Rows.Clear();
                await ConsultarDetalleVacaciones(genero, txtVacaciones.Text);
            }


        }

        private bool validar()
        {
            bool v = true;
            //if (string.IsNullOrEmpty(txtVacaciones.Text))
            //{
            //    MessageBox.Show("Debe indicar en que temporada quiere realizar la busqueda", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    v = false;
            //}
            if (string.IsNullOrEmpty(txtVacaciones.Text) && txtVacaciones.Text != "verano" && txtVacaciones.Text != "invierno")
            {
                MessageBox.Show("Debe indicar si es temporada de verano o invierno", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                v = false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un genero", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                v = false;
            }
            return v;
        }

        private async Task ConsultarDetalleVacaciones(int genero, string text)
        {
            string url = "https://localhost:7273/VentasVacaciones?genero=" + genero.ToString() + "&vacaciones=" + text.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DetalleComprobante> lstdetalle;
            lstdetalle = JsonConvert.DeserializeObject<List<DetalleComprobante>>(data);

            foreach (DetalleComprobante odetalle in lstdetalle)
            {
                dgvconsulta.Rows.Add(new object[] {   odetalle.Funciones.Pelicula.Nombre_pelicula,
                                                      odetalle.Funciones.Pelicula.Genero.Genero,
                                                      odetalle.Funciones.Pelicula.Clasificacion.Clasificacion,
                                                      odetalle.Funciones.Pelicula.Idioma.Idioma,
                                                      odetalle.Funciones.FuncionId});
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
