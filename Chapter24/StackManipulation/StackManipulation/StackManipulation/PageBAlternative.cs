using System;
using Xamarin.Forms;

namespace StackManipulation
{
    public class PageBAlternative : ContentPage
    {
        public PageBAlternative()
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

            Title = "Page B Alt";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Page B Alt",
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
