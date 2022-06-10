﻿using Modele;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour ucCommande.xaml
    /// </summary>
    public partial class ucCommande : UserControl
    {
        public Manager Mgr => ((App)App.Current).LeManager;
        public ucCommande()
        {
            DataContext = ((Administrateur)Mgr.UtilisateurActuel).ListCommandeAdmin;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*Debug.Write(Mgr.CommandeActuelle.Statut);*/
            //((Administrateur)Mgr.UtilisateurActuel).ChangerStatusCommande(Mgr.CommandeActuelle);
            //if (Mgr.CommandeActuelle != null)
            //{
                TextB.Visibility = Visibility.Visible;
                bName.Content = "FINIT";
            //}
            /*Debug.Write(Mgr.CommandeActuelle.Statut.ToString());*/
        }


        // Créer une nvlle commande:
        /*
            //on crée un nouveau player settings
            ucPizzaCommande pSettings = new ucPizzaCommande();
            //on incrémente l'identifiant pour lui donner la bonne valeur
            pSettings.Id = ucPizzaCommandeList.Count + 1;
            //on ajoute quelques propriétés
            pSettings.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            pSettings.VerticalAlignment = System.Windows.VerticalAlignment.Center;

            //on ajoute une nouvelle ligne à la grille
            ucPizzaCommandeGrid.RowDefinitions.Add(new RowDefinition());
            //on ajoute le player settings à la grille en le plaçant sur la nouvelle ligne
            ucPizzaCommandeGrid.Children.Add(pSettings);
            pSettings.SetValue(Grid.RowProperty, pSettings.Id);

            //on ajoute notre player settings à la liste privée
            ucPizzaCommandeList.Add(pSettings);
         */


    }
}
