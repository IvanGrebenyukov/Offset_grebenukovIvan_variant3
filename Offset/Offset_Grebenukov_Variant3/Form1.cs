using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Offset_Grebenukov_Variant3
{
    public partial class Form1 :Form
    {
        private List<Student> students;
        public Form1 ()
        {
            InitializeComponent( );
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            LoadDataFromFile( );
            LoadDataGrid( );
        }
        private void LoadDataFromFile ()
        {
            students = new List<Student>();
            string filePath = "student.txt";
            try
            {
                if ( File.Exists(filePath) )
                {
                    string [ ] lines = File.ReadAllLines(filePath);
                    foreach ( string line in lines )
                    {
                        string [ ] parts = line.Split(',');
                        int id = int.Parse(parts [ 0 ]);
                        string name = parts [ 1 ];
                        List<int> scores = parts.Skip(2).Select(int.Parse).ToList( );
                        students.Add(new Student(id, name, scores));
                    }
                }
                else
                {
                    MessageBox.Show("Файл не существует");
                }
              
            }
            catch
            {
                
            }
        }
        public void LoadDataGrid ()
        {


            dataGridViewData.ColumnCount = 5;
            dataGridViewData.Columns [ 0 ].Name = "Идентификатор";
            dataGridViewData.Columns [ 1 ].Name = "Фио";
            dataGridViewData.Columns [ 2 ].Name = "Дисциплина 1";
            dataGridViewData.Columns [ 3 ].Name = "Дисциплина 2";
            dataGridViewData.Columns [ 4 ].Name = "Дисциплина 3";
            foreach(Student student in students )
            {
                string [ ] row = new string [ ]
                {
                    student.Id.ToString(),
                    student.Name,
                    student.Scores[0].ToString(),
                    student.Scores[1].ToString(),
                    student.Scores[2].ToString(),

                };
                dataGridViewData.Rows.Add(row);
            }
           
        }
        private void FindMaxScore ()
        {
            int selectedSubject = int.Parse(comboBox1.SelectedItem.ToString( ));
            var query = from student in students
                        where student.Scores [ selectedSubject - 1] == 100
                        orderby student.Name descending
                        select new
                        {
                            student.Id,
                            student.Name,
                            student.Scores, 
                            TotalScore = student.GetTotalScores()
                        };
            listBoxFindMaxScore.Items.Clear( );
            foreach(var student in query )
            {
                listBoxFindMaxScore.Items.Add($"Идентификатор: {student.Id}, Имя: {student.Name}, Баллы: ({student.Scores[0]} + {student.Scores[1]} + {student.Scores[2]}) = {student.TotalScore}");
            }
        }
        public void AddNewStudent ()
        {
            int id = Convert.ToInt32(numericUpDownId.Value);
            string name = textBoxFIO.Text;
            int score1 = Convert.ToInt32(numericUpDownDis1.Value);
            int score2 = Convert.ToInt32(numericUpDownDis2.Value);
            int score3 = Convert.ToInt32(numericUpDownDis3.Value);
            if (students.Any(s => s.Id == id))
            {
                MessageBox.Show("Студент с таким идентификатором уже существует");
                return;
            }
            if ( name.Any(char.IsDigit) )
            {
                MessageBox.Show("Нельзя вводить цифры");
                return;
            }
            Student newStudent = new Student(id, name, new List<int> { score1, score2, score3 });
            students.Add(newStudent);
            string [ ] row = new string [ ]
            {
                newStudent.Id.ToString(),
                newStudent.Name,
                newStudent.Scores[0].ToString(),
                newStudent.Scores[1].ToString(),
                newStudent.Scores[2].ToString()

            };
            dataGridViewData.Rows.Add(row);
            string filePath = "student.txt";
            if ( File.Exists(filePath) )
            {
                using ( StreamWriter writer = new StreamWriter(filePath, true) )
                {
                    writer.WriteLine($"{newStudent.Id},{newStudent.Name},{score1},{score2},{score3}");
                }
                MessageBox.Show("Новый студент добавлен");
            }
            else
            {
                MessageBox.Show("Файл не существует");
            }

        }
        private bool IsUniqueId(int id)
        {
            return students.All(student => student.Id != id);
        }
        private void textBox2_TextChanged (object sender, EventArgs e)
        {

        }

        private void buttonNewStudent_Click (object sender, EventArgs e)
        {
            AddNewStudent( );
        }

        private void buttonFind_Click (object sender, EventArgs e)
        {
            FindMaxScore( );
        }
    }
}
