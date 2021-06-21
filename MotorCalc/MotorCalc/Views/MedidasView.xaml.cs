using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MotorCalc.Models;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace MotorCalc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MedidasView: ContentPage
    {
        public ObservableCollection<Medidas> ListMedidas;
        public MedidasView()
        {
            InitializeComponent();
            BindingContext = this;
            ListMedidas = new ObservableCollection<Medidas>
            {
                new Medidas
                {
                    Descricao = "Lander 250(XTZ 250)",
                    DiametroP = 74,
                    Curso = 58
                }
            };
        }


        ObservableCollection<Medidas> ReturnMedidas { get { return ListMedidas; } }
        
    }
}