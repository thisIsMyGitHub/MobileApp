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
        private async void ViewTimeline_Clicked(Object sender, EventArgs e)
        {
            List<Timeline> timelines = await AzureManager.AzureManagerInstance.GetTimelines();

            TimelineList.ItemsSource = timelines;

        }
    }
}
