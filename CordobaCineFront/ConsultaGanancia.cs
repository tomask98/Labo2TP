
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineCordobaBack.Entidades;
using Newtonsoft.Json;
using CordobaCineBack.Fachada.Interfaz;
using CordobaCineBack.Fachada;
using CordobaCineFront.Cliente;
using static System.Net.WebRequestMethods;

namespace CineCordobaFront.Presentacion
{
    public partial class ConsultaGanancia : Form
    {
        private IAplicacion oAplicacion;
        public ConsultaGanancia(FabricaAplicacion oFabrica)
        {
            InitializeComponent();
            oAplicacion = oFabrica.CrearAplicacion();

        }

        private async void ConsultaGanancia_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarCombo1();
        }
        private async Task CargarCombo()
        {
            string url = "https://localhost:7273/Sucursales";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Sucursales> listsuc = JsonConvert.DeserializeObject<List<Sucursales>>(data);


            cboSucursal.DataSource = listsuc;
            cboSucursal.ValueMember = "Id_sucursal";
            cboSucursal.DisplayMember = "Nombre_Sucursal";
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;




        }

        private async Task CargarCombo1()
        {
            string url = "https://localhost:7273/Peliculas";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Peliculas> listpel = JsonConvert.DeserializeObject<List<Peliculas>>(data);


            cboPelicula.DataSource = listpel;
            cboPelicula.ValueMember = "Id_pelicula";
            cboPelicula.DisplayMember = "Nombre_pelicula";
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {

            int sucursal = Convert.ToInt32(cboSucursal.SelectedValue);
            int pelicula = Convert.ToInt32(cboPelicula.SelectedValue);

            await ObtenerConsultaGanancia(sucursal, pelicula);


        }
        private async Task ObtenerConsultaGanancia(int sucursal, int pelicula)
        {
            string url = "https://localhost:7273/Ganancia?sucursal=" + sucursal.ToString() + "&peliculas=" + pelicula.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Comprobantes> lstcomp;
            lstcomp = JsonConvert.DeserializeObject<List<Comprobantes>>(data);

               
            foreach (Comprobantes oComprobante in lstcomp)
            {
                dataGridView1.Rows.Add(new object[] { oComprobante.Sucursal.Nombre_Sucursal,
                                                       oComprobante.Detalle.Funciones.Pelicula.Nombre_pelicula, //porque no andaaaaaa
                                                        oComprobante.Detalle.Precio});





            }

        }
    }







}


