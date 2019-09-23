using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Posicion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Posicion()
        {

        }

        public Posicion(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }

}
