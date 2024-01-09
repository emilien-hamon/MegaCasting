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
    // Déclaration de la classe UpdatePartnerViewModel
    internal class UpdatePartnerViewModel
    {
        // Déclaration d'une propriété privée de type Partner
        private Partner _Partner;

        // Propriété publique permettant d'accéder à l'objet Partner
        public Partner Partner { get => _Partner; set => _Partner = value; }

        // Constructeur de la classe avec un paramètre identifierPartner
        public UpdatePartnerViewModel(int identifierPartner)
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Récupération du premier partenaire correspondant à l'identifiant spécifié
                Partner = context.Partners.First(partnerTemp => partnerTemp.ID == identifierPartner);
            }
        }

        // Méthode interne pour mettre à jour un partenaire dans la base de données
        internal void Update()
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Vérification que le label, le SIRET et la description du partenaire ne sont pas vides ou composés uniquement d'espaces
                if (!(string.IsNullOrWhiteSpace(Partner.Label) || string.IsNullOrWhiteSpace(Partner.SIRET) || string.IsNullOrWhiteSpace(Partner.Description)))
                {
                    // Mise à jour du partenaire dans la base de données et sauvegarde des modifications
                    context.Update(Partner);
                    context.SaveChanges();
                }
            }
        }
    }
}
