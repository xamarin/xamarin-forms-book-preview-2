using System;
using Xamarin.Forms;

namespace EmailValidationTrigger
{
    public partial class EmailValidationTriggerPage : ContentPage
    {
        public EmailValidationTriggerPage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.ValidEmailBehavior();

            InitializeComponent();
        }
    }
}
