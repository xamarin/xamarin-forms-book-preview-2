using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CustomNamedColorList
{
    public partial class CustomNamedColorListPage : ContentPage
    {
        public CustomNamedColorListPage()
        {
            // Ensure link to Toolkit library.
            Color color = Xamarin.FormsBook.Toolkit.NamedColor.AliceBlue;

            InitializeComponent();
        }
    }
}
