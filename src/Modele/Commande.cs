﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Cette fonction permet a un client de passer une commande
    /// </summary>
    public class Commande
    {
        /// <summary>
        /// La liste des pizza présent dans la commande
        /// </summary>
        private List<Pizza> listPizza;
        public List<Pizza> ListPizza { get => listPizza; private set => listPizza = value; }

        /// <summary>
        /// Le client actuel qui passe commande
        /// </summary>
        private Client clientActu;
        public Client ClientActu { get => clientActu; private set => clientActu = value; }

        private Status statut;
        public Status Statut { get => statut; private set => statut = value; }

        /// <summary>
        /// Le constructeur reçois un client actuelle et une liste de pizza
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="listPzz"></param>
        public Commande(Client c1, List<Pizza> listPzz)
        {
            ListPizza = new List<Pizza>();
            ListPizza = listPzz;
            ClientActu = c1;
            Statut = Status.Commencer;
        }


        /// <summary>
        /// Permet de changer le statut d'une commande
        /// </summary>
        public void changerStatus()
        {
            if (statut == Status.Commencer)
            {
                statut = Status.EnCours;
                return;
            }

            if (statut == Status.EnCours)
            {
                statut = Status.Finir;
                return;
            }
        }


        /// <summary>
        /// Vérifie si deux pizzas sont égales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true si les deux pizzas sont égales, false sinon</returns>
        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(obj, null)) return false;
            if (object.ReferenceEquals(this, obj)) return true;
            if (this.GetType() != obj.GetType()) return false;
            /*return this.Equals(obj as Commande);*/
            Commande cmd = (Commande)obj;
            return ListPizza == cmd.ListPizza && ClientActu == cmd.ClientActu;
        }

        public override int GetHashCode()
        {
            return ListPizza.GetHashCode();
        }

        /// <summary>
        /// Affiche le contenu d'une commande
        /// </summary>
        /// <returns>chaine de caractère</returns>
        public override string ToString()
        {
            string txt = $"{ClientActu.Pseudo}, ";
            foreach (Pizza p in ListPizza)
            {
                txt += $"{p}, ";
            }
            txt += $"{Statut}";

            return txt;
        }

    }
}
