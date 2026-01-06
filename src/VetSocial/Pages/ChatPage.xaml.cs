using System.Collections.ObjectModel;

namespace VetSocial.Pages
{
    public partial class ChatPage : ContentPage
    {
        private ObservableCollection<string> _messages = new();

        public ChatPage()
        {
            InitializeComponent();
            BindingContext = new { Messages = _messages };
        }

        private void OnSendClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MessageEntry.Text))
            {
                _messages.Add(MessageEntry.Text);
                MessageEntry.Text = string.Empty;
            }
        }
    }
}
