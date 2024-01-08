using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Tls;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    internal class UpdateAnnouceViewModel
    {



        private Annouce _Annouce;

        public Annouce Annouce { get => _Annouce; set => _Annouce = value; }



        public UpdateAnnouceViewModel(int identifierAnnouce)
        {
            using (DbMegacastingContext context = new())
            {
                Annouce = context.Annouces.First(AnnouceTemp => AnnouceTemp.ID == identifierAnnouce);
            }
        }


        internal void Update()
        {
            using (DbMegacastingContext context = new())
            {
                if (!(string.IsNullOrWhiteSpace(Annouce.Title)
                   || string.IsNullOrWhiteSpace(Annouce.Content)))
                {
                    context.Update(Annouce);
                    context.SaveChanges();
                }
            }
        }
    }
}