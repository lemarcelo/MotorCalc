using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MotorCalc.ViewModels;

namespace MotorCalc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MedidasView: ContentPage
    {
        public MedidasView()
        {
            InitializeComponent();
            BindingContext = new MedidasViewModel();
        }

        private void lvMedidas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
        }
    }
}