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
                List<Student> students = new List<Student>
                {

                    new Student { Name = MainWindow.Students[0], Grade = new List<int> { 5  }},
                    new Student { Name = MainWindow.Students[1], Grade = new List<int> { 5  }},
                    new Student { Name = MainWindow.Students[2], Grade = new List < int > { 5, 4 }},
                    new Student { Name = MainWindow.Students[3], Grade = new List < int > { 5, 4 }},
                    new Student { Name = MainWindow.Students[4], Grade = new List < int > { 5 }},
                    new Student { Name = MainWindow.Students[5], Grade = new List<int> { 5, 4 }},
                };
                gradesDataGrid.ItemsSource = students;
            }

            if (MainWindow.teacherId == 2 || MainWindow.teacherId == 3)
            {
                List<Student> students = new List<Student>
                {

                    new Student { Name = MainWindow.Students[6], Grade = new List<int> { 5 }},
                    new Student { Name = MainWindow.Students[7], Grade = new List<int> { 5 }},
                    new Student { Name = MainWindow.Students[8], Grade = new List < int > { 5 }},
                    new Student { Name = MainWindow.Students[9], Grade = new List < int > { 5 }},
                    new Student { Name = MainWindow.Students[10], Grade = new List < int > { 5 }},
                    new Student { Name = MainWindow.Students[11], Grade = new List < int > { 5 }},
                };
                gradesDataGrid.ItemsSource = students;

            }
            if (MainWindow.teacherId == 4 || MainWindow.teacherId == 5)
            {
                List<Student> students = new List<Student>
                {

                    new Student { Name = MainWindow.Students[12], Grade = new List < int > { 5}},
                    new Student { Name = MainWindow.Students[13], Grade = new List < int > { 5}},
                    new Student { Name = MainWindow.Students[14], Grade = new List < int > { 5}},
                    new Student { Name = MainWindow.Students[15], Grade = new List < int > { 5} },
                    new Student { Name = MainWindow.Students[16], Grade = new List < int > { 5 } },
                    new Student { Name = MainWindow.Students[17], Grade = new List < int > { 5}},
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
    }



    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public List<int> Grade { get; set; } = new List<int>(); // Инициализируем список оценок

        // Свойство для отображения всех оценок в одной строке
        public string GradesAsString => string.Join(", ", Grade);
    }

}

