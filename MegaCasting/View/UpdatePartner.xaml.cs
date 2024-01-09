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
    /// Logique d'interaction pour UpdatePartner.xaml
    /// </summary>
    public partial class UpdatePartner : Window
    {
        // Constructeur de la fenêtre UpdatePartner
        public UpdatePartner(int identifierPartner)
        {
            InitializeComponent();

            // Définir le DataContext de la fenêtre sur une instance de UpdatePartnerViewModel avec l'identifiant fourni
            this.DataContext = new UpdatePartnerViewModel(identifierPartner);
        }

        // Gestionnaire d'événements pour l'événement click du bouton "UpdatePartnerButton"
        private void UpdatePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Appeler la méthode Update de UpdatePartnerViewModel pour gérer la logique de mise à jour
            ((UpdatePartnerViewModel)this.DataContext).Update();

            // Fermer la fenêtre courante après l'opération de mise à jour
            this.Close();
        }
    }
}
