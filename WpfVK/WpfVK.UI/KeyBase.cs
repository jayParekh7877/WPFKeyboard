using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfVK.UI.Annotations;

namespace WpfVK.UI
{
    public class KeyBase : IKey
    {
        private string _name;

        public virtual string Name
        {
            get => _name;
            set
            {
                if (_name != null && _name != value)
                    _name = value;
                OnPropertyChanged(Name);
            }
        }

        public virtual void Press()
        {
            KeyPressed?.Invoke(this, new KeyBaseEventArgs(this));
        }

        public event KeyPressedEventHandler KeyPressed;
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}