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
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string s)
        {
            this.lblNombre.Text = s;
        }

        public void ActualizarImagen(string s)
        {
            //this.picFoto.Image = new Bitmap(s);
            this.picFoto.ImageLocation = s;
        }
    }
}
