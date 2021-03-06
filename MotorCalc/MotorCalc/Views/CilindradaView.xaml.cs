using MotorCalc.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            lblResultadoCc.Text = "--";

            entryDiametro.Completed += (sender, e) => entryCurso.Focus();
            entryCurso.Completed += (sender, e) => Button_Clicked(sender, e);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
            lblResultadoCc.Text = "";
                double diametro = double.Parse(entryDiametro.Text);
                double curso = double.Parse(entryCurso.Text);
                lblResultadoCc.Text = (diametro * diametro * 3.14159 * curso / 4000).ToString("N2");
            }
            catch (Exception)
            {
                App.Current.MainPage.DisplayAlert("Erro", $"Verifique os campos", "Ok");
            }
            btnCalc.Focus();
        }
        void Foco()
        {
            entryCurso.Focus();
        }


        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    if (value is double val && val >= 1)
        //    {
        //        return decimal.Round((decimal)val, 2, MidpointRounding.AwayFromZero);
        //    }
        //    return value;
        //}

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    if (value is double val && val > 0)
        //    {
        //        return decimal.Round((decimal)val, 2, MidpointRounding.AwayFromZero);
        //    }
        //    return value;
        //}

    }
}