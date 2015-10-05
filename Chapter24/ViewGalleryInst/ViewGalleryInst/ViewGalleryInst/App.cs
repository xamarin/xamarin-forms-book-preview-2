using System;
using Xamarin.Forms;

namespace ViewGalleryInst
{
    public class App : Application
    {
        public App()
        {
            // Ensure link to Toolkit library.
            Color color = Xamarin.FormsBook.Toolkit.NamedColor.AliceBlue;

            MainPage = new NavigationPage(new ViewGalleryInstPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
