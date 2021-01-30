using GurpsCard.Models;
using GurpsCard.Services;
using GurpsCard.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GurpsCard.ViewModels
{
    public class CardsViewModel : BaseViewModel
    {
        public ObservableCollection<Card> Card {get;set;}

        public CardStore CardStore { get; set; }

        private Type type;

        public CardsViewModel(Type type)
        {
            CardStore = new CardStore();
            this.type = type;
        }

        public void LoadCards()
        {
            foreach (var card in CardStore.Cards.Where(c => c.GetType() == type))
            {     
                    Card.Add(card);
            }
        }
    }
}