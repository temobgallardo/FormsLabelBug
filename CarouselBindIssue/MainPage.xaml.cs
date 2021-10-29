using Xamarin.Forms;

namespace CarouselBindIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MyViewModel();
        }
    }
}
