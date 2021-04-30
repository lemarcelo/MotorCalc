using MotorCalc.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MotorCalc
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//PrincipalView");
        }
    }
}
