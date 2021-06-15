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
            entryCilindrada.Text = string.Empty;
            entryVolume.Text = string.Empty;
            lblResultadoCompr.Text = "--";


            entryCilindrada.Completed += (sender, e) => entryVolume.Focus();
            entryVolume.Completed += (sender, e) => Button_Clicked(sender, e);
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            try
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
                    lblResultadoCompr.Text = ((cilindrada + volume) / volume).ToString("N2");
                }
                btnCalc.Focus();
            }
            catch (Exception)
            {
                App.Current.MainPage.DisplayAlert("Erro", $"Verifique os campos", "Ok");
            }
        }
        
    }
}