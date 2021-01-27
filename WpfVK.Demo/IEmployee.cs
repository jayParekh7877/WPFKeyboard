using System.ComponentModel;

namespace WpfVK.Demo
{
    public interface IEmployee : INotifyPropertyChanged
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        bool IsSelectedData { get; set; }

        void Clicked();
    }
}