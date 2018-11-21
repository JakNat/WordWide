using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WordWide.UI.ViewModel
{
    //TO DO  INotifyPropertyChanged
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //TO DO callerMemberName
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
