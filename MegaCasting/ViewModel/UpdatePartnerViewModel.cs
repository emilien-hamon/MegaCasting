using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Tls;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    internal class UpdatePartnerViewModel
    {



        private Partner _Partner;

        public Partner Partner { get => _Partner; set => _Partner = value; }



        public UpdatePartnerViewModel(int identifierPartner)
        {
            using (DbMegacastingContext context = new())
            {
                Partner = context.Partners.First(partnerTemp => partnerTemp.ID == identifierPartner);
            }
        }


        internal void Update()
        {
            using (DbMegacastingContext context = new())
            {
                if (!(string.IsNullOrWhiteSpace(Partner.Label)
                   || string.IsNullOrWhiteSpace(Partner.SIRET)
                   || string.IsNullOrWhiteSpace(Partner.Description)))
                {
                    context.Update(Partner);
                    context.SaveChanges();
                }
            }
        }
    }
}