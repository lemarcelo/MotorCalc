﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotorCalc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompressaoInv : Shell
    {
        public CompressaoInv()
        {
            InitializeComponent();
            BindingContext = new ViewModels.CalculoVM();
            lblResultadoCompr.Text = "--";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
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
        }
    }
}