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
            Routing.RegisterRoute("volume", typeof(CompressaoInv));

        }
    }
}