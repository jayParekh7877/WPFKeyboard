using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp1.Keys
{
    public interface ILogicalKey : INotifyPropertyChanged
    {
        string Name { get; set; }

        string CapitalName { get; set; }

        bool IsHotKey { get; set; }

        int Height { get; set; }

        int Width { get; set; }

        bool IsShiftPressed { get; set; }

        Key Key { get; set; }
    }
}