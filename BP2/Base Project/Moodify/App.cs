using Xamarin.Forms;

namespace Moodify
{
	public partial class App : Application
	{

        public static NavigationPage NavigationPage { get; private set; }

        public App()
        {


            MainPage = new TabbedPage
            {
                
                Children =
                {
                    new HomePage(),
                    new MenuPage(),
                    new LoginPage(),
                    
                    
                }

            };
        }

        protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
