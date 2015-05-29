using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewHeader
{
    public partial class ListViewHeaderPage : ContentPage
    {
        public ListViewHeaderPage()
        {
            // Ensure link to library.
            new ElPasoHighSchool.SchoolViewModel();

            InitializeComponent();
        }
    }
}
