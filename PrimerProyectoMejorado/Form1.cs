using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyectoMejorado
{
    public partial class primerForm : Form
    {
        public primerForm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
                check = true;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;


            }

            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                check |= true;
            }
            else {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            }
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
                check = true;
            }
            else
            {
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
            }   
            if (txtDireccion.Text == "") { 
            txtDireccion.BackColor = Color.Red;
                check = true;
        }
            else
            {
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            }


            if(check == true)
            {
                return;
            }
            else
            {

                string elem = txtApellido.Text + " " + txtNombre.Text;
                lvResultado.Items.Add(elem);
                string ed = txtEdad.Text;
                lvResultado.Items.Add(ed);
                string dire  = txtDireccion.Text;
                lvResultado.Items.Add(dire);

            }


        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
