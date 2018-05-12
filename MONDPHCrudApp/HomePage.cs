using MONDPHCrudApp.ViewModels;
using Xamarin.Forms;

namespace MONDPHCrudApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }
    }
}
