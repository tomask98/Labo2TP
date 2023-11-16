using CordobaCineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Funciones
    {
        public int FuncionId { get; set; }
        public Horarios HorarioID { get; set; }
        public DateTime Fecha { get; set; }
        public bool Subtitulo { get; set; }
        public Peliculas Pelicula { get; set; }

        
        public Salas SalasId { get; set; }

        public Funciones(int funcionesId,Horarios horarioid,DateTime fecha,bool subtitulo,Salas salaid,Peliculas pelicula)
        {
            FuncionId = funcionesId;
            HorarioID = horarioid;
            Fecha = fecha;
            Subtitulo = subtitulo;
            Pelicula = pelicula;
            SalasId = salaid;

        }
        public Funciones()
        {
            Pelicula = new Peliculas();
            

        }
    }
}
