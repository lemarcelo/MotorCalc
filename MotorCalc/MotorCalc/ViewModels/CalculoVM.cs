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
        private float _Diametro;

        public float Diametro
        {
            get { return _Diametro; }
            set { _Diametro = value;
                OnPropertyChanged();
            }
        }

        private float _Curso;

        public float Curso
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

        private double _Resultado;

        public double Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value;
                OnPropertyChanged();
            }
        }
        public ICommand CilindradaCalc => new Command( () =>  CilindradaFunc(Diametro, Curso));
        #endregion
        public CalculoVM()
        {

        }

        private void CilindradaFunc(double Diametro, double Curso)
        {
            Resultado = Diametro * Diametro * 3.14159 * Curso / 4000;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
