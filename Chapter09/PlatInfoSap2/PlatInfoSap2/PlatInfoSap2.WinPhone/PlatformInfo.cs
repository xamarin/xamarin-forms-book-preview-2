using System;
using Microsoft.Phone.Info;

namespace PlatInfoSap2
{
    public class PlatformInfo
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
