using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SourceEditor.Controls
{
   public class Notify: INotifyPropertyChanging, INotifyPropertyChanged
    {
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyChanging([CallerMemberName] string propertyName = null)
        {
            PropertyChangingEventHandler handler = PropertyChanging;
            if (handler != null) handler(this, new PropertyChangingEventArgs(propertyName));
        }
        public void NotifyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
