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
        private Election _election;
        public MainWindow()
        {
            InitializeComponent();

            _election = new Election(new string[] { "Mary", "John", "Gloria" });
            
            //what DataContexts?
        }

        private void CastVote(object sender, RoutedEventArgs e)
        {
            //if I clicked Add Mary, I want to add Mary to my list

            //how to get the (Election) DataContext?
            if (sender is Button b)
            {
                //b.Name contains the candidate name to add
                
            }
        }
    }
}
