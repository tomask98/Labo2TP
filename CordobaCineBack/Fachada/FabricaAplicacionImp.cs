using CordobaCineBack.Fachada.Implementacion;
using CordobaCineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaCineBack.Fachada
{
    public class FabricaAplicacionImp : FabricaAplicacion
    {
        public override IAplicacion CrearAplicacion()
        {
            return new Aplicacion();
        }
    }
}
