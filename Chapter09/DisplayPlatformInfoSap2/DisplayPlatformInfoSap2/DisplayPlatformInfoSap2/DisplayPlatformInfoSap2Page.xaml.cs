using System;
using Xamarin.Forms;

namespace DisplayPlatformInfoSap2
{
    public partial class DisplayPlatformInfoSap2Page : ContentPage
    {
        public DisplayPlatformInfoSap2Page ()
        {
            InitializeComponent ();

            PlatformInfo platformInfo = new PlatformInfo();
            modelLabel.Text = platformInfo.GetModel();
            versionLabel.Text = platformInfo.GetVersion();
        }
    }
}
