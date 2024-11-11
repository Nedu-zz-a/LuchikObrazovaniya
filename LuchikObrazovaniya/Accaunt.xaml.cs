using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static LuchikObrazovaniya.Accaunt;

namespace LuchikObrazovaniya
{
    /// <summary>
    /// Логика взаимодействия для Accaunt.xaml
    /// </summary>
    public partial class Accaunt : Window
    {

        private List<Student> students;
        public Accaunt()
        {
            InitializeComponent();
            MainWindow mainWindow = new MainWindow();
            FIO.Text = MainWindow.teacherFio;
            Napravlenie.Text = MainWindow.teacherNapr;
            if (MainWindow.teacherId == 0 || MainWindow.teacherId == 1)
            {
                for (int i = 0; i < 6; i++)
                {
                    FIO_Students.Items.Add(MainWindow.Students[i]);
                }
                List<Student> students = new List<Student>
                {

                    new Student { Name = MainWindow.Students[0], Grades = new List<int> { 5  }},
                    new Student { Name = MainWindow.Students[1], Grades = new List<int> { 5  }},
                    new Student { Name = MainWindow.Students[2], Grades = new List < int > { 5, 4 }},
                    new Student { Name = MainWindow.Students[3], Grades = new List < int > { 5, 4 }},
                    new Student { Name = MainWindow.Students[4], Grades = new List < int > { 5 }},
                    new Student { Name = MainWindow.Students[5], Grades = new List<int> { 5, 4 }},
                };
                gradesDataGrid.ItemsSource = students;
            }

            if (MainWindow.teacherId == 2 || MainWindow.teacherId == 3)
            {
                for (int i = 6; i < 12; i++)
                {
                    FIO_Students.Items.Add(MainWindow.Students[i]);
                }
                List<Student> students = new List<Student>
                {

                    new Student { Name = MainWindow.Students[6], Grades = new List<int> { 5 }},
                    new Student { Name = MainWindow.Students[7], Grades = new List<int> { 5 }},
                    new Student { Name = MainWindow.Students[8], Grades = new List < int > { 5 }},
                    new Student { Name = MainWindow.Students[9], Grades = new List < int > { 5 }},
                    new Student { Name = MainWindow.Students[10], Grades = new List < int > { 5 }},
                    new Student { Name = MainWindow.Students[11], Grades = new List < int > { 5 }},
                };
                gradesDataGrid.ItemsSource = students;

            }
            if (MainWindow.teacherId == 4 || MainWindow.teacherId == 5)
            {
                for (int i = 12; i < 18; i++)
                {
                    FIO_Students.Items.Add(MainWindow.Students[i]);
                }

                List<Student> students = new List<Student>
                {

                    new Student { Name = MainWindow.Students[12], Grades = new List < int > { 5}},
                    new Student { Name = MainWindow.Students[13], Grades = new List < int > { 5}},
                    new Student { Name = MainWindow.Students[14], Grades = new List < int > { 5}},
                    new Student { Name = MainWindow.Students[15], Grades = new List < int > { 5} },
                    new Student { Name = MainWindow.Students[16], Grades = new List < int > { 5 } },
                    new Student { Name = MainWindow.Students[17], Grades = new List < int > { 5}},
                };
                gradesDataGrid.ItemsSource = students;
            }
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void getmark_Click(object sender, RoutedEventArgs e)
        {
            string studentName = FIO_Students.Text;
            if (int.TryParse(Marks.Text, out int newGrade))
            {
                // Находим ученика по имени
                var student = students.FirstOrDefault(s => s.Name == studentName);
                if (student != null)
                {
                    student.Grades.Add(newGrade); // Добавляем новую оценку
                    gradesDataGrid.Items.Refresh(); // Обновляем таблицу
                }
                else
                {
                    MessageBox.Show("Ученик не найден.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректное значение для оценки.");
            }
        } 
    }



    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public List<int> Grades { get; set; } = new List<int>(); // Инициализируем список оценок

        // Свойство для отображения всех оценок в одной строке
        public string GradesAsString => string.Join(", ", Grades);
    }

}

