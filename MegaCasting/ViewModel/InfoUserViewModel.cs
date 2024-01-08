// InfoUserViewModel.cs
using MegaCasting.Class;
using System.Collections.ObjectModel;
using System.Linq;

namespace MegaCasting.ViewModel
{
    internal class InfoUserViewModel
    {
        private User _User;

        public User User
        {
            get => _User;
            set => _User = value;
        }

        public InfoUserViewModel(int identifierUser)
        {
            using (DbMegacastingContext context = new())
            {
                User = context.Users.First(user => user.Id == identifierUser);
            }
        }
    }
}