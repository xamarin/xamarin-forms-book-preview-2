using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ShiverButtonDemo
{
    public partial class ShiverButtonDemoPage : ContentPage
    {
        public ShiverButtonDemoPage()
        {
            // Ensure link to Toolkit library.
            new Xamarin.FormsBook.Toolkit.ShiverAction();

            InitializeComponent();
        }
    }
}
