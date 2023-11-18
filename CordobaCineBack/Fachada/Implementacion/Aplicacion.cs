using CineCordobaBack.Entidades;
using CordobaCineBack.Datos.Implementacion;
using CordobaCineBack.Datos.Interfaz;
using CordobaCineBack.Entidades;
using CordobaCineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaCineBack.Fachada.Implementacion
{
    public class Aplicacion:IAplicacion
    {
        private ICineDao cineDao;

        public Aplicacion()
        {
            cineDao = new CineDao();
        }

        public List<Generos> TraerGeneros()
        {
            return cineDao.ObtenerGeneros();
        }
        public List<DetalleComprobante> ObtenerConsultaVacacion(int genero, string vacacion)
        {
            return cineDao.ObtenerConsultaVacacion(genero, vacacion);
        }

        public List<Sucursales> TraerSucursales()
        {
            return cineDao.obtenerSucursales();
        }

        public List<Peliculas> traerPeliculas()
        {
            return cineDao.obtenerPeliculas();
        }

        public List<Comprobantes> ConsultarGanancia(int sucursal, int pelicula)
        {
            return cineDao.obtenerConsultarGanancia(sucursal,pelicula);
        }
        public List<Comprobantes> TraerComprobantes(DateTime fechaDesde, string ts1, string ts2, string ts3, string ts4,
                                   string ts5, string ts6, string g1, string g2, string g3, string g4, string g5, string g6)
        {
            return cineDao.ObtenerConsultaUnoFiltrada(fechaDesde, ts1, ts2, ts3, ts4, ts5, ts6, g1, g2, g3, g4, g5, g6);
        }
    }
}
