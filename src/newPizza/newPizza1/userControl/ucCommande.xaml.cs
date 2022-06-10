﻿using Modele;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        /// <summary>
        /// appel du manager
        /// </summary>
        public Manager Mgr => ((App)App.Current).LeManager;

        /// <summary>
        /// initialise & récupère la liste de commande de l'utilisateur (admin)
        /// </summary>
        public ucCommande()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bouton qui change le statut de la commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Administrateur)Mgr.UtilisateurActuel).ChangerStatusCommande(Mgr.CommandeActuelle);
            if (Mgr.CommandeActuelle != null)
            {
                TextB.Visibility = Visibility.Visible;
                bName.Content = "FINIT";
            }
        }



        public ObservableCollection<Pizza> lisPizza
        {
            get { return (ObservableCollection<Pizza>)GetValue(lisPizzaProperty); }
            set { SetValue(lisPizzaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for lisComma.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty lisPizzaProperty =
            DependencyProperty.Register("lisPizza", typeof(ObservableCollection<Pizza>), typeof(ucCommande), new PropertyMetadata());



    }
}
