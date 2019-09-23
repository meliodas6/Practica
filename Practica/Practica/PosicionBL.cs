using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class PosicionBL
    {
        public BindingList<Posicion> ListadePosiciones { get; set; }

        public PosicionBL()
        {
            ListadePosiciones = new BindingList<Posicion>();
            CargarDatos();


        }

        private void CargarDatos()
        {
            var posicion1 = new Posicion(1, "Defensa");
            var posicion2 = new Posicion(2, "Portero");
            var posicion3 = new Posicion(3, "Volante");

            ListadePosiciones.Add(posicion1);
            ListadePosiciones.Add(posicion2);
            ListadePosiciones.Add(posicion3);
        }
    }
}
