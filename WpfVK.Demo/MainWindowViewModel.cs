using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfVK.Demo.Annotations;

namespace WpfVK.Demo
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            Employees = new List<IEmployee> {new Employee("a", "A", false), new Employee("b", "B", true)};
        }

        private List<IEmployee> _employees;

        public List<IEmployee> Employees
        {
            get => _employees;
            set
            {
                if (_employees != null && _employees == value) return;
                _employees = value;
                OnPropertyChanged(nameof(Employees));
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