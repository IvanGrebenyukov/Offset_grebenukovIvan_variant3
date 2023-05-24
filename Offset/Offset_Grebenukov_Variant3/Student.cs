using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offset_Grebenukov_Variant3
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Scores { get; set; }
        public Student(int id, string name, List<int> scores)
        {
            Id = id;
            Name = name;
            Scores = scores;
        }
        public int GetTotalScores ()
        {
            return Scores.Sum();
        }
    }
}
