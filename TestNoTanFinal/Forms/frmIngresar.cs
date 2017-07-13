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
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).Asignar += ((Form1)this.Owner).fm.ActualizarNombre;
            ((Form1)this.Owner).ActivarEvento(this.txtNombre.Text);
            ((Form1)this.Owner).Asignar -= ((Form1)this.Owner).fm.ActualizarNombre;

            ((Form1)this.Owner).Asignar += ((Form1)this.Owner).fm.ActualizarImagen;
            ((Form1)this.Owner).ActivarEvento(this.openFileDialog1.FileName);
            ((Form1)this.Owner).Asignar -= ((Form1)this.Owner).fm.ActualizarImagen;
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.Title = "Select a Image";
            openFileDialog1.ShowDialog();
            // Show the Dialog.
            // If the user clicked OK in the dialog and
             //a .CUR file was selected, open it.
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    this._path = openFileDialog1.FileName;
            //}
        }
    }
}
