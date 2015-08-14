using System;
using Xamarin.Forms;

namespace BoxViewTapShiver
{
    public partial class BoxViewTapShiverPage : ContentPage
    {
        public BoxViewTapShiverPage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.ShiverAction();

            InitializeComponent();
        }
    }
}
