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
    /// Logique d'interaction pour AddPartner.xaml
    /// </summary>
    public partial class AddPartner : Window
    {
        public AddPartner()
        {
            InitializeComponent();
            this.DataContext = new AddPartnerViewModel();
        }

        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            ((AddPartnerViewModel)this.DataContext).Add();
            this.Close();
        }
    }
}