using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerproyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncomprobar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtedad.Text);

            //estreuctura de control

            //IF CONDICIONAL. si se cumple se ejecuta el bloque de codigo.
            if (edad >= 18)
            {
                MessageBox.Show("Bienvenido, eres responsable de tus acciones");


            if (edad <= 17)
                    MessageBox.Show("invalido");
            }
        }
            
        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
