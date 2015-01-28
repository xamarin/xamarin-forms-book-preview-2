using System;
using Xamarin.Forms;

namespace MetricalBoxView
{
    public class MetricalBoxViewPage : ContentPage
    {
        public MetricalBoxViewPage()
        {
            Content = new BoxView
            {
                Color = Color.Accent,
                WidthRequest = Device.OnPlatform(64, 64, 96),
                HeightRequest = Device.OnPlatform(160, 160, 240),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }
    }
}
