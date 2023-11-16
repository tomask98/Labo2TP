using CineCordobaBack.Entidades;
using CordobaCineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaCineBack.Datos.Interfaz
{
    public interface ICineDao
    {
        List<Generos> ObtenerGeneros();
        public List<DetalleComprobante> ObtenerConsultaVacacion(int genero, string vacacion);
    }
}
