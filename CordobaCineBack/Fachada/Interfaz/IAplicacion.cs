using CineCordobaBack.Entidades;
using CordobaCineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaCineBack.Fachada.Interfaz
{
    public interface IAplicacion
    {
        public List<Generos>TraerGeneros();
    }
}
