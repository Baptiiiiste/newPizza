using System;
using Modele;
using System.Collections.Generic;
using Xunit;

namespace TestsUnitaires
{
    public class UT_Client
    {
        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // tout bon

        [InlineData("", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Non-renseign�", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // Prenom vide

        [InlineData("Bonneau", "", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Non-renseign�", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // Nom vide

        [InlineData("Bonneau", "Baptiste", "", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", true)] // Email vide

        [InlineData("Bonneau", "Baptiste", "emailMarchePas", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", true)] // Email sans @

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "Non-renseign�", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // telephone vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "Non-renseign�", "Clermont-Ferrand", "63000", "default\noImg.png", false)] // Adresse vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Non-renseign�", "63000", "default\noImg.png", false)] // Ville vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "00000", "default\noImg.png", false)] // CodePostal vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noPP.jpg", false)] // Image vide

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "", "default\noImg.png",
                    "Bonneau", "Baptiste", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "default\noImg.png", true)] // Pseudo vide

        public void TEST_Ctor(string nom, string pr�nom, string email, string t�l�phone, string adresse, string ville, string codePostal, string pseudo, string photo,
                              string expNom, string expPr�nom, string expT�l�phone, string expAdresse, string expVille, string expCodePostal, string expPhoto, bool shouldThrowException)
        {

            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new Client(nom, pr�nom, email, t�l�phone, adresse, ville, codePostal, pseudo, photo));
                return;
            }
            
            Client c = new Client(nom, pr�nom, email, t�l�phone, adresse, ville, codePostal, pseudo, photo);
            Assert.Equal(expNom, c.Nom);
            Assert.Equal(expPr�nom, c.Pr�nom);
            Assert.Equal(expT�l�phone, c.T�l�phone);
            Assert.Equal(expAdresse, c.Adresse);
            Assert.Equal(expVille, c.Ville);
            Assert.Equal(expCodePostal, c.CodePostal);
            Assert.Equal(expPhoto, c.Photo);

        }

        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png")]
        public void TEST_ToString(string nom, string pr�nom, string email, string t�l�phone, string adresse, string ville, string codePostal, string pseudo, string photo)
        {
            List<Ingredients> liste = new List<Ingredients> { (Ingredients)53, (Ingredients)0 };
            Client c = new Client(nom, pr�nom, email, t�l�phone, adresse, ville, codePostal, pseudo, photo);
            string expectedAfficher = $"{nom} {pr�nom} {email} {t�l�phone} {adresse} {ville} {codePostal} {pseudo} {photo}";
            Assert.Equal(expectedAfficher, c.ToString());
        }
        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png", true)] // pareil

        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png",
                    "Perret", "Loris", "loris.perret@etu.uca.fr", "0712345678", "38 rue thisIsMonAdresse", "Vichy", "00000", "Lolo", "default\noImg.png", false)] // pas pareil

        [InlineData("Perret", "Loris", "loris.perret@etu.uca.fr", "0712345678", "38 rue thisIsMonAdresse", "Vichy", "00000", "Lolo", "default\noImg.png",
                    "Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000", "Bapt", "default\noImg.png", false)] // pas pareil
        public void TEST_Equals(string nom, string pr�nom, string email, string t�l�phone, string adresse, string ville, string codePostal, string pseudo, string photo,
                                string nom2, string pr�nom2, string email2, string t�l�phone2, string adresse2, string ville2, string codePostal2, string pseudo2, string photo2, bool expectResult)
        {
            Client c1 = new Client(nom, pr�nom, email, t�l�phone, adresse, ville, codePostal, pseudo, photo);
            Client c2 = new Client(nom2, pr�nom2, email2, t�l�phone2, adresse2, ville2, codePostal2, pseudo2, photo2);
            bool result = c1.Equals(c2);
            Assert.Equal(expectResult, result);

        }

        [Theory]
        [InlineData("Bonneau", "Baptiste", "baptiste.bonneau@etu.uca.fr", "0612345678", "37 rue thisIsMonAdresse", "Clermont-Ferrand", "63000")]
        [InlineData("Perret", "Loris", "loris.perret@etu.uca.fr", "0712345678", "38 rue thisIsMonAdresse", "Vichy", "63000")]
        public void TEST_EnregistrerModif(string nom, string pr�nom, string email, string t�l�phone, string adresse, string ville, string codePostal)
        {
            Client c1 = new Client("Nom", "Pr�nom", "Email@mail.fr", "T�l�phone", "Adresse", "Ville", "00000", "Pseudo", "mg");
            c1.EnregistrerModif(nom, pr�nom, email, t�l�phone, adresse, ville, codePostal);
            Assert.Equal(nom, c1.Nom);
            Assert.Equal(pr�nom, c1.Pr�nom);
            Assert.Equal(email, c1.Email);
            Assert.Equal(t�l�phone, c1.T�l�phone);
            Assert.Equal(adresse, c1.Adresse);
            Assert.Equal(ville, c1.Ville);
            Assert.Equal(codePostal, c1.CodePostal);
        }
    }
}
