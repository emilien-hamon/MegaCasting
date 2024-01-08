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
    /// Logique d'interaction pour UpdateAnnouce.xaml
    /// </summary>
    public partial class UpdateAnnouce : Window
    {
        public UpdateAnnouce(int identifierAnnouce)
        {
            InitializeComponent();
            this.DataContext = new UpdateAnnouceViewModel(identifierAnnouce);
        }

        private void UpdateAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            ((UpdateAnnouceViewModel)this.DataContext).Update();
            this.Close();
        }
    }
}
