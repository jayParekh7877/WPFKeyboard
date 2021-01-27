using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVK.UI
{
    public class KeyBaseEventArgs : EventArgs
    {
        public IKey Key { get; private set; }

        public KeyBaseEventArgs(IKey key)
        {
            Key = key;
        }
    }

    public delegate void KeyPressedEventHandler(object sender, KeyBaseEventArgs e);

    
}