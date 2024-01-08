using MegaCasting.Class;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    class UpdateUserViewModel
    {



        private User _User;

        public User User { get => _User; set => _User = value; }



        public UpdateUserViewModel(int identifierUser)
        {
            using (DbMegacastingContext context = new())
            {
                User = context.Users.First(userTemp  => userTemp.Id == identifierUser);
            }
        }


        internal void Update()
        {
            using (DbMegacastingContext context = new())
            {
                if (!(string.IsNullOrWhiteSpace(User.Email)
                   || string.IsNullOrWhiteSpace(User.Lastname)
                   || string.IsNullOrWhiteSpace(User.Firstname)
                   || string.IsNullOrWhiteSpace(User.Password)
                   )) {

                    context.Update(User);
                    context.SaveChanges();
                }
            }
        }
    }
}
