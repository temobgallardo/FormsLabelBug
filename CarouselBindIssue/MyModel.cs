namespace CarouselBindIssue
{
    public class MyModel : ObservableModel
    {
        private string _name = "MyModel";
        private decimal _price = 35;

        public string Name { get => _name; set => SetProperty(value, ref _name); }
        public decimal Price { get => _price; set => SetProperty(value, ref _price); }
    }
}
