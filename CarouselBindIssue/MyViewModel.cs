using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarouselBindIssue
{
    public class MyViewModel : INotifyPropertyChanged
    {
        private int _index;
        private MyModel _current;

        public MyModel Current
        {
            get => _current;
            set
            {
                _current = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Current)));
            }
        }
        public ObservableCollection<MyModel> MyModels { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public MyViewModel()
        {
            MyModels = new ObservableCollection<MyModel>()
            {
                new MyModel{Name = "Model A", Price = 1},
                new MyModel{Name = "Model B", Price = 5},
                //new MyModel{Name = "Model C", Price = 10},
                new MyModel{Name = "Model D", Price = 20},
            };
        }

        private Command changeBindingCommand;

        public ICommand ChangeBindingCommand
        {
            get
            {
                if (changeBindingCommand == null)
                {
                    changeBindingCommand = new Command(ChangeBinding);
                }

                return changeBindingCommand;
            }
        }

        private void ChangeBinding()
        {
            _index++;
            if (_index >= MyModels.Count)
            {
                _index = 0;
            }

            Current = MyModels[_index];
        }
    }
}
