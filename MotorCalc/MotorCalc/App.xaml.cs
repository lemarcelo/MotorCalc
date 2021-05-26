using MotorCalc.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotorCalc
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new PrincipalView();
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
