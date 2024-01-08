using MegaCasting.Class;
using MegaCasting.ViewModel;
using MegaCasting.View;
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


        // User

        private void InfosUserButton_Click(object sender, RoutedEventArgs e)
        {
            InfoUser window = new InfoUser((((Grid)((Button)sender).Parent).DataContext as User).Id);
            window.ShowDialog();
        }

        private void UpdateUserButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateUser window = new UpdateUser((((Grid)((Button)sender).Parent).DataContext as User).Id);
            window.ShowDialog();

            ((MainWindowViewModel)this.DataContext).Refresh();
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            /**
             * On récupère le parent du bouton, qui a pour dataContext l'utilisateur correspondant à la ligne.
             * On indique que cet utilisateur est celui qui est sélectionné.
             */
            User? user = ((MainWindowViewModel)this.DataContext).SelectedUser = (((Grid)((Button)sender).Parent).DataContext as User);

            // On supprime l'utilisateur sélectionné
            ((MainWindowViewModel)this.DataContext).RemoveUser();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            AddUser window = new AddUser();
            window.ShowDialog();

            ((MainWindowViewModel)this.DataContext).Refresh();
        }


        // Partner

        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            AddPartner window = new AddPartner();
            window.ShowDialog();

            ((MainWindowViewModel)this.DataContext).Refresh();
        }


        private void DeletePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            /**
             * On récupère le parent du bouton, qui a pour dataContext l'utilisateur correspondant à la ligne.
             * On indique que cet utilisateur est celui qui est sélectionné.
             */
            Partner? partner = ((MainWindowViewModel)this.DataContext).SelectedPartner = (((Grid)((Button)sender).Parent).DataContext as Partner);

            // On supprime l'utilisateur sélectionné
            ((MainWindowViewModel)this.DataContext).RemovePartner();
        }


        private void InfosPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            InfoPartner window = new InfoPartner((((Grid)((Button)sender).Parent).DataContext as Partner).ID);
            window.ShowDialog();
        }



        private void UpdatePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            UpdatePartner window = new UpdatePartner((((Grid)((Button)sender).Parent).DataContext as Partner).ID);
            window.ShowDialog();

            ((MainWindowViewModel)this.DataContext).Refresh();
        }
        // Annouce

        private void AddAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            AddAnnouce window = new AddAnnouce();
            window.ShowDialog();

            ((MainWindowViewModel)this.DataContext).Refresh();
        }


        private void DeleteAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            /**
             * On récupère le parent du bouton, qui a pour dataContext l'utilisateur correspondant à la ligne.
             * On indique que cet utilisateur est celui qui est sélectionné.
             */
            Annouce? annouce = ((MainWindowViewModel)this.DataContext).SelectedAnnouce = (((Grid)((Button)sender).Parent).DataContext as Annouce);

            // On supprime l'utilisateur sélectionné
            ((MainWindowViewModel)this.DataContext).RemoveAnnouce();
        }


        private void InfosAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            InfoAnnouce window = new InfoAnnouce((((Grid)((Button)sender).Parent).DataContext as Annouce).ID);
            window.ShowDialog();
        }



        private void UpdateAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateAnnouce window = new UpdateAnnouce((((Grid)((Button)sender).Parent).DataContext as Annouce).ID);
            window.ShowDialog();

            ((MainWindowViewModel)this.DataContext).Refresh();
        }
    }

}