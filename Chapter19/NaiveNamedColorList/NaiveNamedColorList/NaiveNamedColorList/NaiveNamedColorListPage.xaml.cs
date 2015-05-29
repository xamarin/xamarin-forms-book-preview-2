using System;
using Xamarin.Forms;

namespace NaiveNamedColorList
{
    public partial class NaiveNamedColorListPage : ContentPage
    {
        public NaiveNamedColorListPage()
        {
            // Ensure link to library.
            Color color = Xamarin.FormsBook.Toolkit.NamedColor.AliceBlue;

            InitializeComponent();
        }
    }
}
