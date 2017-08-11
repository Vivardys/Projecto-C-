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
        private void Operaciones(double valor1, double valor2)
        {
            //Switch que evalua la variable tipoOperaciones
            switch (tipoOperaciones)
            {
                //case de la suma
                case "+":
                    resultado = valor1 + valor2;
                    Textbox_Principal.Text = resultado.ToString();
                    valor1 = Convert.ToDouble(Textbox_Principal.Text);
                    break;

                //case de la resta
                case "-":
                    resultado = valor1 - valor2;
                    Textbox_Principal.Text = resultado.ToString();
                    valor1 = Convert.ToDouble(Textbox_Principal.Text);
                    break;

                //case de la multiplicacion
                case "*":
                    resultado = valor1 * valor2;
                    Textbox_Principal.Text = resultado.ToString();
                    valor1 = Convert.ToDouble(Textbox_Principal.Text);
                    break;

                //case de la suma
                case "/":
                    if (valor2 == 0)
                    {
                        Textbox_Principal.Text = "Error";
                        break;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                        Textbox_Principal.Text = resultado.ToString();
                        valor1 = Convert.ToDouble(Textbox_Principal.Text);
                        break;
                    }

                case"potencia":
                    resultado = Math.Pow(valor1, valor2);
                    Textbox_Principal.Text = resultado.ToString();
                    break;

                    // case de funcion de sacar la raiz x de un numero
                case "raizx":
                    if (valor2 <= 0)
                    {
                        Textbox_Principal.Text = "Error";
                        break;

                    }
                    else
                    {
                        Textbox_secundario.Text = valor2 + "" + Textbox_secundario.Text;
                        Textbox_secundario.Text = Textbox_secundario.Text.Remove(Textbox_secundario.Text.Count() - Textbox_Principal.Text.Count());
                        a = 1;
                        c = a / valor2;
                        Textbox_Principal.Text = Math.Pow(valor1, c).ToString();
                        break;


                    }
            }

        }

        private void unoentrex_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = "reciproc(" + valor1.ToString() + ")";
            Textbox_Principal.Text = Convert.ToString(1 / valor1);
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            inicio = true;
            operacion1 = true;
            if (igual)
            {
                if (tipoOperaciones == null)
                {


                }
                else
                {
                    valor2 = Convert.ToDouble(Textbox_Principal.Text);
                    Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text;
                    Operaciones(valor1, valor2);
                    igual = false;
                }

            }
        }
        //Boton Raiz
        private void Raiz_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            if (valor1 >= 0)
            {
                Textbox_secundario.Text = "sqrt(" + valor1 + ")";
                Textbox_Principal.Text = Convert.ToString(Math.Sqrt(valor1));
            }
            else
            {
                Textbox_Principal.Text = "Error";


            }

        }
        //boton porcentaje
        private void Porciento_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = Textbox_secundario.Text + Textbox_Principal.Text;
            Textbox_Principal.Text = Convert.ToString((valor1 * valor2) / 100);
            igual = true;


        }

        private void C_Click(object sender, EventArgs e)
        {
            Textbox_Principal.Text = "0";
            Textbox_secundario.Text += "";
            inicio = true;
            funciones = "";
            operacion1 = true;
            operacion2 = true;
            igual = true;
            valor1 = 0;
            valor2 = 0;
            resultado = 0;

        }
        //Boton CE
        private void CE_Click(object sender, EventArgs e)
        {
            Textbox_secundario.Text = "";
            Textbox_Principal.Text = "0";
            inicio = true;
            funciones = "";

        }
        //Boton Retroceso
        private void Retroceso_Click(object sender, EventArgs e)
        {
            if (Textbox_Principal.Text.Length > 1)
            {
                Textbox_Principal.Text = Textbox_Principal.Text.Remove(Textbox_Principal.Text.Length - 1, 1);
                {
                    Textbox_Principal.Text = "0";
                    inicio = true;
                }

                if (Textbox_Principal.Text == "0")
                {
                }


            }
        }

        private void masomenos_Click(object sender, EventArgs e)
        {
            Textbox_Principal.Text = Convert.ToString(0 - Convert.ToDouble(Textbox_Principal.Text));

        }
        //funciones trigonometica
        private void Trigonometria()    
        {
            if (radioButton1.Checked)
            {
                switch (funciones)
                {
                    //seno
                    case "sin":
                        valor1 = Convert.ToDouble(Textbox_Principal.Text);
                        Textbox_secundario.Text = "sin(" + valor1.ToString() + ")";
                        Textbox_Principal.Text = Convert.ToString(Math.Sin(Math.PI * (valor1) / 180));
                        break;
                    // seno inverso
                    case "asin":
                        valor1 = Convert.ToDouble(Textbox_Principal.Text);
                        Textbox_secundario.Text = "Asin(" + valor1.ToString() + ")";
                        Textbox_Principal.Text = Convert.ToString(Math.Asin(valor1) * 180 / Math.PI);
                        break;

                    //coseno
                    case "cos":
                        valor1 = Convert.ToDouble(Textbox_Principal.Text);
                        Textbox_secundario.Text = "cos(" + valor1.ToString() + ")";
                        Textbox_Principal.Text = Convert.ToString(Math.Cos(Math.PI * (valor1) / 180));
                        break;
                    // coseno inverso
                    case "acos":
                        valor1 = Convert.ToDouble(Textbox_Principal.Text);
                        Textbox_secundario.Text = "acos(" + valor1.ToString() + ")";
                        Textbox_Principal.Text = Convert.ToString(Math.Acos(valor1) * 180 / Math.PI);
                        break;

                    //tangente
                    case "tan":
                        valor1 = Convert.ToDouble(Textbox_Principal.Text);
                        Textbox_secundario.Text = "tan(" + valor1.ToString() + ")";
                        Textbox_Principal.Text = Convert.ToString(Math.Tan(Math.PI * (valor1) / 180));
                        break;
                    // tangente inverso
                    case "Atan":
                        valor1 = Convert.ToDouble(Textbox_Principal.Text);
                        Textbox_secundario.Text = "Atan(" + valor1.ToString() + ")";
                        Textbox_Principal.Text = Convert.ToString(Math.Atan(valor1) * 180 / Math.PI);
                        break;

                }
            }
            else

            {
                if (radioButton2.Checked)
                {
                    switch (funciones)
                    {
                        //seno
                        case "sin":
                            valor1 = Convert.ToDouble(Textbox_Principal.Text);
                            Textbox_secundario.Text = "sinr(" + valor1.ToString() + ")";
                            Textbox_Principal.Text = Convert.ToString(Math.Sin(valor1));
                            break;
                        // seno inverso
                        case "asin":
                            valor1 = Convert.ToDouble(Textbox_Principal.Text);
                            Textbox_secundario.Text = "Asinr(" + valor1.ToString() + ")";
                            Textbox_Principal.Text = Convert.ToString(Math.Asin(valor1));
                            break;

                        //coseno
                        case "cos":
                            valor1 = Convert.ToDouble(Textbox_Principal.Text);
                            Textbox_secundario.Text = "cosr(" + valor1.ToString() + ")";
                            Textbox_Principal.Text = Convert.ToString(Math.Cos(valor1));
                            break;
                        // coseno inverso
                        case "acos":
                            valor1 = Convert.ToDouble(Textbox_Principal.Text);
                            Textbox_secundario.Text = "acosr(" + valor1.ToString() + ")";
                            Textbox_Principal.Text = Convert.ToString(Math.Acos(valor1));
                            break;

                        //tangente
                        case "tan":
                            valor1 = Convert.ToDouble(Textbox_Principal.Text);
                            Textbox_secundario.Text = "tanr(" + valor1.ToString() + ")";
                            Textbox_Principal.Text = Convert.ToString(Math.Tan(valor1));
                            break;
                        // tangente inverso
                        case "Atan":
                            valor1 = Convert.ToDouble(Textbox_Principal.Text);
                            Textbox_secundario.Text = "Atanr(" + valor1.ToString() + ")";
                            Textbox_Principal.Text = Convert.ToString(Math.Atan(valor1));
                            break;

                    }
                }
            
            }       
        }
        //boton seno
        private void Sin_Click(object sender, EventArgs e)
        {
            funciones="sin";
            Trigonometria();
        }
        //boton coseno
        private void Cos_Click(object sender, EventArgs e)
        {
            funciones = "cos";
            Trigonometria();
        }
        //boton tangente 
        private void Tan_Click(object sender, EventArgs e)
        {
            funciones = "tan";
            Trigonometria();
        }
        // boton seno inverso
        private void Sinmenos1_Click(object sender, EventArgs e)
        {
            funciones = "asin";
            Trigonometria();
        }
        // boton coseno inverso
        private void Cosmenos1_Click(object sender, EventArgs e)
        {
            funciones = "acos";
            Trigonometria();
        }
        // boton tangete inverso
        private void Tanmenos1_Click(object sender, EventArgs e)
        {
            funciones = "atan";
            Trigonometria();
        }
        //boton pi
        private void Pin_Click(object sender, EventArgs e)
        {
            Textbox_secundario.Text = "";
            Textbox_Principal.Text = Math.PI.ToString();

        }
        //boton de elevar x a la 1
        private void x1_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = valor1.ToString() + "^-1";
            Textbox_Principal.Text = Math.Pow(valor1, -1).ToString();


        }
        //boton de elevar x numero a una potencia 
        private void xy_Click(object sender, EventArgs e)
        {
            igual = true;
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = valor1.ToString() + "^";
            tipoOperaciones = "potencia";
            operacion1 = false;
            igual = true;

        }

        private void neper_Click(object sender, EventArgs e)
        {
            Textbox_secundario.Text = "";
            Textbox_Principal.Text = Convert.ToString(Math.E);

        }

        private void YX_Click(object sender, EventArgs e)
        {
            inicio = true;
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = "√" + valor1;
            tipoOperaciones = "raizx";
            operacion1 = false;
            igual = true;

        }
        //boton que eleva x al cubo
        private void x3_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = "cube(" + valor1.ToString() + ")";
            Textbox_Principal.Text = Math.Pow(valor1, 3).ToString();

        }

        private void factoriales_Click(object sender, EventArgs e)
        {
            a = 1;
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = "fact(" + valor1.ToString() + ")";
            for (b = 1; b <= valor1; b++)
            {
                a = a * b;

            }
            Textbox_Principal.Text = Convert.ToString(a);
        }
        //boton raiz cubica
        private void tresx_Click(object sender, EventArgs e)
        {
            a = 1;
            b = 3;
            c = a / b;
            Textbox_Principal.Text = Math.Pow(valor1, c).ToString();
            Textbox_secundario.Text = "cuberoot(" + valor1.ToString() + ")";


        }
        //boton elevar a x al cuadrado
        private void xdos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = "sqr(" + valor1.ToString() + ")";
            Textbox_Principal.Text = Math.Pow(valor1, 2).ToString();

        }
        //boton ekevado a las 10
        private void diezx_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = "powten(" + valor1.ToString() + ")";
            Textbox_Principal.Text = Convert.ToString(Math.Pow(10, valor1));

        }
        // boton exponenciacion 
        private void EXP_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_Principal.Text = Convert.ToString(Math.Exp(valor1));
        }
        // boton logaritmo
        private void log_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(Textbox_Principal.Text);
            Textbox_secundario.Text = "log(" + valor1.ToString() + ")";
            Textbox_Principal.Text = Convert.ToString(Math.Log10(valor1));
            
        }

        private void MC_Click(object sender, EventArgs e)
        {
            memoria = 0;
            label1.Visible = false;
        }

        private void MR_Click(object sender, EventArgs e)
        {
            Textbox_Principal.Text = memoria.ToString();
        }

        private void MS_Click(object sender, EventArgs e)
        {
            memoria = Convert.ToDouble(Textbox_Principal.Text);
            label1.Visible = true;
        }

        private void M_mas_Click(object sender, EventArgs e)
        {
            memoria = memoria + Convert.ToDouble(Textbox_Principal.Text);
            label1.Visible = true;
        }

        private void M_menos_Click(object sender, EventArgs e)
        {
            memoria = memoria + Convert.ToDouble(Textbox_Principal.Text);
            label1.Visible = true;
        }
    }
}
 