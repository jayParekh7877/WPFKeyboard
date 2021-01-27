using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfApp1.Annotations;
using WpfApp1.Command;
using WpfApp1.Keys;

namespace WpfApp1
{
    //https://stackoverflow.com/questions/7660547/how-to-create-bindable-commands-in-custom-control
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            LogicalKeysFirstRow = new List<ILogicalKey>()
            {
                new LogicalKey("Tab", Key.Tab, "", true, 50, 80),
                new LogicalKey("q", Key.Q, "Q"),
                new LogicalKey("w", Key.W, "W"),
                new LogicalKey("e", Key.E, "E"),
                new LogicalKey("r", Key.R, "R"),
                new LogicalKey("t", Key.T, "T"),
                new LogicalKey("y", Key.Y, "Y"),
                new LogicalKey("u", Key.U, "U"),
                new LogicalKey("i", Key.I, "I"),
                new LogicalKey("o", Key.O, "O"),
                new LogicalKey("p", Key.P, "P"),
                new LogicalKey("[", Key.OemOpenBrackets),
                new LogicalKey("]", Key.OemCloseBrackets),
                new LogicalKey("\\", Key.Separator),
                new LogicalKey("Del", Key.Delete),
            };

            LogicalKeysSecondRow = new List<ILogicalKey>()
            {
                new LogicalKey("Caps", Key.Capital, "", true, 50, 80),
                new LogicalKey("a", Key.A, "A"),
                new LogicalKey("s", Key.S, "S"),
                new LogicalKey("d", Key.D, "D"),
                new LogicalKey("f", Key.F, "F"),
                new LogicalKey("g", Key.G, "G"),
                new LogicalKey("h", Key.H, "H"),
                new LogicalKey("j", Key.J, "J"),
                new LogicalKey("k", Key.K, "K"),
                new LogicalKey("l", Key.L, "L"),
                new LogicalKey(";", Key.AbntC1),
                new LogicalKey("'", Key.AbntC1),
                new LogicalKey("Enter", Key.Enter, "", true, 50, 80),
            };

            LogicalKeysThirdRow = new List<ILogicalKey>()
            {
                new LogicalKey("Shift", Key.LeftShift, "", true, 50, 80),
                new LogicalKey("z", Key.Z, "Z"),
                new LogicalKey("x", Key.X, "X"),
                new LogicalKey("c", Key.C, "C"),
                new LogicalKey("v", Key.V, "V"),
                new LogicalKey("b", Key.B, "B"),
                new LogicalKey("n", Key.N, "N"),
                new LogicalKey("m", Key.M, "M"),
                new LogicalKey(",", Key.AbntC1),
                new LogicalKey(".", Key.AbntC1),
                new LogicalKey("?", Key.AbntC1),
                new LogicalKey("Shift", Key.RightShift, "", true, 50, 80),
            };
        }

        private ICommand _doSomething;
        public ICommand DoSomethingCommand
        {
            get
            {
                return _doSomething ?? (_doSomething = new RelayCommand(
                    p => true,
                    DoSomeImportantMethod));
            }
        }

        private void DoSomeImportantMethod(object obj)
        {
            
        }

        private List<ILogicalKey> _logicalKeysFirstRow;

        public List<ILogicalKey> LogicalKeysFirstRow
        {
            get => _logicalKeysFirstRow;
            set
            {
                if (value == null || _logicalKeysFirstRow == value) return;
                _logicalKeysFirstRow = value;
                OnPropertyChanged(nameof(LogicalKeysFirstRow));
            }
        }

        private List<ILogicalKey> _logicalKeysSecondRow;

        public List<ILogicalKey> LogicalKeysSecondRow
        {
            get => _logicalKeysSecondRow;
            set
            {
                if (value == null || _logicalKeysSecondRow == value) return;
                _logicalKeysSecondRow = value;
                OnPropertyChanged(nameof(LogicalKeysSecondRow));
            }
        }

        private List<ILogicalKey> _logicalKeysThirdRow;

        public List<ILogicalKey> LogicalKeysThirdRow
        {
            get => _logicalKeysThirdRow;
            set
            {
                if (value == null || _logicalKeysThirdRow == value) return;
                _logicalKeysThirdRow = value;
                OnPropertyChanged(nameof(LogicalKeysThirdRow));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}