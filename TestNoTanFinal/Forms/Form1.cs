using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public delegate void AsignarNombre(string s);

    public partial class Form1 : Form
    {
        public event AsignarNombre Asignar;
        //public AsignarNombre an;
        public frmMostrar fm;
        public frmIngresar fi;

        public Form1()
        {
            InitializeComponent();
        }

        public void ActivarEvento(string s)
        {
            this.Asignar(s);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fi = new frmIngresar();
            this.fi.Show(this);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fm = new frmMostrar();
            //this.an = new AsignarNombre(fm.ActualizarNombre);
            //this.Asignar += fm.ActualizarNombre;
            this.fm.Show(this);
        }
    }
}
