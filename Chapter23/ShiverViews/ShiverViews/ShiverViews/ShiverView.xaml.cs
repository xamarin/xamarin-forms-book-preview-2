using System;
using Xamarin.Forms;

namespace ShiverViews
{
    public partial class ShiverView : BoxView
    {
        public ShiverView()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.TapBehavior();

            InitializeComponent();
        }
    }
}
