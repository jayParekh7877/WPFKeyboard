using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfVK.Demo.Control
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfVK.Demo.Control"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfVK.Demo.Control;assembly=WpfVK.Demo.Control"
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

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            EmployeeData.Clicked();
            base.OnMouseDown(e);
        }

        public static readonly DependencyProperty EmployeeDataProperty = DependencyProperty.Register(
            "EmployeeData", typeof(IEmployee), typeof(MyCustomControl), new PropertyMetadata(default(IEmployee)));

        public IEmployee EmployeeData
        {
            get { return (IEmployee) GetValue(EmployeeDataProperty); }
            set { SetValue(EmployeeDataProperty, value); }
        }



        public static readonly DependencyProperty IsHotKeyProperty = DependencyProperty.Register(
            "IsHotKey", typeof(bool), typeof(MyCustomControl), new UIPropertyMetadata(default(bool),OnPropertyChangedCallBackdata));

        private static void OnPropertyChangedCallBackdata(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var keyboard = (MyCustomControl)d;
            keyboard.IsHotKey = (bool)e.NewValue;
        }

        public bool IsHotKey
        {
            get { return (bool) GetValue(IsHotKeyProperty); }
            set { SetValue(IsHotKeyProperty, value); }
        }

        public static readonly DependencyProperty FirstProperty = DependencyProperty.Register(
            "First", typeof(string), typeof(MyCustomControl), new PropertyMetadata(default(string)));

        public string First
        {
            get { return (string) GetValue(FirstProperty); }
            set { SetValue(FirstProperty, value); }
        }

        public static readonly DependencyProperty LastProperty = DependencyProperty.Register(
            "Last", typeof(string), typeof(MyCustomControl), new PropertyMetadata(default(string)));

        public string Last
        {
            get { return (string) GetValue(LastProperty); }
            set { SetValue(LastProperty, value); }
        }

    }
}