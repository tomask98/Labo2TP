
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

namespace CineFront.Presentacion
{
    public partial class FrmConsultarVacaciones : Form
    {
        private IAplicacion oAplicacion;
        public FrmConsultarVacaciones( FabricaAplicacion oFabrica)
        {
            
            InitializeComponent();
            oAplicacion = oFabrica.CrearAplicacion();
            
        }

        private void FrmConsultarVacaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
