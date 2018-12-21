using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1;

namespace WindowsFormsApp1
{
    class logic
    {
        public Cartones[] plantilla;
        public void creacion(int juga, int cartones, int cant_num)
        {
            int cantidad = cartones * juga;
            int contador = 0;
            plantilla = new Cartones[cantidad];

            for (int i = 1; i <= juga; i++)
            {
                for (int j = 1; j <= cartones; j++)
                {
                    plantilla[contador] = new Cartones(j, i, llenar(cant_num));

                    contador++;

                }
            }
        }
        public List<string> numerosHis = new List<string>();

        public string[,] llenar(int numeros)
        {
            //numerosHis.Clear();
            int filas = numeros / 5;
            Random alea = new Random();
            string[,] retorno = new string[5, filas];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if (i == 2 && j == 2 && filas == 5)//centro
                    {
                        retorno[i, j] = "XX";
                    }
                    retorno[i, j] = alea.Next(1, 76).ToString();
                }
            }

            return retorno;
        }

        public string jugar(string modo)
        {
            string respuesta = "";
            Random alea = new Random();
            int num_juego = alea.Next(1, 76);
            int letra = alea.Next(1, 6);
            int contador = 0;
            Boolean ganador = false;
            string letrafinal = "";

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

            foreach (Cartones carton in plantilla)
            {

                for (int i = 0; i < carton.carts.GetLength(1); i++)
                {
                    for (int j = 0; j < carton.carts.GetLength(0); j++)
                    {
                        try { 
                        if (num_juego.ToString().Equals(carton.carts[i, j]) && i == letra - 1)
                        {
                            carton.carts[i, j] = "XX";
                        }
                        if (carton.carts[i, j].Equals("XX"))
                        {
                            contador++;
                        }
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                if (contador == carton.carts.Length && modo.Contains("lleno"))
                {
                    ganador = true;
                    respuesta = "El ganador es el jugador numero " + carton.player + "con el carton " + carton.ids;
                }
                else
                {
                    contador = 0;
                }

                if (modo.Contains("esquinas") && carton.carts[0, 0] == "XX" && carton.carts[0, (carton.carts.GetLength(0) - 1)] == "XX"
                    && carton.carts[(carton.carts.GetLength(1) - 1), (carton.carts.GetLength(0) - 1)] == "XX" && carton.carts[(carton.carts.GetLength(1) - 1), 0] == "XX")
                {
                    ganador = true;
                    respuesta = "El ganador es el jugador numero " + carton.player + "con el carton " + carton.ids;
                }

            }

            if (ganador)
            {
                return respuesta;
            }
            else
            {
                numerosHis.Add(letrafinal + num_juego.ToString());
                return letrafinal + num_juego.ToString();


            }


        }

        public string mostrarHis()
        {

            string resultado = "";
            foreach (string numero in numerosHis)
            {
                resultado += numero + "\n";
            }
            return resultado;
        }

        public string[] mostrar_cart(int idju, int id_cart, int fila)
        {
            Cartones temporal = null;
            foreach (Cartones cart in plantilla)
            {
                if (cart.ids == id_cart && cart.player == idju)
                {
                    temporal = cart;
                }
            }
            string[] numeros = new string[5];
            for (int i = 0; i < 5; i++)
            {
                numeros[i] = temporal.carts[i, fila].ToString();
            }
            return numeros;
        }
    }
}
