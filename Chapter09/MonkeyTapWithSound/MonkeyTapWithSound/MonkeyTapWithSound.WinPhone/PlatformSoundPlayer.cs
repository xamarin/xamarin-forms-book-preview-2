using System;
using Microsoft.Xna.Framework.Audio;
using Xamarin.Forms;

[assembly: Dependency(typeof(MonkeyTapWithSound.WinPhone.PlatformSoundPlayer))]

namespace MonkeyTapWithSound.WinPhone
{
    public class PlatformSoundPlayer : IPlatformSoundPlayer
    {
        public void PlaySound(int samplingRate, byte[] pcmData)
        {
            DynamicSoundEffectInstance playback = 
                new DynamicSoundEffectInstance(samplingRate, AudioChannels.Mono);

            playback.SubmitBuffer(pcmData);
            playback.Play();
        }
    }
}
