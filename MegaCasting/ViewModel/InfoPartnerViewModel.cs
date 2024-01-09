// Importation des espaces de noms nécessaires pour le programme
using MegaCasting.Class;
using System.Collections.ObjectModel;
using System.Linq;

// Déclaration du namespace MegaCasting.ViewModel
namespace MegaCasting.ViewModel
{
    // Déclaration de la classe InfoPartnerViewModel
    internal class InfoPartnerViewModel
    {
        // Déclaration d'une propriété privée de type Partner
        private Partner _Partner;

        // Propriété publique permettant d'accéder à l'objet Partner
        public Partner Partner
        {
            get => _Partner;
            set => _Partner = value;
        }

        // Constructeur de la classe avec un paramètre identifierPartner
        public InfoPartnerViewModel(int identifierPartner)
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Récupération du premier partenaire correspondant à l'identifiant spécifié
                Partner = context.Partners.First(partner => partner.ID == identifierPartner);
            }
        }
    }
}
