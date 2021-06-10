using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MotorCalc.ViewModels
{
    public class CalculoVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        #region Props
        private double _Diametro;

        public double Diametro
        {
            get { return _Diametro; }
            set { _Diametro = value;
                OnPropertyChanged();
            }
        }

        private double _Curso;

        public double Curso
        {
            get { return _Curso; }
            set { _Curso = value;
                OnPropertyChanged();
            }
        }

        private int _Cilindros;

        public int Cilindros
        {
            get { return _Cilindros; }
            set { _Cilindros = value;
                OnPropertyChanged();
            }
        }
        private double _ResultadoCc;

        public double ResultadoCc
        {
            get { return _ResultadoCc; }
            set
            {
                _ResultadoCc = value;
                OnPropertyChanged();
            }
        }
        private double _Cilindrada;

        public double Cilindrada
        {
            get { return _Cilindrada; }
            set { _Cilindrada = value;
                OnPropertyChanged();
            }
        }
        private double _Volume;

        public double Volume
        {
            get { return _Volume; }
            set { _Volume = value;
                OnPropertyChanged();
            }
        }

        private double _ResultadoCompr;
        public double ResultadoCompr
        {
            get { return _ResultadoCompr; }
            set { _ResultadoCompr = value;
                OnPropertyChanged();
            }
        }
        public ICommand CilindradaCalc => new Command(() => CilindradaFunc(Diametro, Curso));
        public ICommand CompressaoCalc => new Command(() => CompressaoFunc(Cilindrada, Volume));
        //public ICommand VolumeCalc
        //    =>
        //    new Command(() => Shell.Current.GoToAsync($"{Atual.Location}/volume"));


        //ShellNavigationState Atual = Shell.Current.CurrentState;

        #endregion
        public CalculoVM()
        {
            //ResultadoCc = 249.45;
        }


        private void CilindradaFunc(double Diametro, double Curso)
        {

            try
            {
                ResultadoCc = Diametro * Diametro * 3.14159 * Curso / 4000;
            }
            catch (Exception e)
            {
                App.Current.MainPage.DisplayAlert("Erro", $"{e.Message}", "Ok");
            }
        }
        private void CompressaoFunc(double Cilindrada, double Volume)
        {
            if (Cilindrada < 1 || Volume < 1)
            {
                ResultadoCompr = 0;
            }
            else
            {
                ResultadoCompr = (Cilindrada + Volume) / Volume;
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
