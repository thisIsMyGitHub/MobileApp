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
            new Position(-36.848460, 174.763332), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;

            var pos = new Position(-36.848460, 174.763332);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = pos,
                Label = "Fabrikam",
                Address = "17 Address street"
            };
            map.Pins.Add(pin);
        }
    }
}
