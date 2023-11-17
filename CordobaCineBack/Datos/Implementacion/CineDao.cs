using CineCordobaBack.Entidades;
using CordobaCineBack.Datos.Interfaz;
using CordobaCineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaCineBack.Datos.Implementacion
{
    public class CineDao : ICineDao
    {
        public List<Generos> ObtenerGeneros()
        {
            List<Generos> lGeneros = new List<Generos>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_generos");
            foreach (DataRow fila in tabla.Rows)
            {

                int id_genero= int.Parse(fila["id_genero"].ToString());
                string nomb_genero = fila["genero"].ToString();
                Generos g = new Generos(id_genero,nomb_genero);
                lGeneros.Add(g);
            }
            return lGeneros;
        }

        public List<DetalleComprobante> ObtenerConsultaVacacion(int genero,string vacacion)
        {
            List<DetalleComprobante> ldetalle = new List<DetalleComprobante>();
            List<Parametro> lparam = new List<Parametro>();
            Parametro paramVacaciones = new Parametro("@opcion", vacacion);
            Parametro paramGenero = new Parametro("@genero", genero);
            lparam.Add(paramGenero);
            lparam.Add(paramVacaciones);

            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTabla("sp_funciones_mas_vendidas", lparam);

            foreach (DataRow fila in tabla.Rows)
            {
                DetalleComprobante oDetalle = new DetalleComprobante();
                Funciones ofuncion = new Funciones();

                // Corregir la asignación de la cantidad de entradas vendidas
                ofuncion.FuncionId = Convert.ToInt32(fila["Cantidad de entradas vendidas"]);

                // Corregir la asignación del id de la película
                ofuncion.Pelicula.Id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
                ofuncion.Pelicula.Clasificacion.Clasificacion = fila["clasificacion"].ToString();
                ofuncion.Pelicula.Nombre_pelicula = fila["nombre_pelicula"].ToString();
                ofuncion.Pelicula.Genero.Genero = fila["genero"].ToString();
                ofuncion.Pelicula.Idioma.Idioma = fila["idioma"].ToString();

                oDetalle.Funciones = ofuncion;
                ldetalle.Add(oDetalle);

            }
            return ldetalle;
        }

        public List<Sucursales> obtenerSucursales()
        {
            List<Sucursales> lSucursal = new List<Sucursales>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("consultarSucursales");
            foreach (DataRow fila in tabla.Rows)
            {

                int id_sucursal = int.Parse(fila["id_sucursal"].ToString());
                string nomb_sucursal = fila["nombre_sucursal"].ToString();
                Sucursales s = new Sucursales(id_sucursal, nomb_sucursal);
                lSucursal.Add(s);
            }
            return lSucursal;
        }

        public List<Peliculas> obtenerPeliculas()
        {
            List<Peliculas> lSucursal = new List<Peliculas>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_peliculas");
            foreach (DataRow fila in tabla.Rows)
            {

                int id_pelicula = int.Parse(fila["id_pelicula"].ToString());
                string nomb_pelicula = fila["nombre_pelicula"].ToString();
                Peliculas s = new Peliculas(id_pelicula, nomb_pelicula);
                lSucursal.Add(s);
            }
            return lSucursal;
        }

        public List<Comprobantes> obtenerConsultarGanancia(int sucursal, int pelicula)
        {
            List<Comprobantes> ldetalle = new List<Comprobantes>();
            List<Parametro> lparam = new List<Parametro>();
            Parametro paramSucursal = new Parametro("@id_sucursal", sucursal);
            Parametro paramPelicula = new Parametro("@id_pelicula", pelicula);
            lparam.Add(paramSucursal);
            lparam.Add(paramPelicula);
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaTabla("gananciaXpelicula_sucursalesq", lparam);
            foreach (DataRow fila in tabla.Rows)
            {

                Comprobantes oComprobante = new Comprobantes();
                //DetalleComprobante oDetalle = new DetalleComprobante();
                //Funciones oFunciones = new Funciones();
                DetalleComprobante oDetalle = new DetalleComprobante();
                Funciones ofuncion = new Funciones();


                ofuncion.Pelicula = new Peliculas();
                oComprobante.Sucursal = new Sucursales();


                oComprobante.Sucursal.Nombre_Sucursal = (fila["nombre_sucursal"].ToString());

                ofuncion.Pelicula.Nombre_pelicula = (fila["nombre_pelicula"].ToString());

                oDetalle.Precio= (Convert.ToDecimal(fila["ganancia total"]));

                
                oDetalle.Funciones = ofuncion;
                oComprobante.Detalle=oDetalle;

                ldetalle.Add(oComprobante);
            }
            return ldetalle;
        }
    }
}
