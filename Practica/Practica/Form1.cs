using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var club1 = new Equipo();
            club1.Nombre = "Allan";
            club1.Club = "Motagua";
            club1.Posicion = "Defensa";

            var club2 = new Equipo();
            club2.Nombre = "Cristian";
            club2.Club = "Olimpia";
            club2.Posicion = "Portero";

            var listadeJugadores = new List<Equipo>();
            listadeJugadores.Add(club1);
            listadeJugadores.Add(club2);

            foreach (var A in listadeJugadores)
            {
                MessageBox.Show(A.Nombre +"  " + A.Posicion + "  " + A.Club);
            }

        }
    }
}
