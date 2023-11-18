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
        List<Comprobantes> ObtenerConsultaUnoFiltrada(DateTime fechaDesde, string ts1, string ts2, string ts3, string ts4,
                                   string ts5, string ts6, string g1, string g2, string g3, string g4, string g5, string g6);
    }
}
