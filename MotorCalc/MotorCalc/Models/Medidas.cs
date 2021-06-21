using System;
using System.Collections.Generic;
using System.Text;

namespace MotorCalc.Models
{
    public class Medidas
    {
        private string _Descricao;

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

        private double _DiametroP;

        public double DiametroP
        {
            get { return _DiametroP; }
            set { _DiametroP = value; }
        }

        private double __Curso;

        public double Curso
        {
            get { return __Curso; }
            set { __Curso = value; }
        }

    }
}
