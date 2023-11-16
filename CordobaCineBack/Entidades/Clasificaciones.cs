using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaCineBack.Entidades
{
    public class Clasificaciones
    {
        public int Id_clasificacion { get; set; }
        public string Clasificacion { get; set; }


        public Clasificaciones()
        {
            Id_clasificacion = 0;
            Clasificacion = string.Empty;
        }

        public override string ToString()
        {
            return Clasificacion.ToString();
        }
    }
}
