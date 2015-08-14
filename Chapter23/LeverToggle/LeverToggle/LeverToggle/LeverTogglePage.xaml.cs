using System;
using Xamarin.Forms;

namespace LeverToggle
{
    public partial class LeverTogglePage : ContentPage
    {
        public LeverTogglePage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.ToggleBase();

            InitializeComponent();
        }
    }
}
