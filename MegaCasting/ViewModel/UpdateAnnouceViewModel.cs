// Importation des espaces de noms nécessaires pour le programme
using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Tls;
using System.Text;
using System.Threading.Tasks;

// Déclaration du namespace MegaCasting.ViewModel
namespace MegaCasting.ViewModel
{
    // Déclaration de la classe UpdateAnnouceViewModel
    internal class UpdateAnnouceViewModel
    {
        // Déclaration d'une propriété privée de type Annouce
        private Annouce _Annouce;

        // Propriété publique permettant d'accéder à l'objet Annouce
        public Annouce Annouce { get => _Annouce; set => _Annouce = value; }

        // Constructeur de la classe avec un paramètre identifierAnnouce
        public UpdateAnnouceViewModel(int identifierAnnouce)
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Récupération de la première annonce correspondant à l'identifiant spécifié
                Annouce = context.Annouces.First(annouceTemp => annouceTemp.ID == identifierAnnouce);
            }
        }

        // Méthode interne pour mettre à jour une annonce dans la base de données
        internal void Update()
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Vérification que le titre et le contenu de l'annonce ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(Annouce.Title) || string.IsNullOrWhiteSpace(Annouce.Content)))
                {
                    // Mise à jour de l'annonce dans la base de données et sauvegarde des modifications
                    context.Update(Annouce);
                    context.SaveChanges();
                }
            }
        }
    }
}
