using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MotorCalc.Controllers
{
    public class NumericEntry : Entry
    {
        //Correção ISSUE #11815 https://github.com/xamarin/Xamarin.Forms/pull/11815/files

        #region Bindables
        public static readonly BindableProperty NumericValueProperty = BindableProperty.Create(
            "NumericValue",
            typeof(decimal?),
            typeof(NumericEntry),
            null,
            BindingMode.TwoWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                SetDisplayFormat((NumericEntry)bindable);
            }
        );

        public static readonly BindableProperty NumericValueFormatProperty = BindableProperty.Create(
            "NumericValueFormat",
            typeof(string),
            typeof(NumericEntry),
            "N0",
            BindingMode.TwoWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                SetDisplayFormat((NumericEntry)bindable);
            }
        );
        #endregion

        #region Constructor
        public NumericEntry()
        {
            Keyboard = Keyboard.Numeric;
            //Focused += OnFocused;
            //Unfocused += OnUnfocused;
        }
        #endregion

        #region Events
        private void OnFocused(object sender, FocusEventArgs e)
        {
            SetEditFormat(this);
        }

        private void OnUnfocused(object sender, FocusEventArgs e)
        {
            var numberFormant = CultureInfo.InvariantCulture.NumberFormat;
            var _text = Text.Replace(numberFormant.NumberGroupSeparator, string.Empty).Replace(numberFormant.NumberDecimalSeparator, ",");

            if (decimal.TryParse(_text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal numericValue))
            {
                int round = Convert.ToInt32(NumericValueFormat.Substring(1));
                NumericValue = Math.Round(numericValue, round);
            }
            else
            {
                NumericValue = null;
            }

            SetDisplayFormat(this);
        }
        #endregion

        #region Properties
        public decimal? NumericValue
        {
            get { return (decimal?)GetValue(NumericValueProperty); }
            set { SetValue(NumericValueProperty, value); }
        }

        public string NumericValueFormat
        {
            get { return (string)GetValue(NumericValueFormatProperty) ?? "N0"; }
            set
            {
                var _value = string.IsNullOrWhiteSpace(value) ? "N0" : value;
                SetValue(NumericValueFormatProperty, value);
            }
        }
        #endregion

        #region Methods
        private static void SetDisplayFormat(NumericEntry textBox)
        {
            if (textBox.NumericValue.HasValue)
            {
                textBox.Text = textBox.NumericValue.Value.ToString(textBox.NumericValueFormat, CultureInfo.DefaultThreadCurrentCulture);
            }
            else
            {
                textBox.Text = string.Empty;
            }
        }

        private static void SetEditFormat(NumericEntry textBox)
        {
            if (textBox.NumericValue.HasValue)
            {
                var numberFormant = CultureInfo.InvariantCulture.NumberFormat;
                textBox.Text = textBox.NumericValue.Value.ToString(textBox.NumericValueFormat, CultureInfo.InvariantCulture).Replace(numberFormant.NumberGroupSeparator, string.Empty);
            }
            else
            {
                textBox.Text = string.Empty;
            }
        }
        #endregion
    }
}