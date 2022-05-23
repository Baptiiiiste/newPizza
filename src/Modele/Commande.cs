﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Commande
    {
        private List<Pizza> listPizza;
        public List<Pizza> ListPizza { get => listPizza; private set => listPizza = value; }
        private Client clientActu;
        public Client ClientActu { get => clientActu; private set => clientActu = value; }

        public Commande(Client c1, List<Pizza> listPzz)
        {
            ListPizza = new List<Pizza>();
            ClientActu = c1;
        }

    }
}
