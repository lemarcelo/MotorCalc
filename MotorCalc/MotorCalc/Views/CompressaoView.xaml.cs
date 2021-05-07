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
    public partial class CompressaoView : Shell
    {
        public CompressaoView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.CalculoVM();
            entryCilindrada.Text = string.Empty;
            entryVolume.Text = string.Empty;
        }
    }
}