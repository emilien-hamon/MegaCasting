using MegaCasting.Class;
using MegaCasting.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCasting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
               
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddUser window = new AddUser();
            window.ShowDialog();

            ((MainWindowViewModel)this.DataContext).Refresh();
        }

        private void InfosButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateUser window = new UpdateUser();
            window.ShowDialog();

            ((MainWindowViewModel)this.DataContext).Refresh();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            /**
             * On récupère le parent du bouton, qui a pour dataContext l'utilisateur correspondant à la ligne.
             * On indique que cet utilisateur est celui qui est sélectionné.
             */
            User? user = ((MainWindowViewModel)this.DataContext).SelectedUser = (((Grid)((Button)sender).Parent).DataContext as User);
            
            // On supprime l'utilisateur sélectionné
            ((MainWindowViewModel)this.DataContext).RemoveUser();
        }
    }
}
