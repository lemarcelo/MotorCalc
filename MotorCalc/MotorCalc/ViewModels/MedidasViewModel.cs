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
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 125", DiametroP = "56,5", Curso = "49,5" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 150", DiametroP = "57,3", Curso = "57,8" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 150 Kit 190cc", DiametroP = "64,5", Curso = "57,8" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 150 Kit Setentão 225cc", DiametroP = "70", Curso = "57,8" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XTZ/YBR 125", DiametroP = "54", Curso = "54" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Twister/Tornado", DiametroP = "73", Curso = "59.5" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XTZ 250 - Lander, Fazer...", DiametroP = "74", Curso = "58" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XR200", DiametroP = "63,5", Curso = "62,2" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Bros OHC", DiametroP = "63,5", Curso = "49,5" });
        }
    }
}
