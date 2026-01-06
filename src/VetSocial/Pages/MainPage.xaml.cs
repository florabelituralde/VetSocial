using VetSocial.Models;
using VetSocial.PageModels;

namespace VetSocial.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}