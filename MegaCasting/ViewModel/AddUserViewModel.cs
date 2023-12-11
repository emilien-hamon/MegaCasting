using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    class AddUserViewModel
    {



        private User _User;

        public User User { get => _User; set => _User = value; }



        public AddUserViewModel()
        {
            User = new User();  
        }


        internal void Add()
        {
            using (DbMegacastingContext context = new())
            {
                context.Add(User);
                context.SaveChanges();
            }
        }
    }
}
