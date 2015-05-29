using System;
using System.Collections;
using Xamarin.Forms;

namespace ColorGroupList
{
    public partial class ColorGroupListPage : ContentPage
    {
        public ColorGroupListPage()
        {
            // Ensure link to Toolkit library.
            IEnumerable colorGroup = Xamarin.FormsBook.Toolkit.NamedColorGroup.All; 

            InitializeComponent();
        }
    }
}
