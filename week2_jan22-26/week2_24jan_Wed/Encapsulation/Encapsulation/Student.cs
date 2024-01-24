using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation
{
    public class Student
    {
        public string Name { get; set; }

        public string Major { get; set; }

        private List<int> _scores = new();

        public void AddScore(int score)
        {
            _scores.Add(score);
        }

        public int Average
        {
            get
            {
                int sum = 0;
                foreach (int score in _scores)
                {
                    sum += score;
                }

                return sum / _scores.Count;
            }
        }
    }
}
