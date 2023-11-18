using CineCordobaBack.Entidades;
using CordobaCineBack.Entidades;
using CordobaCineBack.Fachada;
using CordobaCineBack.Fachada.Interfaz;
using CordobaCineFront.Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CordobaCineApp.Presentacion
{
    public partial class FrmConsultaGeneroTipoSala : Form
    {
        private IAplicacion oAplicacion;
        public FrmConsultaGeneroTipoSala(FabricaAplicacion oFabrica)
        {
            InitializeComponent();
            oAplicacion = oFabrica.CrearAplicacion();

        }
        private void FrmConsultaGeneroTipoSala_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            dtpFechaDesde.CustomFormat = "yyyy/MM/dd";  //mostrara solo el nombre del mes
            dtpFechaDesde.ShowUpDown = true;  //evita que se muestre el calendario desplegable 
            dtpFechaDesde.Value = DateTime.Now;

            dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            dtpFechaHasta.CustomFormat = "yyyy/MM/dd";  //mostrara solo el nombre del mes
            dtpFechaHasta.ShowUpDown = true;  //evita que se muestre el calendario desplegable 
            dtpFechaHasta.Value = DateTime.Now;


        }
        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpFechaDesde.Value;
            string fechaFormateada = fechaDesde.ToString("yyyy-MM-dd");

            string ts1;
            string ts2;
            string ts3;
            string ts4;
            string ts5;
            string ts6;
            string g1;
            string g2;
            string g3;
            string g4;
            string g5;
            string g6;




            if (cbox2D.Checked)
            {
                ts1 = "2D";
            }
            else { ts1 = "null"; }
            if (cbox2DComfort.Checked)
            {
                ts2 = "2D Confort";
            }
            else { ts2 = "null"; }
            if (cbox3D.Checked)
            {
                ts3 = "3D";
            }
            else { ts3 = "null"; }
            if (cbox3DComfort.Checked)
            {
                ts4 = "3D confort";
            }
            else { ts4 = "null"; }
            if (cboxPremium.Checked)
            {
                ts5 = "Premium";
            }
            else { ts5 = "null"; }
            if (cboxImax.Checked)
            {
                ts6 = "IMAX";
            }
            else { ts6 = "null"; }

            //Tipos de generos a discriminar
            if (cboxAccion.Checked)
            {
                g1 = "accion";
            }
            else { g1 = "null"; }
            if (cboxComedia.Checked)
            {
                g2 = "comedia";
            }
            else { g2 = "null"; }
            if (cboxDrama.Checked)
            {
                g3 = "drama";
            }
            else { g3 = "null"; }
            if (cboxDocumental.Checked)
            {
                g4 = "documental";
            }
            else { g4 = "null"; }
            if (cboxFiccion.Checked)
            {
                g5 = "ciencia ficcion";
            }
            else { g5 = "null"; }
            if (cboxTerror.Checked)
            {
                g6 = "terror";
            }
            else { g6 = "null"; }

            dgvConsultaClari.Rows.Clear();

            await ConsultarComprobanteFiltrado(fechaFormateada, ts1, ts2, ts3, ts4, ts5, ts6, g1, g2, g3, g4, g5, g6);


        }

        private async Task ConsultarComprobanteFiltrado(string fechaFormateada, string ts1, string ts2, string ts3, string ts4, string ts5, string ts6, string g1, string g2, string g3, string g4, string g5, string g6)
        {



            string url = "https://localhost:7273/comprobantesFiltrados?fechaDesde=" + fechaFormateada +
             "&ts1=" + ts1 +
             "&ts2=" + ts2 +
             "&ts3=" + ts3 +
             "&ts4=" + ts4 +
             "&ts5=" + ts5 +
             "&ts6=" + ts6 +
             "&g1=" + g1 +
             "&g2=" + g2 +
             "&g3=" + g3 +
             "&g4=" + g4 +
             "&g5=" + g5 +
             "&g6=" + g6;




            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Comprobantes> lstcomp;
            lstcomp = JsonConvert.DeserializeObject<List<Comprobantes>>(data);

            foreach (Comprobantes comp in lstcomp)
            {

                dgvConsultaClari.Rows.Add(new object[]
                {
                 comp.Vendedor.Nombre,
                 comp.Cliente.Nombre,
                 comp.Detalle.Funciones.SalasId.TipoSala.Tipo,
                 comp.Detalle.Funciones.Pelicula.Nombre_pelicula,
                 comp.Detalle.Funciones.Fecha,
                 comp.Detalle.Funciones.Pelicula.Genero.Genero
                });
            }



        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
