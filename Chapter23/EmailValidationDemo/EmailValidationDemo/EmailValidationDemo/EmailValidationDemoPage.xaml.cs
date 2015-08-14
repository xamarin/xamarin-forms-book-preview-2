using System;
using Xamarin.Forms;

namespace EmailValidationDemo
{
    public partial class EmailValidationDemoPage : ContentPage
    {
        public EmailValidationDemoPage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.ValidEmailBehavior();

            InitializeComponent();
        }
    }
}
