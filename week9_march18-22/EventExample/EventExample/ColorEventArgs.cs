using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EventExample
{
    public class ColorEventArgs : RoutedEventArgs
    {
        public string ColorInfo { get; }

        public ColorEventArgs(string s)
        {
            ColorInfo = s;
        }
    }
}
