﻿using Modele;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour ucPizzaBox.xaml
    /// </summary>
    public partial class ucPizzaBox : UserControl
    {

        public Manager Mgr => ((App)App.Current).LeManager;

        public ucPizzaBox()
        {
            InitializeComponent();
        }

        public void BtnPlus(object sender, RoutedEventArgs e)
        {
            Pizza p1 = Mgr.PizzaActuelle;
            if (p1 != null)
            {
                int m = p1.Quantité;
                Mgr.PizzaActuelle.Quantité = m + 1;
            }
        }

        public void BtnMoin(object sender, RoutedEventArgs e)
        {
            Pizza p1 = Mgr.PizzaActuelle;
            if (p1 != null)
            {
                int m = p1.Quantité;
                if (m > 1)
                {
                    m -= 1;
                    Mgr.PizzaActuelle.Quantité = m;
                }
            }
        }

        public void AddPanier(object sender, RoutedEventArgs e)
        {
            Pizza p1 = Mgr.PizzaActuelle;
            if (p1 != null)
            {
                int m = p1.Quantité;
                if (m >= 1)
                {
                    ((Client)Mgr.UtilisateurActuel).ajouterPizzaCommande(Mgr.PizzaActuelle);
                    ((Client)Mgr.UtilisateurActuel).ListPizzaClient[((Client)Mgr.UtilisateurActuel).ListPizzaClient.Count() - 1].Quantité = Mgr.PizzaActuelle.modifQte(m);
                }
            }
        }

        public string Texte
        {
            get { return (string)GetValue(TexteProperty); }
            set { SetValue(TexteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Texte.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TexteProperty =
            DependencyProperty.Register("Texte", typeof(string), typeof(ucPizzaBox), new PropertyMetadata("Soy una pizza"));

        public string ImageName
        {
            get { return (string)GetValue(ImageNameProperty); }
            set { SetValue(ImageNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageNameProperty =
            DependencyProperty.Register("ImageName", typeof(string), typeof(ucPizzaBox), new PropertyMetadata("noImg.png"));



        public int QtePizza
        {
            get { return (int)GetValue(QtePizzaProperty); }
            set { SetValue(QtePizzaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for QtePizza.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QtePizzaProperty =
            DependencyProperty.Register("QtePizza", typeof(int), typeof(ucPizzaBox), new PropertyMetadata(1));

        
        public event RoutedEventHandler? CLICKPLUSINFO;
        private void MenuBouton_Click(object sender, RoutedEventArgs e)
        {
            if (CLICKPLUSINFO != null)
            {
                CLICKPLUSINFO(this, e);
            }
        }

        /*private void btnPlusInfo(object sender, RoutedEventArgs e)
        { 
            // Récupérer la page actuelle & pageCatalogue:
            //Catalogue pageCatalogue = ..........; a completer
            
            // Lancer le uc:
            //pageCatalogue.ccCatalogue.Content = new ucInfoPizza(); ou qqc du genre
            
            // Mettre les bonnes info dans le binding
            // - setImage
            // - setNom
            // - setDescription
            // - setPrix



        }*/
    }
}
