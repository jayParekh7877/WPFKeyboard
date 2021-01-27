using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfVK.Demo.Annotations;

namespace WpfVK.Demo
{
    public class Employee : IEmployee
    {
        public Employee(string firstName, string lastName, bool isSelected)
        {
            FirstName = firstName;
            LastName = lastName;
            IsSelectedData = isSelected;
        }


        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName != null || _firstName == value) return;
                {
                    _firstName = value;
                    OnPropertyChanged(FirstName);
                }
            }
        }

        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName != null || _lastName == value) return;
                {
                    _lastName = value;
                    OnPropertyChanged(LastName);
                }
            }
        }

        private bool _isSelectedData;

        public bool IsSelectedData
        {
            get => _isSelectedData;
            set
            {
                if (_isSelectedData == value) return;
                _isSelectedData = value;
                OnPropertyChanged(nameof(IsSelectedData));
            }
        }

        public void Clicked()
        {
            Control.Keyboard.Type(Key.A);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}