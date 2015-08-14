using System;
using Xamarin.Forms;

namespace TriggerEntryValidation
{
    public partial class TriggerEntryValidationPage : ContentPage
    {
        public TriggerEntryValidationPage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.NumericValidationAction();

            InitializeComponent();
        }
    }
}
