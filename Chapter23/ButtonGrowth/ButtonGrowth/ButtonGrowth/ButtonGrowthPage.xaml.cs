using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ButtonGrowth
{
    public partial class ButtonGrowthPage : ContentPage
    {
        public ButtonGrowthPage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.ScaleUpAndDownAction();

            InitializeComponent();
        }
    }
}
