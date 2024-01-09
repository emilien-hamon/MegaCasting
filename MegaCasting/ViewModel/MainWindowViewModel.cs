// Importation des espaces de noms nécessaires pour le programme
using MegaCasting.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Déclaration du namespace MegaCasting.ViewModel
namespace MegaCasting.ViewModel
{
    // Déclaration de la classe MainWindowViewModel
    class MainWindowViewModel
    {
        #region Fields

        // Déclaration d'une collection observable d'utilisateurs
        private ObservableCollection<User> _Users;

        // Déclaration d'un utilisateur sélectionné
        private User? _SelectedUser;

        // Déclaration d'une collection observable de partenaires
        private ObservableCollection<Partner> _Partners;

        // Déclaration d'un partenaire sélectionné
        private Partner? _SelectedPartner;

        // Déclaration d'une collection observable d'annonces
        private ObservableCollection<Annouce> _Annouces;

        // Déclaration d'une annonce sélectionnée
        private Annouce? _SelectedAnnouce;

        #endregion

        #region Properties

        // Propriété pour accéder à la collection d'utilisateurs
        public ObservableCollection<User> Users { get => _Users; set => _Users = value; }

        // Propriété pour accéder à l'utilisateur sélectionné
        public User? SelectedUser { get => _SelectedUser; set => _SelectedUser = value; }

        // Propriété pour accéder à la collection de partenaires
        public ObservableCollection<Partner> Partners { get => _Partners; set => _Partners = value; }

        // Propriété pour accéder au partenaire sélectionné
        public Partner? SelectedPartner { get => _SelectedPartner; set => _SelectedPartner = value; }

        // Propriété pour accéder à la collection d'annonces
        public ObservableCollection<Annouce> Annouces { get => _Annouces; set => _Annouces = value; }

        // Propriété pour accéder à l'annonce sélectionnée
        public Annouce? SelectedAnnouce { get => _SelectedAnnouce; set => _SelectedAnnouce = value; }

        #endregion

        #region Constructors

        // Constructeur de la classe MainWindowViewModel
        public MainWindowViewModel()
        {
            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Initialisation des collections observables avec les données de la base de données
                Users = new ObservableCollection<User>(context.Users.ToList());
                Partners = new ObservableCollection<Partner>(context.Partners.ToList());
                Annouces = new ObservableCollection<Annouce>(context.Annouces.ToList());
            }
        }

        #endregion

        #region Methods

        // Méthode interne pour mettre à jour un utilisateur dans la base de données
        internal void UpdateUser()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedUser);
                context.SaveChanges();
            }
        }

        // Méthode interne pour mettre à jour un partenaire dans la base de données
        internal void UpdatePartner()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedPartner);
                context.SaveChanges();
            }
        }

        // Méthode interne pour mettre à jour une annonce dans la base de données
        internal void UpdateAnnouce()
        {
            using (DbMegacastingContext context = new())
            {
                context.Update(SelectedAnnouce);
                context.SaveChanges();
            }
        }

        // Méthode interne pour ajouter un utilisateur dans la base de données
        internal void AddUser()
        {
            User user = new User();
            using (DbMegacastingContext context = new())
            {
                context.Users.Add(user);
                context.SaveChanges();
                Users.Add(user);
            }
        }

        // Méthode interne pour ajouter un partenaire dans la base de données
        internal void AddPartner()
        {
            Partner partner = new Partner();
            using (DbMegacastingContext context = new())
            {
                context.Partners.Add(partner);
                context.SaveChanges();
                Partners.Add(partner);
            }
        }

        // Méthode interne pour ajouter une annonce dans la base de données
        internal void AddAnnouce()
        {
            Annouce annouce = new Annouce();
            using (DbMegacastingContext context = new())
            {
                context.Annouces.Add(annouce);
                context.SaveChanges();
                Annouces.Add(annouce);
            }
        }

        // Méthode interne pour supprimer un utilisateur de la base de données
        internal void RemoveUser()
        {
            using (DbMegacastingContext context = new())
            {
                context.Users.Remove(SelectedUser);
                context.SaveChanges();
                Users.Remove(SelectedUser);
            }
        }

        // Méthode interne pour supprimer un partenaire de la base de données
        internal void RemovePartner()
        {
            using (DbMegacastingContext context = new())
            {
                context.Partners.Remove(SelectedPartner);
                context.SaveChanges();
                Partners.Remove(SelectedPartner);
            }
        }

        // Méthode interne pour supprimer une annonce de la base de données
        internal void RemoveAnnouce()
        {
            using (DbMegacastingContext context = new())
            {
                context.Annouces.Remove(SelectedAnnouce);
                context.SaveChanges();
                Annouces.Remove(SelectedAnnouce);
            }
        }

        // Méthode interne pour rafraîchir les données de toutes les collections observables
        internal void Refresh()
        {
            // Effacement des collections existantes
            this.Users.Clear();
            this.Partners.Clear();
            this.Annouces.Clear();

            // Utilisation d'un contexte DbContext pour interagir avec la base de données
            using (DbMegacastingContext context = new())
            {
                // Ajout des nouvelles données aux collections observables
                context.Users.ToList().ForEach(userTemp => this.Users.Add(userTemp));
                context.Partners.ToList().ForEach(partnerTemp => this.Partners.Add(partnerTemp));
                context.Annouces.ToList().ForEach(annouceTemp => this.Annouces.Add(annouceTemp));
            }
        }

        #endregion
    }
}
