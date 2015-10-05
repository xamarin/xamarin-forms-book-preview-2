using System;
using Xamarin.Forms;

namespace StackManipulation
{
    public class PageB : ContentPage
    {
        public PageB()
        {
            Button button = new Button
            {
                Text = "Go to Page C",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new PageC());
            };

            Title = "Page B";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Page B",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        VerticalOptions=LayoutOptions.CenterAndExpand,
                        XAlign = TextAlignment.Center
                    },
                    button
                }
            };
        }
    }
}
