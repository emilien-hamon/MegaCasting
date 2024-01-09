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
        // Constructeur de la fenêtre UpdateAnnouce
        public UpdateAnnouce(int identifierAnnouce)
        {
            InitializeComponent();

            // Définir le DataContext de la fenêtre sur une instance de UpdateAnnouceViewModel avec l'identifiant fourni
            this.DataContext = new UpdateAnnouceViewModel(identifierAnnouce);
        }

        // Gestionnaire d'événements pour l'événement click du bouton "UpdateAnnouceButton"
        private void UpdateAnnouceButton_Click(object sender, RoutedEventArgs e)
        {
            // Appeler la méthode Update de UpdateAnnouceViewModel pour gérer la logique de mise à jour
            ((UpdateAnnouceViewModel)this.DataContext).Update();

            // Fermer la fenêtre courante après l'opération de mise à jour
            this.Close();
        }
    }
}
