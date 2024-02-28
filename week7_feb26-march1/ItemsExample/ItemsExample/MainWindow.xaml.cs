using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ItemsExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ObservableCollection<Person>()
            {
                new Person("Alice"), new Person("James")
            };
        }

        private void AddName(object sender, RoutedEventArgs e)
        {
            //if I clicked Add Mary, I want to add Mary to my list
            if (DataContext is ObservableCollection<Person> list && sender is Button b)
            {
                if (b.Name == "MaryButton")
                {
                    //now I can access b.Name
                    list.Add(new Person("Mary"));
                }
                else if (b.Name == "JohnButton")
                {
                    //now I can access b.Name
                    list.Add(new Person("John"));
                }
                else if (b.Name == "GloriaButton")
                {
                    //now I can access b.Name
                    list.Add(new Person("Gloria"));
                }
            }
        }
    }
}
