using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Moodify
{
    public partial class mapsPage : ContentPage
    {

        public mapsPage()
        {
            bool t = true;
            
            InitializeComponent();
            var map = new Map(
            MapSpan.FromCenterAndRadius(
            new Position(37, -122), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

        }
    }
}
