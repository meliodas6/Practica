using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class EquipoBL
    {
        public BindingList<Equipo> ListadeJugadores { get; set; }

        public EquipoBL()
        {
            ListadeJugadores = new BindingList<Equipo>();
            CargarDatos();
        }

        private void CargarDatos()
        { 

            var posicion1 = new Posicion(1, "Defensa");
            var posicion2 = new Posicion(2, "Portero");
            var posicion3 = new Posicion(3, "Volante");

            var jugadores1 = new Equipo(1, "Allan Ordonez", posicion1);
            var jugadores2 = new Equipo(2, "Cristian Ordonez", posicion3);
            var jugadores3 = new Equipo(3, "Cynthia Pleites", posicion2);

            ListadeJugadores.Add(jugadores1);
            ListadeJugadores.Add(jugadores2);
            ListadeJugadores.Add(jugadores3);
        }
    }
}
