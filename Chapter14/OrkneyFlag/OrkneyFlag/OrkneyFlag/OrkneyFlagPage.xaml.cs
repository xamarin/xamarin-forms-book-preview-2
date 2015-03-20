using System;
using Xamarin.Forms;

namespace OrkneyFlag
{
    public partial class OrkneyFlagPage : ContentPage
    {
        public OrkneyFlagPage()
        {
            InitializeComponent();

            // Flag has red background.
            absoluteLayout.BackgroundColor = Color.Red;

            // Vertical yellow fimbriation starts at
            //      a position of 6/22 on the X axis,
            //      and is 4/22 units wide.
            absoluteLayout.Children.Add(
                new BoxView
                {
                    Color = Color.Yellow
                },
                new Rectangle((6.0 / 22) / (1 - 4.0 / 22),  // fractional conversion formula
                              0,
                              4.0 / 22,
                              1),
                AbsoluteLayoutFlags.All);

            // Horizontal yellow fimbriation starts at
            //      a position of 6/16 on the Y axis,
            //      is is 4/16 units tall.
            absoluteLayout.Children.Add(
                new BoxView
                {
                    Color = Color.Yellow
                },
                new Rectangle(0,
                              (6.0 / 16) / (1 - 4.0 / 16),  // fractional conversion formula = 0.5
                              1,
                              4.0 / 16),
                AbsoluteLayoutFlags.All);

            // Vertical part of blue Nordic cross starts
            //      at 7/22 and is 2/22 units wide. 
            absoluteLayout.Children.Add(
                new BoxView
                {
                    Color = Color.Blue
                },
                new Rectangle((7.0 / 22) / (1 - 2.0 / 22),  // fractional conversion formula
                              0,
                              2.0 / 22,
                              1),
                AbsoluteLayoutFlags.All);

            // Horizontal part of blue Nordic cross starts
            //      at 7/16 and is 2/16 units wide. 
            absoluteLayout.Children.Add(
                new BoxView
                {
                    Color = Color.Blue
                },
                new Rectangle(0,
                              (7.0 / 16) / (1 - 2.0 / 16),  // fractional conversion formula = 0.5
                              1,
                              2.0 / 16),
                AbsoluteLayoutFlags.All);
        }

        void OnContentViewSizeChanged(object sender, EventArgs args)
        {
            ContentView contentView = (ContentView)sender;

            // Flag is 22 units wide and 16 units tall. 
            double unit = Math.Min(contentView.Width / 22, contentView.Height / 16);
            absoluteLayout.WidthRequest = 22 * unit;
            absoluteLayout.HeightRequest = 16 * unit;
        }
    }
}