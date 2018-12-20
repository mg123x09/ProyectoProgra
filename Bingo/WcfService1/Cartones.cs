using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Cartones
    {

        int idCart;
        string[,] carton;
        int jugador; 

        //Id GET SET
        public int ids
        {
            get { return idCart; }
            set { idCart = value; }

        }

        //STRING
        public string[,] carts
        {
            get { return carton; }
            set {carton=value; }
        }


        //JUGADOR
        public int player 
        {
            get { return jugador; }
            set { jugador = value; }

        }
    }
}