using System.Collections.ObjectModel;

namespace VetSocial.Pages
{
    public class FeedItem
    {
        public string Author { get; set; } = "";
        public string Text { get; set; } = "";
    }

    public class FeedViewModel
    {
        public ObservableCollection<FeedItem> Posts { get; } = new();
        public FeedViewModel()
        {
            // Seed with sample posts so UI works without backend
            Posts.Add(new FeedItem { Author = "Alice", Text = "Welcome to VetSocial" });
            Posts.Add(new FeedItem { Author = "Bob", Text = "First post!" });
        }
    }

    public partial class FeedPage : ContentPage
    {
        public FeedPage()
        {
            InitializeComponent();
            BindingContext = new FeedViewModel();
        }
    }
}
