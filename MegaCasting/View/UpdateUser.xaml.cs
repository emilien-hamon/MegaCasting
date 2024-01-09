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
        // Constructeur de la fenêtre UpdateUser prenant un identifiant d'utilisateur en paramètre
        public UpdateUser(int identifierUser)
        {
            InitializeComponent();

            // Définir le DataContext de la fenêtre sur une instance de UpdateUserViewModel avec l'identifiant fourni
            this.DataContext = new UpdateUserViewModel(identifierUser);
        }

        // Gestionnaire d'événements pour l'événement click du bouton "UpdateUserButton"
        private void UpdateUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Appeler la méthode Update de UpdateUserViewModel pour gérer la logique de mise à jour
            ((UpdateUserViewModel)this.DataContext).Update();

            // Fermer la fenêtre courante après l'opération de mise à jour
            this.Close();
        }
    }
}
