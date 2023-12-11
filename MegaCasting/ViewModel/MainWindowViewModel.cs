using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.ViewModel
{
    class MainWindowViewModel
    {

        #region Fields

        private ObservableCollection<User> _Users;

        private User? _SelectedUser;

        #endregion

        #region Properties

        public ObservableCollection<User> Users { get => _Users; set => _Users = value; }

        public User? SelectedUser { get => _SelectedUser; set => _SelectedUser = value; }

        #endregion

        #region Constructors


        public MainWindowViewModel()
        {
            using (DbMegacastingContext context = new())
            {
                Users = new ObservableCollection<User>(context.Users.ToList());
            }
        }

        #endregion


        internal void UpdateUser()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedUser);
                context.SaveChanges();
            }
        }


        internal void AddUser()
        {
            User user = new User();
            using (DbMegacastingContext context = new())
            {
                context.Users.Add(user);
                context.SaveChanges();
                Users.Add(user);
            }
        }



        internal void RemoveUser()
        {

            using (DbMegacastingContext context = new())
            {
                context.Users.Remove(SelectedUser);
                context.SaveChanges();
                Users.Remove(SelectedUser);
            }
        }
    
        internal void Refresh()
        {
            this.Users.Clear();

            using (DbMegacastingContext context = new())
            {
                context.Users.ToList().ForEach(userTemp => this.Users.Add(userTemp));
            }
        }
    
    }
}
