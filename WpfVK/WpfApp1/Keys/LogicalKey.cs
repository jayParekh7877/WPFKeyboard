using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfApp1.Annotations;

namespace WpfApp1.Keys
{
    public class LogicalKey : ILogicalKey
    {
        public LogicalKey(string name, Key key, string capitalName = "",
            bool isHotKey = false, int height = 50,
            int width = 50, bool isShiftPressed = false)
        {
            Name = name;
            IsHotKey = isHotKey;
            Height = height;
            Width = width;
            Key = key;
            CapitalName = capitalName;
            IsShiftPressed = isShiftPressed;
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value != null && _name != value)
                {
                    _name = value;
                    OnPropertyChanged(Name);
                }
            }
        }

        private string _capitalName;

        public string CapitalName
        {
            get => _capitalName;
            set
            {
                if (_capitalName != value)
                {
                    _capitalName = value;
                    OnPropertyChanged(CapitalName);
                }
            }
        }

        private bool _isHotKey;

        public bool IsHotKey
        {
            get => _isHotKey;
            set
            {
                if (_isHotKey != value)
                {
                    _isHotKey = value;
                    OnPropertyChanged(nameof(IsHotKey));
                }
            }
        }

        private int _height;

        public int Height
        {
            get => _height;
            set
            {
                if (value == _height) return;
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }

        private int _width;

        public int Width
        {
            get => _width;
            set
            {
                if (value == _width) return;
                _width = value;
                OnPropertyChanged(nameof(Width));
            }
        }

        private bool _isShiftPressed;

        public bool IsShiftPressed
        {
            get => _isShiftPressed;
            set
            {
                if (_isShiftPressed != value)
                {
                    _isShiftPressed = value;
                    OnPropertyChanged(nameof(IsShiftPressed));
                }
            }
        }

        private Key _key;

        public Key Key
        {
            get => _key;
            set
            {
                if (_key != value)
                {
                    _key = value;
                    OnPropertyChanged(nameof(Key));
                }
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