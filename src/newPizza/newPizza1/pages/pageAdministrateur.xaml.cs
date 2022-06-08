﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Modele;

namespace newPizza1
{
    /// <summary>
    /// Logique d'interaction pour pageAdministrateur.xaml
    /// </summary>
    public partial class pageAdministrateur : Window
    {
        public Manager Mgr => ((App)App.Current).LeManager;
        public pageAdministrateur()
        {
            DataContext = Mgr.UtilisateurActuel;
            InitializeComponent();
        }

        private void Bouton_Deconnexion(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Déconnexion", "Voulez-vous vraiment vous  déconnecter", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                pageIdentification identif = new pageIdentification();
                this.Close();
                identif.Show();
            }
        }

        private void Bouton_Admin(object sender, RoutedEventArgs e)
        {
            var windows = new ucAdmninistration();
            contControl.Content = windows;
            Titre.Text = "Informations de mon entreprise :";
            TextBun.Text = ((Administrateur)Mgr.UtilisateurActuel).NomPizzeria;
        }

        private void Bouton_Commandes(object sender, RoutedEventArgs e)
        {
            var windows = new ucTouteLesCommande();
            contControl.Content = windows;
            Titre.Text = "Commande";
            TextBun.Text = "";
        }
    }
}
