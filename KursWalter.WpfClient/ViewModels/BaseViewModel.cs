using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KursWalter.WpfClient
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void SetValueIfChanged<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            SetValueIfChanged(ref field, value, EqualityComparer<T>.Default, propertyName);
        }  
        protected void SetValueIfChanged<T>( ref T field, T value, IEqualityComparer<T> equalityComparer, [CallerMemberName] string propertyName = null)
        {
            if (equalityComparer == null) throw new ArgumentNullException("equalityComparer");
            if (equalityComparer.GetHashCode(field) == equalityComparer.GetHashCode(value) && equalityComparer.Equals(field, value))
                return;
            field = value;

            OnPropertyChanged(propertyName);
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
