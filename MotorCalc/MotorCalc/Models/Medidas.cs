using System;
using System.Collections.Generic;
using System.Text;

namespace MotorCalc.Models
{
    public class Medidas
    {
        private double _Pistao;

        public double Pistao
        {
            get { return _Pistao; }
            set { _Pistao = value; }
        }

        private double _Cilindro;

        public double Cilindro
        {
            get { return _Cilindro; }
            set { _Cilindro = value; }
        }

    }
}
