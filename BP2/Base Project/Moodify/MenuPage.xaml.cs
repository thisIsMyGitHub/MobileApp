using Moodify.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Moodify
{
    public partial class MenuPage : ContentPage
    {

        public MenuPage()
        {
            InitializeComponent();
        }

        // order buttons
        private void OrderPizza(object sender, EventArgs e)
        { 
            int x = Int32.Parse(pizzaOrder.Text);
            x++;
            pizzaOrder.Text = x.ToString();

        }
        private void OrderPasta(object sender, EventArgs e)
        {
            int x = Int32.Parse(pastaOrder.Text);
            x++;
            pastaOrder.Text = x.ToString();
        }
        private void OrderBurger(object sender, EventArgs e)
        {
            int x = Int32.Parse(burgerOrder.Text);
            x++;
            burgerOrder.Text = x.ToString();
        }
        private void OrderCola(object sender, EventArgs e)
        {
            int x = Int32.Parse(colaOrder.Text);
            x++;
            colaOrder.Text = x.ToString();
        }


        //down buttons
        private void downPizza(object sender, EventArgs e)
        {
            int x = Int32.Parse(pizzaOrder.Text);
            if (x > 0) x--;
            pizzaOrder.Text = x.ToString();

        }
        private void downPasta(object sender, EventArgs e)
        {
            int x = Int32.Parse(pastaOrder.Text);
            if (x>0)x--;
            pastaOrder.Text = x.ToString();
        }
        private void downBurger(object sender, EventArgs e)
        {
            int x = Int32.Parse(burgerOrder.Text);
            if (x > 0) x--;
            burgerOrder.Text = x.ToString();
        }
        private void downCola(object sender, EventArgs e)
        {
            int x = Int32.Parse(colaOrder.Text);
            if (x > 0) x--;
            colaOrder.Text = x.ToString();
        }

        private async void Confirm(object sender, EventArgs e)
        {
            Order ord = new Order()
            {
                pizza = pizzaOrder.Text,
                pasta = pastaOrder.Text,
                burger = burgerOrder.Text,
                cola = colaOrder.Text

            };

            await AzureManager.AzureManagerInstance.AddOrder(ord);
            await DisplayAlert("Confirmed", "Order Placed", "OK");

            pizzaOrder.Text = "0";
            pastaOrder.Text = "0";
            burgerOrder.Text = "0";
            colaOrder.Text = "0";
        }




    }
}
