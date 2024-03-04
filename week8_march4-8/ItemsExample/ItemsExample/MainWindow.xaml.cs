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
            _election = new Election() {
                new Candidate("Mary"),
                new Candidate("George"),
                new Candidate("Eliza")};

            //what DataContext?
            DataContext = _election;
        }

        private void AddCandidate(object sender, RoutedEventArgs e)
        {
            //create a new candidate with entered name
            string name = CandName.Text;
            Candidate c = new Candidate(name);

            _election.Add(c);
        }

        private void CastVote(object sender, RoutedEventArgs e)
        {
            //add one to the corresponding candidate's vote

            //sender is the button that was clicked
            //sender.DataContext is the candidate I am voting for

            if (sender is Button b)
            {
                if (b.DataContext is Candidate c)
                {
                    c.Votes++;
                }
            }
        }
    }
}
