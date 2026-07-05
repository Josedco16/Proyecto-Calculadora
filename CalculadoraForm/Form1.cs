using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 //  CALCULATOR PROJECT, FRANCO CORDOBA
namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        //Aca se crean las variables globales, fuera de todo metodo.
        int num1 = 0;
        int num2 = 0;
        string signo = "";
        bool igual = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void pantallaBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "3";
        }

        //Aca creamos los metodos para las operaciones
        public static int suma(int num1, int num2)
        {
            int resultado = (num1 + num2);
            return resultado;
        }

        public static int resta (int num1, int num2)
        {
            int resultado = (num1 - num2);
            return resultado;
        }

        public static int multiplicacion (int num1, int num2)
        {
            int resultado = (num1 * num2);
            return resultado;
        }

        public static double division (int  num1, int num2)
        {
            int resultado = 0;
           if ( num2==0)
            {
                MessageBox.Show("no es posible entre 0");
                
            }
           else
            {
                resultado = num1 / num2;
            }
            return resultado;
                 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(num1.ToString() != "" && pantallaBox.Text != "")
            {
                num2 = Convert.ToInt32((pantallaBox.Text));
                igual = true;
                switch (signo)
                {
                    case "+":
                        pantallaBox.Text = suma(num1, num2).ToString();
                        break;
                    case "-":
                        pantallaBox.Text = resta(num1, num2).ToString();
                        break;
                    case "X":
                        pantallaBox.Text = multiplicacion(num1, num2).ToString();
                        break;
                    case "/":
                        pantallaBox.Text = division(num1, num2).ToString();
                        break;
                    default:
                        MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
            else
            {
                MessageBox.Show("Debe ingresar dos numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "9";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(pantallaBox.Text);
            pantallaBox.Text = "";
            signo = "+";
        }

        private void btn_Multiplicacion_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(pantallaBox.Text);
            pantallaBox.Text = "";
            signo = "X";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
           if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "1";
        }
        

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "2";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "5";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "8";
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(pantallaBox.Text);
            pantallaBox.Text = "";
            signo = "-";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(pantallaBox.Text);
            pantallaBox.Text = "";
            signo = "/";
        }

        private void calculadora_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                pantallaBox.Text = "";
                igual = false;
            }
            pantallaBox.Text = pantallaBox.Text + "0";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            signo = "";
            igual = false;
            pantallaBox.Text = "";
        }
    }
}
