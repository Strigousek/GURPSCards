using GurpsCard.ViewModels;
using GurpsCard.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GurpsCard
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CardsDetailView), typeof(CardsDetailView));         
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
