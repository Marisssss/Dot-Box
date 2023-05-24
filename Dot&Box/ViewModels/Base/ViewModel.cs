using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Box.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged

{
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
    }

    protected virtual bool Set<T>(ref T fied, T value, [CallerMemberName] string PropertyName = null)
    {
        if (Equals(fied, value)) return false;
        fied = value;
        OnPropertyChanged(PropertyName);
        return true;
    }
}

}