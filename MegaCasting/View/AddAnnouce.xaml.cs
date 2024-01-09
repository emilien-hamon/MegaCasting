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
    /// Logique d'interaction pour AddAnnouce.xaml
    /// </summary>
    public partial class AddAnnouce : Window
    {
        // Constructeur de la fenêtre AddAnnouce
        public AddAnnouce()
        {
            InitializeComponent();

            // Définir le DataContext de la fenêtre sur une instance de AddAnnouceViewModel
            this.DataContext = new AddAnnouceViewModel();
        }

        // Gestionnaire d'événements pour l'événement click du bouton "AddAnnouceButton"
        private void AddAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            // Appeler la méthode Add de AddAnnouceViewModel pour gérer la logique d'ajout
            ((AddAnnouceViewModel)this.DataContext).Add();

            // Fermer la fenêtre courante après l'opération d'ajout
            this.Close();
        }
    }
}
