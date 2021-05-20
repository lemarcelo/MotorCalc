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
    public partial class CilindradaView : Shell
    {
        //#60D2B48C hexadecimal transparente transparent

        public CilindradaView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.CalculoVM();
            entryDiametro.Text = string.Empty;
            entryCurso.Text = string.Empty;
        }
    }
}