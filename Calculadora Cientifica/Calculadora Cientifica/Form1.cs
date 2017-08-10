using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Cientifica
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        //Declaracion de variables
        bool igual = true, inicio = true, operacion1 = true, operacion2 = true;
        double a, b, c, memoria = 0, resultado, valor1, valor2;
        string funciones, tipoOperaciones;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void uno_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "1";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "1";

            }


        }

        private void dos_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "2";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "2";

            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "3";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "3";

            }
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "4";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "4";

            }
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "5";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "5";

            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "6";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "6";

            }
        }

        private void Siete_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "7";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "7";

            }
        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "8";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "8";

            }
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "9";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "9";

            }
        }

        private void cero_Click(object sender, EventArgs e)
        {
            //condiciones para la variable inicio
            if (inicio)
            {
                Textbox_Principal.Text = "";
                Textbox_Principal.Text = "0";
                inicio = false;
            }
            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + "0";

            }
        }

        private void punto_Click(object sender, EventArgs e)
        {
            // boton decimal
            if (Textbox_Principal.Text.Contains("."))
            {

            }

            else
            {
                Textbox_Principal.Text = Textbox_Principal.Text + ".";
                inicio = false;

            }


        }
        // Boton De Suma
        private void mas_Click(object sender, EventArgs e)
        {
            igual = true;
            inicio = true;
            // Condiciones para la variable operacion1
            if (operacion1)
            {
                valor1 = Convert.ToDouble(Textbox_Principal.Text);
                Textbox_secundario.Text = "";
                Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "+";
                operacion1 = false;
            }
            else
            {

                // Condiciones para la variable operacion2
                if (operacion2)
                {
                    valor2 = Convert.ToDouble(Textbox_Principal.Text);
                    Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "+";
                    operacion2 = false;

                }
                else
                {
                    Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "+";
                    Operaciones(resultado, valor2);
                }
            }
            tipoOperaciones = "+";
        }


        //Boton Resta
        private void menos_Click(object sender, EventArgs e)
        {
            igual = true;
            inicio = true;
            // Condiciones para la variable operacion1
            if (operacion1)
            {
                valor1 = Convert.ToDouble(Textbox_Principal.Text);
                Textbox_secundario.Text = "";
                Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "-";
                operacion1 = false;

            }
            else
            {

                // Condiciones para la variable operacion2
                if (operacion2)
                {
                    valor2 = Convert.ToDouble(Textbox_Principal.Text);
                    Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "-";
                    operacion2 = false;

                }
                else
                {
                    Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "-";
                    Operaciones(resultado, valor2);
                }
            }
            tipoOperaciones = "-";
        }

        //Boton Multiplicar
        private void multiplicacion_Click(object sender, EventArgs e)
        {
            igual = true;
            inicio = true;
            // Condiciones para la variable operacion1
            if (operacion1)
            {
                valor1 = Convert.ToDouble(Textbox_Principal.Text);
                Textbox_secundario.Text = "";
                Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "*";
                operacion1 = false;
            }
            else
            {

                // Condiciones para la variable operacion2
                if (operacion2)
                {
                    valor2 = Convert.ToDouble(Textbox_Principal.Text);
                    Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "*";
                    operacion2 = false;

                }
                else
                {
                    Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "*";
                    Operaciones(resultado, valor2);
                }
            }
            tipoOperaciones = "*";
        }

        //Boton Division
        private void Dividir_Click(object sender, EventArgs e)
        {
            igual = true;
            inicio = true;
            // Condiciones para la variable operacion1
            if (operacion1)
            {
                valor1 = Convert.ToDouble(Textbox_Principal.Text);
                Textbox_secundario.Text = "";
                Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "/";
                operacion1 = false;
            }
            else
            {

                // Condiciones para la variable operacion2
                if (operacion2)
                {
                    valor2 = Convert.ToDouble(Textbox_Principal.Text);
                    Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "/";
                    operacion2 = false;

                }
                else
                {
                    Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text + "/";
                    Operaciones(resultado, valor2);
                }
            }
            tipoOperaciones = "/";

           } 
            //Metodos con las operaciones de + - * /
                private void Operaciones(double valor1,double valor2)
                {
        }           
    }
}

 