using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(MonkeyTapWithSound.WinPhone81.PlatformSoundPlayer))]

namespace MonkeyTapWithSound.WinPhone81
{
    public class PlatformSoundPlayer : IPlatformSoundPlayer
    {
        WinRuntimeShared.SharedSoundPlayer sharedSoundPlayer;

        public void PlaySound(int samplingRate, byte[] pcmData)
        {
            if (sharedSoundPlayer == null)
            {
                sharedSoundPlayer = new WinRuntimeShared.SharedSoundPlayer();
            }

            sharedSoundPlayer.PlaySound(samplingRate, pcmData);
        }
    }
}

