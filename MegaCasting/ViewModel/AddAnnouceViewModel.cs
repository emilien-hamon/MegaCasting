// Importation des espaces de noms nécessaires pour le programme
using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Déclaration du namespace MegaCasting.ViewModel
namespace MegaCasting.ViewModel
{
    // Déclaration de la classe AddAnnouceViewModel
    class AddAnnouceViewModel
    {
        // Déclaration d'une propriété privée de type Annouce
        private Annouce _Annouce;

        // Propriété publique permettant d'accéder à l'objet Annouce
        public Annouce Annouce { get => _Annouce; set => _Annouce = value; }

        // Constructeur de la classe
        public AddAnnouceViewModel()
        {
            // Initialisation de la propriété Annouce avec une nouvelle instance d'Annouce
            Annouce = new Annouce();
        }

        // Méthode interne pour ajouter une annonce à la base de données
        internal void Add()
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Vérification que le titre et le contenu de l'annonce ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(Annouce.Title) || string.IsNullOrWhiteSpace(Annouce.Content)))
                {
                    // Ajout de l'annonce à la base de données et sauvegarde des modifications
                    context.Add(Annouce);
                    context.SaveChanges();
                }
            }
        }
    }
}
