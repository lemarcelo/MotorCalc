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
    public partial class VMPView : Shell
    {
        public VMPView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.CalculoVM();
        }
    }
}