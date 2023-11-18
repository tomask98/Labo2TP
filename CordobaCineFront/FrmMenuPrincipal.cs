using CineCordobaFront.Presentacion;
using CineFront.Presentacion;
using CordobaCineApp.Presentacion;
using CordobaCineBack.Fachada;
using CordobaCineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CordobaCineFront.Presentación
{
    public partial class FrmMenuPrincipal : Form
    {
        private IAplicacion oApp;
        public FrmConsultaGeneroTipoSala oFrmGenero;
        public FrmConsultarVacaciones oFrmVacaciones;
        public ConsultaGanancia oFrmGanancia;
        public FabricaAplicacion oFabrica;


        public FrmMenuPrincipal(FabricaAplicacion oFabrica)
        {
            InitializeComponent();
            oApp = oFabrica.CrearAplicacion();
            oFrmGenero = new FrmConsultaGeneroTipoSala(oFabrica);
            oFrmVacaciones = new FrmConsultarVacaciones(oFabrica);
            oFrmGanancia = new ConsultaGanancia(oFabrica);
            this.oFabrica = oFabrica;


        }


        private async Task RealizarOperacionAsincrona()
        {
            await Task.Delay(3000);
        }

        private async Task consulta2ToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            await RealizarOperacionAsincrona();

            if (oFrmVacaciones.IsDisposed)
            { oFrmVacaciones = new FrmConsultarVacaciones(oFabrica); }

            oFrmVacaciones.Show();
        }



        private async void consulta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RealizarOperacionAsincrona();

            if (oFrmVacaciones.IsDisposed)
            { oFrmVacaciones = new FrmConsultarVacaciones(oFabrica); }

            oFrmVacaciones.Show();
        }

        private async void consulta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RealizarOperacionAsincrona();
            if (oFrmGenero.IsDisposed)
            { oFrmGenero = new FrmConsultaGeneroTipoSala(oFabrica); }

            oFrmGenero.Show();
        }

        private async void consulta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RealizarOperacionAsincrona();
            if (oFrmGanancia.IsDisposed)
            { oFrmGanancia = new ConsultaGanancia(oFabrica); }

            oFrmGanancia.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
