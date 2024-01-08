using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    class AddAnnouceViewModel
    {



        private Annouce _Annouce;

        public Annouce Annouce { get => _Annouce; set => _Annouce = value; }



        public AddAnnouceViewModel()
        {
            Annouce = new Annouce();
        }


        internal void Add()
        {
            using (DbMegacastingContext context = new())
            {
                if (!(string.IsNullOrWhiteSpace(Annouce.Title)
                   || string.IsNullOrWhiteSpace(Annouce.Content)
                   ))
                {

                    context.Add(Annouce);
                    context.SaveChanges();
                }
            }
        }
    }
}