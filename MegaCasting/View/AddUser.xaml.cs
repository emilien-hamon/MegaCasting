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
    /// Logique d'interaction pour AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        // Constructeur de la fenêtre AddUser
        public AddUser()
        {
            InitializeComponent();

            // Définir le DataContext de la fenêtre sur une instance de AddUserViewModel
            this.DataContext = new AddUserViewModel();
        }

        // Gestionnaire d'événements pour l'événement click du bouton "AddUserButton"
        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Appeler la méthode Add de AddUserViewModel pour gérer la logique d'ajout
            ((AddUserViewModel)this.DataContext).Add();

            // Fermer la fenêtre courante après l'opération d'ajout
            this.Close();
        }
    }
}
