using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialNo._1
{
    //CCarrasco, Nathan 
    //Herrera, Francisco
    
    public partial class Parcial1 : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        private DateTimePicker fecha;
        private int aleatorio;
        private Random random = new Random();
        private string resultadoAleatorio;
        private string prediccion;
        private string signo;

        public Parcial1()
        {
            InitializeComponent();
        }
        private void btEnviar_Click_1(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string signoZodiacal = ObtenerSignoZodiacal(fechaNacimiento);

            

            for (int i = 0; i < 3; i++)
            {
                aleatorio = random.Next(101);
                resultadoAleatorio = aleatorio.ToString("D2");
            }

            Form3 form3 = new Form3(tbNombre.Text, Convert.ToString(Math.Abs(fechaNacimiento.Year - DateTime.Today.Year)),  cbSexo.SelectedItem.ToString(), signo, prediccion, resultadoAleatorio);
            form3.Show(); 
            this.Hide();
        }

        private string ObtenerSignoZodiacal(DateTime fechaNacimiento)
        {
            int dia = fechaNacimiento.Day;
            int mes = fechaNacimiento.Month;
            if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
            {
                prediccion = "Buenas notas";
                signo = "Aries";
                return "Aries";
            }
            else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
            {
                prediccion = "Trabajo";
                signo = "Tauro";

                return "Tauro";
            }
            else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 21))
            {
                prediccion = "Rumbas";
                signo = "Géminis";

                return "Géminis";
            }
            else if ((mes == 6 && dia >= 22) || (mes == 7 && dia <= 22))
            {
                prediccion = "Dinero";
                signo = "Cáncer";

                return "Cáncer";
            }
            else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 23))
            {
                prediccion = "Deudas";
                signo = "Leo";

                return "Leo";
            }
            else if ((mes == 8 && dia >= 24) || (mes == 9 && dia <= 23))
            {
                prediccion = "Estabilidad laboral ";
                signo = "Virgo";

                return "Virgo";
            }
            else if ((mes == 9 && dia >= 24) || (mes == 10 && dia <= 22))
            {
                prediccion = "Felicidad";
                signo = "Libra";

                return "Libra";
            }
            else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 22))
            {
                prediccion = "Amor";
                signo = "Escorpio";

                return "Escorpio";
            }
            else if ((mes == 11 && dia >= 23) || (mes == 12 && dia <= 21))
            {
                prediccion = "Auto nuevo";
                signo = "Sagitario";

                return "Sagitario";
            }
            else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
            {
                prediccion = "Paz Espiritual ";
                signo = "Capricornio";

                return "Capricornio";
            }
            else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 19))
            {
                prediccion = "Salud";
                signo = "Acuario";

                return "Acuario";
            }
            else if ((mes == 2 && dia >= 20) || (mes == 3 && dia <= 20))
            {
                prediccion = "Buena suerte en la lotería ";
                signo = "Piscis";

                return "Piscis";
            }else
            {
                prediccion = "desconocido ";
                signo = "Signo desconocido";

                return "Signo desconocido";
           
            }
        }
        
        


            private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaNacimiento.MinDate = new DateTime(1900, 1, 01);
            dtpFechaNacimiento.MaxDate = DateTime.Today;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            string entrada = tbNombre.Text;

            if (!Regex.IsMatch(entrada, @"^[a-zA-Z]*$"))
            {
                errorProvider.SetError(tbNombre, "Solo se permiten letras.");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void dtpFechaNacimiento_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void lbSigno_Click(object sender, EventArgs e)
        {

        }
    }
    
}
