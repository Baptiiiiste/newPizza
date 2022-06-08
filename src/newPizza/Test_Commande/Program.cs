﻿using System;
using System.Collections.Generic;
using Modele;

namespace Test_Commande
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Commande");
           
            List<Ingredients> listeIngre1 = new List<Ingredients> { (Ingredients)2, (Ingredients)20 };
            List<Ingredients> listeIngre2 = new List<Ingredients> { (Ingredients)55, (Ingredients)13, (Ingredients)42, (Ingredients)21, (Ingredients)36 };
           
            Pizza P1 = new Pizza("Reine", "Description", "image", listeIngre1, 15);
            Pizza P2 = new Pizza("Peperonni", "Description", "image", listeIngre2, 10);

            Client C1 = new Client("Kartal", "Emre", "emre@oui.com", "06.45.85.95.15", "27 rue oui", "Clermont-Ferrand", "63100", "Mdp", "tobiii", "non");

            C1.ajouterPizzaCommande(P1);
            C1.ajouterPizzaCommande(P2);


            Commande c = new Commande(C1, C1.ListPizzaClient);

            Console.WriteLine("Statut de la pizza:");
            Console.WriteLine(c.Statut);

            Console.WriteLine("Changement du statut de la pizza:");
            c.changerStatus();
            Console.WriteLine(c.Statut);

            Console.WriteLine("Changement du statut de la pizza:");
            c.changerStatus();
            Console.WriteLine(c.Statut);

            Console.WriteLine("Liste de pizza dans la commande:");
            foreach(Pizza p in C1.ListPizzaClient)
            {
                Console.WriteLine(p);
            }


        }
    }
}
