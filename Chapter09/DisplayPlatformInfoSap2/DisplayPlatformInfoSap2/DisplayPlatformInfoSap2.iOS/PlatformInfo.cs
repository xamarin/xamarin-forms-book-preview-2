using System;
using UIKit;

namespace DisplayPlatformInfoSap2
{
    public class PlatformInfo
    {
        UIDevice device = new UIDevice();

        public string GetModel()
        {
            return device.Model.ToString();
        }

        public string GetVersion()
        {
            return String.Format("{0} {1}", device.SystemName, 
                                            device.SystemVersion);
        }
    }
}
