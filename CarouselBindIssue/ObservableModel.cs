using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarouselBindIssue
{
    public class ObservableModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool SetProperty<T>(T newValue, ref T prop, [CallerMemberName] string propertyName = null)
        {
            if (newValue.Equals(prop)) return false;

            if (newValue == null) return false;

            prop = newValue;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            return true;
        }
    }
}
