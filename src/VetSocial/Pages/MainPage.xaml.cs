using VetSocial.Models;
using VetSocial.PageModels;

namespace VetSocial.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGetStartedClicked(object sender, EventArgs e)
        {
            // Navigate to dashboard/feed route
            await Shell.Current.GoToAsync("//feed");
        }
    }
}