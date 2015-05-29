using System;
using Xamarin.Forms;

namespace PickerBinding
{
    public partial class PickerBindingPage : ContentPage
    {
        public PickerBindingPage()
        {
            // Ensure link to library.
            new Xamarin.FormsBook.Toolkit.ObjectToIndexConverter<bool>();

            InitializeComponent();
        }
    }
}
