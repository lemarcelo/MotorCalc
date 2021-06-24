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
            CollectionMedidas.Add(new Medidas() { DiametroP = "Diâmetro Pistão", Curso = "Curso Vb." });
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 150", DiametroP = "57,3 mm", Curso = "57,8 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 150 Kit 190cc", DiametroP = "64,5 mm", Curso = "57,8 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 150 Kit Setentão 225cc", DiametroP = "70 mm", Curso = "57, 8mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XTZ/YBR 125", DiametroP = "54 mm", Curso = "54 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Twister/Tornado", DiametroP = "73 mm", Curso = "59. 5mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XTZ 250 - Lander, Fazer...", DiametroP = "74 mm", Curso = "58 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XR200", DiametroP = "63,5 mm", Curso = "62,2 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Bros OHC", DiametroP = "63,5 mm", Curso = "49,5 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "CRF 230", DiametroP = "65,5 mm", Curso = "66,2 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XT 225", DiametroP = "70 mm", Curso = "58 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Twister 293", DiametroP = "79 mm", Curso = "59,5 mm" });










            //CollectionMedidas.Add(new Medidas() { Descricao = "", DiametroP = "mm", Curso = "mm" });



        }
    }
}
