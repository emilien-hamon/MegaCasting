// Importation des espaces de noms nécessaires pour le programme
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

// Déclaration du namespace MegaCasting
namespace MegaCasting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Constructeur de la classe MainWindow
        public MainWindow()
        {
            InitializeComponent();

            // Initialisation du contexte de données de la fenêtre avec une instance de MainWindowViewModel
            this.DataContext = new MainWindowViewModel();
        }

        // Bloc de gestion des événements liés aux utilisateurs

        private void InfosUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'informations sur l'utilisateur sélectionné
            InfoUser window = new InfoUser((((Grid)((Button)sender).Parent).DataContext as User).Id);
            window.ShowDialog();
        }

        private void UpdateUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre de mise à jour de l'utilisateur sélectionné
            UpdateUser window = new UpdateUser((((Grid)((Button)sender).Parent).DataContext as User).Id);
            window.ShowDialog();

            // Actualisation des données après la mise à jour
            ((MainWindowViewModel)this.DataContext).Refresh();
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Récupération de l'utilisateur correspondant à la ligne sélectionnée
            User? user = ((MainWindowViewModel)this.DataContext).SelectedUser = (((Grid)((Button)sender).Parent).DataContext as User);

            // Suppression de l'utilisateur sélectionné
            ((MainWindowViewModel)this.DataContext).RemoveUser();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'ajout d'utilisateur
            AddUser window = new AddUser();
            window.ShowDialog();

            // Actualisation des données après l'ajout
            ((MainWindowViewModel)this.DataContext).Refresh();
        }

        // Bloc de gestion des événements liés aux partenaires

        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'ajout de partenaire
            AddPartner window = new AddPartner();
            window.ShowDialog();

            // Actualisation des données après l'ajout
            ((MainWindowViewModel)this.DataContext).Refresh();
        }

        private void DeletePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Récupération du partenaire correspondant à la ligne sélectionnée
            Partner? partner = ((MainWindowViewModel)this.DataContext).SelectedPartner = (((Grid)((Button)sender).Parent).DataContext as Partner);

            // Suppression du partenaire sélectionné
            ((MainWindowViewModel)this.DataContext).RemovePartner();
        }

        private void InfosPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'informations sur le partenaire sélectionné
            InfoPartner window = new InfoPartner((((Grid)((Button)sender).Parent).DataContext as Partner).ID);
            window.ShowDialog();
        }

        private void UpdatePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre de mise à jour du partenaire sélectionné
            UpdatePartner window = new UpdatePartner((((Grid)((Button)sender).Parent).DataContext as Partner).ID);
            window.ShowDialog();

            // Actualisation des données après la mise à jour
            ((MainWindowViewModel)this.DataContext).Refresh();
        }

        // Bloc de gestion des événements liés aux annonces

        private void AddAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'ajout d'annonce
            AddAnnouce window = new AddAnnouce();
            window.ShowDialog();

            // Actualisation des données après l'ajout
            ((MainWindowViewModel)this.DataContext).Refresh();
        }

        private void DeleteAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            // Récupération de l'annonce correspondant à la ligne sélectionnée
            Annouce? annouce = ((MainWindowViewModel)this.DataContext).SelectedAnnouce = (((Grid)((Button)sender).Parent).DataContext as Annouce);

            // Suppression de l'annonce sélectionnée
            ((MainWindowViewModel)this.DataContext).RemoveAnnouce();
        }

        private void InfosAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'informations sur l'annonce sélectionnée
            InfoAnnouce window = new InfoAnnouce((((Grid)((Button)sender).Parent).DataContext as Annouce).ID);
            window.ShowDialog();
        }

        private void UpdateAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre de mise à jour de l'annonce sélectionnée
            UpdateAnnouce window = new UpdateAnnouce((((Grid)((Button)sender).Parent).DataContext as Annouce).ID);
            window.ShowDialog();

            // Actualisation des données après la mise à jour
            ((MainWindowViewModel)this.DataContext).Refresh();
        }
    }
}
