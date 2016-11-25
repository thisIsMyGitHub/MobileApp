using Moodify.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Moodify
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }



        private async void mapCLicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new mapsPage());
        }
        protected override async void OnAppearing()
        {
            List<News> newss = await AzureManager.AzureManagerInstance.GetNews();
            NewsList.ItemsSource = newss;

            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

    }
}
