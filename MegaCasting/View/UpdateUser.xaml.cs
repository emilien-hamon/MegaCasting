using MegaCasting.Class;
using MegaCasting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MegaCasting.View
{
    /// <summary>
    /// Logique d'interaction pour UpdateUser.xaml
    /// </summary>
    public partial class UpdateUser : Window
    {
        public UpdateUser(int identifierUser)
        {
            InitializeComponent();
            this.DataContext = new UpdateUserViewModel(identifierUser);
        }

        private void UpdateUserButton_Click(object sender, RoutedEventArgs e)
        {
            ((UpdateUserViewModel)this.DataContext).Update();
            this.Close();
        }
    }
}
