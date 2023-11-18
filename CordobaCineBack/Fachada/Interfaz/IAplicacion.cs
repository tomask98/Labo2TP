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

        public List<DetalleComprobante> ObtenerConsultaVacacion(int genero, string vacacion);

        public List<Sucursales> TraerSucursales();
        public List<Peliculas> traerPeliculas();

        public List<Comprobantes> ConsultarGanancia(int sucursal, int pelicula);
        public List<Comprobantes> TraerComprobantes(DateTime fechaDesde, string ts1, string ts2, string ts3, string ts4,
                                  string ts5, string ts6, string g1, string g2, string g3, string g4, string g5, string g6);
    }
}
