using System;
using Xamarin.Forms;

#if __IOS__
using UIKit;

#elif __ANDROID__
using Android.OS;

#elif WINDOWS_PHONE
using Microsoft.Phone.Info;

#endif

namespace DisplayPlatformInfoSap1
{
	public partial class DisplayPlatformInfoSap1Page : ContentPage
    {
		public DisplayPlatformInfoSap1Page ()
        {
            InitializeComponent ();

#if __IOS__

            UIDevice device = new UIDevice();
            modelLabel.Text = device.Model.ToString();
            versionLabel.Text = String.Format("{0} {1}", device.SystemName, 
                                                         device.SystemVersion);

#elif __ANDROID__

            modelLabel.Text = String.Format("{0} {1}", Build.Manufacturer, 
                                                       Build.Model);
            versionLabel.Text = Build.VERSION.Release.ToString();

#elif WINDOWS_PHONE

            modelLabel.Text = String.Format("{0} {1}", DeviceStatus.DeviceManufacturer, 
                                                       DeviceStatus.DeviceName);
            versionLabel.Text = Environment.OSVersion.ToString();

#endif

        }
    }
}
