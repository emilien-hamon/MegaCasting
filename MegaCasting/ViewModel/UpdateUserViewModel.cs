// Importation des espaces de noms nécessaires pour le programme
using MegaCasting.Class;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Déclaration du namespace MegaCasting.ViewModel
namespace MegaCasting.ViewModel
{
    // Déclaration de la classe UpdateUserViewModel
    class UpdateUserViewModel
    {
        // Déclaration d'une propriété privée de type User
        private User _User;

        // Propriété publique permettant d'accéder à l'objet User
        public User User { get => _User; set => _User = value; }

        // Constructeur de la classe avec un paramètre identifierUser
        public UpdateUserViewModel(int identifierUser)
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Récupération du premier utilisateur correspondant à l'identifiant spécifié
                User = context.Users.First(userTemp => userTemp.Id == identifierUser);
            }
        }

        // Méthode interne pour mettre à jour un utilisateur dans la base de données
        internal void Update()
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Vérification que l'email, le nom, le prénom et le mot de passe de l'utilisateur ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(User.Email) || string.IsNullOrWhiteSpace(User.Lastname) || string.IsNullOrWhiteSpace(User.Firstname) || string.IsNullOrWhiteSpace(User.Password)))
                {
                    // Mise à jour de l'utilisateur dans la base de données et sauvegarde des modifications
                    context.Update(User);
                    context.SaveChanges();
                }
            }
        }
    }
}
