using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Posicion Puesto { get; set; }
        public int PuestoId { get; set; }

        public Equipo(int id, string nombre, Posicion puesto)
        {
            Id = id;
            Nombre = nombre;
            Puesto = puesto;
            PuestoId = puesto.Id;
        }

    }
}
