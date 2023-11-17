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
        List<Sucursales> obtenerSucursales();
        List<Peliculas> obtenerPeliculas();
        List<Comprobantes> obtenerConsultarGanancia(int sucursal, int pelicula);
    }
}
