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


            var equipoBL = new EquipoBL();
            listadeJugadoresBindingSource.DataSource = equipoBL.ListadeJugadores;

            var posicionBL = new PosicionBL();
            listadePosicionesBindingSource.DataSource = posicionBL.ListadePosiciones; 
        }
    }
}
