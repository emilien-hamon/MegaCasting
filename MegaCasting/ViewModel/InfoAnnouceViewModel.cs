// Importation des espaces de noms nécessaires pour le programme
using MegaCasting.Class;
using System.Collections.ObjectModel;
using System.Linq;

// Déclaration du namespace MegaCasting.ViewModel
namespace MegaCasting.ViewModel
{
    // Déclaration de la classe InfoAnnouceViewModel
    internal class InfoAnnouceViewModel
    {
        // Déclaration d'une propriété privée de type Annouce
        private Annouce _Annouce;

        // Propriété publique permettant d'accéder à l'objet Annouce
        public Annouce Annouce
        {
            get => _Annouce;
            set => _Annouce = value;
        }

        // Constructeur de la classe avec un paramètre identifierAnnouce
        public InfoAnnouceViewModel(int identifierAnnouce)
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Récupération de la première annonce correspondant à l'identifiant spécifié
                Annouce = context.Annouces.First(annouce => annouce.ID == identifierAnnouce);
            }
        }
    }
}
