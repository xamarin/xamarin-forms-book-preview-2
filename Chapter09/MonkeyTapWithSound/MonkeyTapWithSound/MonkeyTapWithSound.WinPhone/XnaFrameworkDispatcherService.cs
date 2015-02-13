using System;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Xna.Framework;

namespace MonkeyTapWithSound.WinPhone
{
    public class XnaFrameworkDispatcherService : IApplicationService
    {
        DispatcherTimer timer;

        public XnaFrameworkDispatcherService()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromTicks(333333);
            timer.Tick += OnTimerTick;
            FrameworkDispatcher.Update();
        }

        void OnTimerTick(object sender, EventArgs args)
        {
            FrameworkDispatcher.Update();
        }

        void IApplicationService.StartService(ApplicationServiceContext context)
        {
            timer.Start();
        }

        void IApplicationService.StopService()
        {
            timer.Stop();
        }
    }
}
