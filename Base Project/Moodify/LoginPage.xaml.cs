using Moodify.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Settings;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Moodify
{
    public partial class LoginPage : ContentPage
    {
        // Track whether the user has authenticated.
        bool authenticated = false;

        public LoginPage()
        {
            InitializeComponent();

        }
        private async void signUpClicked(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            var client = AzureManager.AzureManagerInstance.AzureClient;
            var userName = client.GetTable<User>();
            var check = await userName.Where(p => p.client == user).ToListAsync();
            if (check.Count == 0)
            {

                User emo = new User()
                {
                    client = user,
                    password = pass

                };


                await AzureManager.AzureManagerInstance.AddUser(emo);
                loginStack.Children.Clear();
                loggedInStack.IsVisible = true;
                LoggedLabel.Text = "Logged in as: " + user;
            }
            else
            {
                mainLabel.Text = "Username already exists";
            }
        }

        private async void loginClicked(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            var client = AzureManager.AzureManagerInstance.AzureClient;
            var userName = client.GetTable<User>();
            var check = await userName.Where(p => p.client == user && p.password == pass).ToListAsync();
            if (check.Count > 0)
            {

                this.loginStack.IsVisible = false;
                loginStack.Children.Clear();
                loggedInStack.IsVisible = true;
                //if (loggedIn == true) this.loginStack.IsVisible = false;
                LoggedLabel.Text = "Logged in as: " + user;
            }
        }
        private async void prefClicked(object sender, EventArgs e) {
            string prefs = pf.Text;
            string user = username.Text;
            

            Prefs pre = new Prefs()
            {
                Desc = prefs,
                client = user
            };
            await AzureManager.AzureManagerInstance.AddPrefs(pre);
            await DisplayAlert("Sent", "Your preferences have been sent", "OK");
            }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (authenticated == true)
            {
                // Hide the Sign-in button.
                this.loginButton.IsVisible = false;
                this.loginStack.IsVisible = true;

            }
        }

        async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (App.Authenticator != null)
                authenticated = await App.Authenticator.Authenticate();

            if (authenticated == true)
                this.loginButton.IsVisible = false;
        }



    }
}
