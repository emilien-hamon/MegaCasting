using MegaCasting.Class;
using System.Collections.ObjectModel;
using System.Linq;

namespace MegaCasting.ViewModel
{
    internal class InfoAnnouceViewModel
    {
        private Annouce _Annouce;

        public Annouce Annouce
        {
            get => _Annouce;
            set => _Annouce = value;
        }

        public InfoAnnouceViewModel(int identifierAnnouce)
        {
            using (DbMegacastingContext context = new())
            {
                Annouce = context.Annouces.First(partner => partner.ID == identifierAnnouce);
            }
        }
    }
}