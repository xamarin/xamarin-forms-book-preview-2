using System;
using Xamarin.Forms;

namespace StackManipulation
{
    public class PageA : ContentPage
    {
        public PageA()
        {
            Button button = new Button
            {
                Text = "Go to Page B",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new PageB());
            };

            Title = "Page A";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Page A",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        VerticalOptions=LayoutOptions.CenterAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center
                    },
                    button
                }
            };
        }
    }
}
