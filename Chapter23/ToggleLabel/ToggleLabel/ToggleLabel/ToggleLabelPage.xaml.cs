using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ToggleLabel
{
    public partial class ToggleLabelPage : ContentPage
    {
        public ToggleLabelPage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.ToggleBehavior();

            InitializeComponent();
        }
    }
}
