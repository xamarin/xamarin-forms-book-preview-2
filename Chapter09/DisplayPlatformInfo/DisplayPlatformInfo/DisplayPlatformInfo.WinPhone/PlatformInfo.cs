using System;
using Microsoft.Phone.Info;
using Xamarin.Forms;

[assembly: Dependency(typeof(DisplayPlatformInfo.WinPhone.PlatformInfo))]

namespace DisplayPlatformInfo.WinPhone
{
    public class PlatformInfo : IPlatformInfo
    {
        public string GetModel()
        {
            return String.Format("{0} {1}", DeviceStatus.DeviceManufacturer, 
                                            DeviceStatus.DeviceName);
        }

        public string GetVersion()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
