using MegaCasting.Class;
using System.Collections.ObjectModel;
using System.Linq;

namespace MegaCasting.ViewModel
{
    internal class InfoPartnerViewModel
    {
        private Partner _Partner;

        public Partner Partner
        {
            get => _Partner;
            set => _Partner = value;
        }

        public InfoPartnerViewModel(int identifierPartner)
        {
            using (DbMegacastingContext context = new())
            {
                Partner = context.Partners.First(partner => partner.ID == identifierPartner);
            }
        }
    }
}