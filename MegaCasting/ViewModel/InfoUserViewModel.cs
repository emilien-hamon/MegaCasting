// Importation des espaces de noms nécessaires pour le programme
using MegaCasting.Class;
using System.Collections.ObjectModel;
using System.Linq;

// Déclaration du namespace MegaCasting.ViewModel
namespace MegaCasting.ViewModel
{
    // Déclaration de la classe InfoUserViewModel
    internal class InfoUserViewModel
    {
        // Déclaration d'une propriété privée de type User
        private User _User;

        // Propriété publique permettant d'accéder à l'objet User
        public User User
        {
            get => _User;
            set => _User = value;
        }

        // Constructeur de la classe avec un paramètre identifierUser
        public InfoUserViewModel(int identifierUser)
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Récupération du premier utilisateur correspondant à l'identifiant spécifié
                User = context.Users.First(user => user.Id == identifierUser);
            }
        }
    }
}
