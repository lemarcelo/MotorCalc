using System;
using System.Collections.Generic;
using System.Text;

namespace MotorCalc.ViewModels
{
    public class CalculoVM
    {
        private float _Diametro;

        public float Diametro
        {
            get { return _Diametro; }
            set { _Diametro = value; }
        }

        private float _Curso;

        public float Curso
        {
            get { return _Curso; }
            set { _Curso = value; }
        }

        private int _Cilindros;

        public int Cilindros
        {
            get { return _Cilindros; }
            set { _Cilindros = value; }
        }



    }
}
