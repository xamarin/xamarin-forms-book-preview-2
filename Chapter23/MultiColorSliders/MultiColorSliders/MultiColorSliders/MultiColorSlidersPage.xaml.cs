using System;
using Xamarin.Forms;

namespace MultiColorSliders
{
    public partial class MultiColorSlidersPage : ContentPage
    {
        public MultiColorSlidersPage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.ColorViewModel();

            InitializeComponent();
        }
    }
}
