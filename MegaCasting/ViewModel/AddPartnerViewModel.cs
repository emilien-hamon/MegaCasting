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
    // Déclaration de la classe AddPartnerViewModel
    class AddPartnerViewModel
    {
        // Déclaration d'une propriété privée de type Partner
        private Partner _Partner;

        // Propriété publique permettant d'accéder à l'objet Partner
        public Partner Partner { get => _Partner; set => _Partner = value; }

        // Constructeur de la classe
        public AddPartnerViewModel()
        {
            // Initialisation de la propriété Partner avec une nouvelle instance de Partner
            Partner = new Partner();
        }

        // Méthode interne pour ajouter un partenaire à la base de données
        internal void Add()
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Vérification que le label, le SIRET et la description du partenaire ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(Partner.Label) || string.IsNullOrWhiteSpace(Partner.SIRET) || string.IsNullOrWhiteSpace(Partner.Description)))
                {
                    // Ajout du partenaire à la base de données et sauvegarde des modifications
                    context.Add(Partner);
                    context.SaveChanges();
                }
            }
        }
    }
}
