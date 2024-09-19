using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialNo._1
{
    public partial class Form3 : Form
    {
        public Form3(string nombre, string edad, string sexo, string signo, string prediccion, string numeros)
        {
            InitializeComponent();
            label7.Text = nombre;
            label8.Text = edad;
            label9.Text = sexo;
            label10.Text = signo;
            label11.Text = prediccion;
            label12.Text = numeros;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
