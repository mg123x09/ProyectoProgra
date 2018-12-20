using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Cartones[] plantilla;
        public void creacion(int juga, int cartones, int cant_num, string modo)
        {
            int cantidad = cartones * juga;
            int contador = 0;
            plantilla= new Cartones[cantidad];
            for (int i = 0; i < juga; i++)
            {
                for (int j = 0; j < cartones; j++)
                {
                    plantilla[contador].ids = j;
                    plantilla[contador].player = i;
                    plantilla[contador].carts = llenar(cant_num);
                    contador++;
                    
                }
            }
        }

        public string[,] llenar(int numeros)
        {
            int filas = numeros / 5;
            Random alea = new Random();
            string[,] retorno = new string[5, filas];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if (i == 2 && j==2 && filas==5)//centro
                    {
                        retorno[i, j] = "XX";
                    }
                    retorno[i, j] = alea.Next(1,75).ToString();
                }
            }
            return retorno;
        }



        private void cmbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
