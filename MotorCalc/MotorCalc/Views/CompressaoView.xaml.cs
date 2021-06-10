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
            lblResultadoCompr.Text = "--";
        }


        private void Button_Clicked(object sender, EventArgs e)
        {

            lblResultadoCompr.Text = "";
            double cilindrada = double.Parse(entryCilindrada.Text);
            double volume = double.Parse(entryVolume.Text);


            if (cilindrada < 1 || volume < 1)
            {
                lblResultadoCompr.Text = "--";
            }
            else
            {
                lblResultadoCompr.Text = ((cilindrada + volume) / volume).ToString("#,##");
            }
            btnCalc.Focus();
        }
    }
}