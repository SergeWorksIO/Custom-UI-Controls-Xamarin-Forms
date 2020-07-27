using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DateEntryField
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ControlTestPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
