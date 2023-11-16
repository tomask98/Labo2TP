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

    }
}
