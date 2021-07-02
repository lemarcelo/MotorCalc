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

        private string _PinoP;
        public string PinoP
        {
            get { return _PinoP; }
            set { _PinoP = value; }
        }
        private string _DiametroP;
        public string DiametroP
        {
            get { return _DiametroP; }
            set { _DiametroP = value; }
        }

        private string _Curso;
        public string Curso
        {
            get { return _Curso; }
            set { _Curso = value; }
        }

    }
}
