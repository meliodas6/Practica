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
    public partial class Menu : Form
    {
        EquipoBL _equipoBL;
        PosicionBL _posicionBL;
        public Menu()
        {
            InitializeComponent();

            _equipoBL = new EquipoBL();
            _posicionBL = new PosicionBL();
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formJugadores = new Form1();
            formJugadores.MdiParent = this;
            formJugadores.cargarDatos(_equipoBL, _posicionBL);
            formJugadores.Show();
        }
    }
}
