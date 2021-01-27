using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfVK.UI
{
    public interface IKey : INotifyPropertyChanged
    {
        string Name { get; }
        void Press();

        event KeyPressedEventHandler KeyPressed;
    }
}