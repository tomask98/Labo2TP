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


    }
}
