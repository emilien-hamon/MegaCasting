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
        // Constructeur de la fenêtre AddPartner
        public AddPartner()
        {
            InitializeComponent();

            // Définir le DataContext de la fenêtre sur une instance de AddPartnerViewModel
            this.DataContext = new AddPartnerViewModel();
        }

        // Gestionnaire d'événements pour l'événement click du bouton "AddPartnerButton"
        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Appeler la méthode Add de AddPartnerViewModel pour gérer la logique d'ajout
            ((AddPartnerViewModel)this.DataContext).Add();

            // Fermer la fenêtre courante après l'opération d'ajout
            this.Close();
        }
    }
}
