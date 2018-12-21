﻿using System;
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

            public Cartones(int cart, int juga, string[,] mat)
        {
            idCart = cart;
            jugador = juga;
            carton = mat;
        }
        public int ids
        {
            get { return idCart; }
            set { idCart = value; }

        }

        //string
        public string[,] carts
        {
            get { return carton; }
            set {carton=value; }
        }


        //jugador
        public int player 
        {
            get { return jugador; }
            set { jugador = value; }

        }
    }
}