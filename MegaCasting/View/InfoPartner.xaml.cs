﻿using MegaCasting.ViewModel;
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
    /// Logique d'interaction pour InfoPartner.xaml
    /// </summary>
    public partial class InfoPartner : Window
    {
        // Constructeur de la fenêtre InfoPartner 
        public InfoPartner(int identifierPartner)
        {
            InitializeComponent();

            // Définir le DataContext de la fenêtre sur une instance de InfoPartnerViewModel avec l'identifiant fourni
            this.DataContext = new InfoPartnerViewModel(identifierPartner);
        }
    }
}
