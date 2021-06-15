using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MotorCalc.Services
{
    public class Calc : Behavior<Entry>
    {

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += CalcCc;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= CalcCc;
        }


        public void CalcCc( object sender, TextChangedEventArgs args)
        {
            App.Current.MainPage.DisplayAlert("Erro", $"Verifique os campos", $"Ok");
        }

    }
}
