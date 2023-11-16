using CordobaCineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaCineBack.Fachada
{
    public abstract class FabricaAplicacion
    {
        public abstract IAplicacion CrearAplicacion();
    }
}
