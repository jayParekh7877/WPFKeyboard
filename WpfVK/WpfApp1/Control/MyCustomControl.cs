using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Control
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfApp1.Control"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfApp1.Control;assembly=WpfApp1.Control"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:MyCustomControl/>
    ///
    /// </summary>
    public class MyCustomControl : Button
    {
        static MyCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCustomControl),
                new FrameworkPropertyMetadata(typeof(MyCustomControl)));
        }

        public static readonly DependencyProperty IsHotKeyProperty = DependencyProperty.Register(
            "IsHotKey", typeof(bool), typeof(MyCustomControl), new PropertyMetadata(default(bool)));

        public bool IsHotKey
        {
            get { return (bool) GetValue(IsHotKeyProperty); }
            set { SetValue(IsHotKeyProperty, value); }
        }

        public static readonly DependencyProperty KeyNameProperty = DependencyProperty.Register(
            "KeyName", typeof(string), typeof(MyCustomControl), new PropertyMetadata(default(string)));

        public string KeyName
        {
            get { return (string) GetValue(KeyNameProperty); }
            set { SetValue(KeyNameProperty, value); }
        }

        public static readonly DependencyProperty KeyCapitalNameProperty = DependencyProperty.Register(
            "KeyCapitalName", typeof(string), typeof(MyCustomControl), new PropertyMetadata(default(string)));

        public string KeyCapitalName
        {
            get { return (string) GetValue(KeyCapitalNameProperty); }
            set { SetValue(KeyCapitalNameProperty, value); }
        }

        public static readonly DependencyProperty ClickCommandProperty = DependencyProperty.Register(
            "ClickCommand", typeof(ICommand), typeof(MyCustomControl), new PropertyMetadata(default(ICommand)));

        public ICommand ClickCommand
        {
            get { return (ICommand) GetValue(ClickCommandProperty); }
            set { SetValue(ClickCommandProperty, value); }
        }
    }
}