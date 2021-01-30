using GurpsCard.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GurpsCard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardsDetailView : ContentPage
    {
        public CardsViewModel ViewModel;
        public CardsDetailView(Type type)
        {
            InitializeComponent();
            BindingContext = ViewModel = new CardsViewModel(type);
        }
    }
}