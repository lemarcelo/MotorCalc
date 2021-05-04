using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotorCalc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : Shell
    {
        public PrincipalView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.PrincipalVM();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Shell.Current.GoToAsync()
        }
    }
}