// Importation des espaces de noms nécessaires pour le programme
using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

// Déclaration du namespace MegaCasting.ViewModel
namespace MegaCasting.ViewModel
{
    // Déclaration de la classe AddUserViewModel
    class AddUserViewModel
    {
        // Déclaration d'une propriété privée de type User
        private User _User;

        // Propriété publique permettant d'accéder à l'objet User
        public User User { get => _User; set => _User = value; }

        // Constructeur de la classe
        public AddUserViewModel()
        {
            // Initialisation de la propriété User avec une nouvelle instance de User
            User = new User();
        }

        // Méthode interne pour ajouter un utilisateur à la base de données
        internal void Add()
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Vérification que l'email, le nom, le prénom et le mot de passe de l'utilisateur ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(User.Email) || string.IsNullOrWhiteSpace(User.Lastname) || string.IsNullOrWhiteSpace(User.Firstname) || string.IsNullOrWhiteSpace(User.Password)))
                {
                    // Ajout de l'utilisateur à la base de données et sauvegarde des modifications
                    context.Add(User);
                    context.SaveChanges();
                }
            }
        }
    }
}
