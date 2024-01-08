using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    class AddPartnerViewModel
    {



        private Partner _Partner;

        public Partner Partner { get => _Partner; set => _Partner = value; }



        public AddPartnerViewModel()
        {
            Partner = new Partner();
        }


        internal void Add()
        {
            using (DbMegacastingContext context = new())
            {
                if (!(string.IsNullOrWhiteSpace(Partner.Label)
                   || string.IsNullOrWhiteSpace(Partner.SIRET)
                   || string.IsNullOrWhiteSpace(Partner.Description)
                   ))
                {

                    context.Add(Partner);
                    context.SaveChanges();
                }
            }
        }
    }
}