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
        public MedidasView()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public ObservableCollection<Medidas> ListMedidas = new ObservableCollection<Medidas>
        {
            new Medidas
            {
                Pistao = 1,
                Cilindro = 2
            }
        };





    }
}