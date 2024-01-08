using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                if (!(string.IsNullOrWhiteSpace(User.Email)
                   || string.IsNullOrWhiteSpace(User.Lastname)
                   || string.IsNullOrWhiteSpace(User.Firstname)
                   || string.IsNullOrWhiteSpace(User.Password)
                   ))
                {

                    context.Add(User);
                    context.SaveChanges();
                }
            }
        }
    }
}
