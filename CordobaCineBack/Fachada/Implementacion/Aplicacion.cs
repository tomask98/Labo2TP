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
    }
}
