using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datos_estudainte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Datos_Click(object sender, EventArgs e)
        {
            double matricula, nombre, apellido, edad, carrera;

            matricula = double.Parse(txt_Matricula.Text);
            nombre = double.Parse(txt_nombre.Text);
            apellido = double.Parse(txt_apellido.Text);
            edad = double.Parse(txt_edad.Text);
            carrera = double.Parse(txt_carrera.Text);

            txt_Matricula.Text = matricula.ToString();
            txt_nombre.Text = nombre.ToString();
            txt_apellido.Text = apellido.ToString();
            txt_edad.Text = edad.ToString();
            txt_Datos.Text = carrera.ToString();

            string Datos= $"matricula:{matricula},nombre:{nombre},apellido{apellido},edad{edad},carrera{carrera}";

                txt_Datos.Text = Datos;



        }
    }
}
