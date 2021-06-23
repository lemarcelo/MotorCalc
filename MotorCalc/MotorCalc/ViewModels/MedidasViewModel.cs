using MotorCalc.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MotorCalc.ViewModels
{
    public class MedidasViewModel
    {
        private ObservableCollection<Medidas> _CollectionMedidas;

        public ObservableCollection<Medidas> CollectionMedidas
        {
            get { return _CollectionMedidas; }
            set { _CollectionMedidas = value; }
        }

        public MedidasViewModel()
        {
            CollectionMedidas = new ObservableCollection<Medidas>();
            CollectionMedidas.Add(new Medidas() { Descricao = "Twister", Curso = "59.5", DiametroP = "73" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XTZ 250", Curso = "58", DiametroP = "74" });
        }
    }
}
