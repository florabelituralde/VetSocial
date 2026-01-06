using Microsoft.Maui.Authentication;
using Microsoft.Maui.Storage;

namespace VetSocial.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Stubbed ID.me flow: will try web auth, but if endpoints are not real, simulate success.
            var authUrl = new Uri("https://example.invalid/auth/idme/start");
            var callbackUrl = new Uri("vetsocial://auth/callback");
            try
            {
                var result = await WebAuthenticator.AuthenticateAsync(authUrl, callbackUrl);
                // Normally exchange tokens here. Store a placeholder JWT if result is empty.
                var token = result?.AccessToken ?? "dummy-jwt-token";
                await SecureStorage.SetAsync("auth_token", token);
                await Shell.Current.GoToAsync("//main");
            }
            catch
            {
                // Fallback: simulate a successful login so app can be explored without real backend.
                await SecureStorage.SetAsync("auth_token", "dummy-jwt-token");
                await VetSocial.AppShell.DisplayToastAsync("Simulated login. Configure ID.me later.");
                await Shell.Current.GoToAsync("//main");
            }
        }
    }
}
