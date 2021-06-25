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
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 150", DiametroP = "57,3 mm", Curso = "57,8 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 150 Kit 190cc", DiametroP = "64,5 mm", Curso = "57,8 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Titan 150 Kit Setentão 225cc", DiametroP = "70 mm", Curso = "57, 8 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XTZ/YBR 125", DiametroP = "54 mm", Curso = "54 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Twister/Tornado", DiametroP = "73 mm", Curso = "59. 5 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XTZ 250 - Lander, Fazer...", DiametroP = "74 mm", Curso = "58 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "CB Twister CRF 250f", DiametroP = "71 mm", Curso = "63,03 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XR200", DiametroP = "63,5 mm", Curso = "62,2 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Bros OHC", DiametroP = "63,5 mm", Curso = "49,5 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "CRF 230", DiametroP = "65,5 mm", Curso = "66,2 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "XT 225", DiametroP = "70 mm", Curso = "58 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Twister 291", DiametroP = "79 mm", Curso = "59,5 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "CB 300", DiametroP = "79 mm", Curso = "59,5 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "Falcon 400", DiametroP = "85 mm", Curso = "70 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "CBR 250r", DiametroP = "76 mm", Curso = "55 mm" });
            CollectionMedidas.Add(new Medidas() { Descricao = "CG 160 Titan/Start", DiametroP = "57,3 mm", Curso = "63 mm" });










            //CollectionMedidas.Add(new Medidas() { Descricao = "", DiametroP = "mm", Curso = "mm" });



        }
    }
}
