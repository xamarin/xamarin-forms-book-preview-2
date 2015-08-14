using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EmailValidationConverter
{
    public partial class EmailValidationConverterPage : ContentPage
    {
        public EmailValidationConverterPage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.ValidEmailBehavior();

            InitializeComponent();
        }
    }
}
