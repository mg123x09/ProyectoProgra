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
            plantilla = new Cartones[cantidad];
            for(int k=0;k< cantidad-1; k++)
            {
                plantilla[k] = new Cartones();
            }
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

        public string jugar()
        {
            string respuesta = "";
            Random alea = new Random();
            int num_juego = alea.Next(1, 75);
            int letra = alea.Next(1, 5);
            int contador = 0;
            Boolean ganador = false;
            string letrafinal="";

            switch (letra)
            {
                case 1:
                    letrafinal = "B";
                    break;
                case 2:
                    letrafinal = "I";
                    break;
                case 3:
                    letrafinal = "N";
                    break;
                case 4:
                    letrafinal = "G";
                    break;
                case 5:
                    letrafinal = "O";
                    break;
           

            }
            
            foreach (Cartones carton in plantilla){

                for (int i = 0; i < carton.carts.GetLength(1); i++)
                {
                    for (int j = 0; j < carton.carts.GetLength(0); j++)
                    {
                        if (num_juego.ToString().Equals(carton.carts[i,j]) && i==letra-1)
                        {
                            carton.carts[i, j] = "XX";
                        }
                        if (carton.carts[i,j].Equals("XX"))
                        {
                            contador++;
                        }

                    }
                }
                 if(contador == carton.carts.Length)
                {
                    ganador = true;
                    respuesta = "El ganador es el jugador numero "+carton.player+"con el carton "+carton.ids;
                }
            }

            if (ganador)
            {
                return respuesta;
            }
            else
            {
                return letrafinal + num_juego.ToString();
            }


        }

        private void cmbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creacion(5, 5, 25, "e");
            MessageBox.Show(jugar());
        }
    }
}
