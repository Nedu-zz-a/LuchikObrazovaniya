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

        double[] a1 = new double[6];
        double[] b1 = new double[6];
        double[] c1 = new double[6]; // для средних значений

        public Accaunt()
        {
            InitializeComponent();
            MainWindow mainWindow = new MainWindow();
            FIO.Text = MainWindow.teacherFio;
            Napravlenie.Text = MainWindow.teacherNapr;
            

            if (MainWindow.teacherId == 0 || MainWindow.teacherId == 1)
            {

                string a = "", b = "", c = "", d = "", e = "", f = ""; // для оценок
                int q = 0, w = 0, p = 0, r = 0, t = 0, y = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 0) { a += Convert.ToString(MainWindow.UCH_Marks[i, j]); a1[0] += MainWindow.UCH_Marks[i, j]; } // заносит в переменную а все оценки ученика
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 1) { b += Convert.ToString(MainWindow.UCH_Marks[i, j]); a1[1] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 2) { c += Convert.ToString(MainWindow.UCH_Marks[i, j]); a1[2] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 3) { d += Convert.ToString(MainWindow.UCH_Marks[i, j]); a1[3] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 4) { e += Convert.ToString(MainWindow.UCH_Marks[i, j]); a1[4] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 5) { f += Convert.ToString(MainWindow.UCH_Marks[i, j]); a1[5] += MainWindow.UCH_Marks[i, j]; }
                    }
                }
                List<Student> students = new List<Student>
                {

                    new Student { Name = MainWindow.Students[0], Grade = a},
                    new Student { Name = MainWindow.Students[1], Grade = b},
                    new Student { Name = MainWindow.Students[2], Grade = c},
                    new Student { Name = MainWindow.Students[3], Grade = d},
                    new Student { Name = MainWindow.Students[4], Grade = e},
                    new Student { Name = MainWindow.Students[5], Grade = f},
                };
                gradesDataGrid.ItemsSource = students;
            }

            if (MainWindow.teacherId == 2 || MainWindow.teacherId == 3)
            {

                string a = "", b = "", c = "", d = "", e = "", f = "";

                for (int i = 6; i < 12; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 6) { a += Convert.ToString(MainWindow.UCH_Marks[i, j]); b1[0] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 7) { b += Convert.ToString(MainWindow.UCH_Marks[i, j]); b1[1] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 8) { c += Convert.ToString(MainWindow.UCH_Marks[i, j]); b1[2] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 9) { d += Convert.ToString(MainWindow.UCH_Marks[i, j]); b1[3] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 10) { e += Convert.ToString(MainWindow.UCH_Marks[i, j]); b1[4] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 11) { f += Convert.ToString(MainWindow.UCH_Marks[i, j]); b1[5] += MainWindow.UCH_Marks[i, j]; }
                    }
                }
                List<Student> students = new List<Student>
                {

                    new Student { Name = MainWindow.Students[6], Grade = a },
                    new Student { Name = MainWindow.Students[7], Grade = b},
                    new Student { Name = MainWindow.Students[8], Grade = c},
                    new Student { Name = MainWindow.Students[9], Grade = d},
                    new Student { Name = MainWindow.Students[10], Grade = e},
                    new Student { Name = MainWindow.Students[11], Grade = f},
                };
                gradesDataGrid.ItemsSource = students;

            }
            if (MainWindow.teacherId == 4 || MainWindow.teacherId == 5)
            {

                string a = "", b = "", c = "", d = "", e = "", f = "";

                for (int i = 12; i < 18; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 12) { a += Convert.ToString(MainWindow.UCH_Marks[i, j]); c1[0] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 13) { b += Convert.ToString(MainWindow.UCH_Marks[i, j]); c1[1] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 14) { c += Convert.ToString(MainWindow.UCH_Marks[i, j]); c1[2] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 15) { d += Convert.ToString(MainWindow.UCH_Marks[i, j]); c1[3] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 16) { e += Convert.ToString(MainWindow.UCH_Marks[i, j]); c1[4] += MainWindow.UCH_Marks[i, j]; }
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 17) { f += Convert.ToString(MainWindow.UCH_Marks[i, j]); c1[5] += MainWindow.UCH_Marks[i, j]; }
                    }
                }
                List<Student> students = new List<Student>
                {

                    new Student { Name = MainWindow.Students[12], Grade = a},
                    new Student { Name = MainWindow.Students[13], Grade = b},
                    new Student { Name = MainWindow.Students[14], Grade = c},
                    new Student { Name = MainWindow.Students[15], Grade = d},
                    new Student { Name = MainWindow.Students[16], Grade = e},
                    new Student { Name = MainWindow.Students[17], Grade = f},
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

        private void Vedomost_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.teacherId == 0 || MainWindow.teacherId == 1)
            {
                double srznach_max = 0;
                int uchenik = 0;
                double [] other = new double[6];
                for (int i = 0; i < 6; i++)
                {
                    if (srznach_max < a1[i] / 4)
                    {
                        srznach_max = a1[i] / 4;
                        uchenik = i;
                        
                    }
                    other[i] = a1[i] / 4;

                }
                MessageBox.Show($"Лучший средний балл: {srznach_max} - {MainWindow.Students[0]}\n\nСредний балл остальных:\n{MainWindow.Students[0]} - {other[0]}\n{MainWindow.Students[1]} - {other[1]}\n{MainWindow.Students[2]} - {other[2]}\n{MainWindow.Students[3]} - {other[3]}\n{MainWindow.Students[4]} - {other[4]}\n{MainWindow.Students[5]} - {other[5]}");
            }
            if (MainWindow.teacherId == 2 || MainWindow.teacherId == 3)
            {
                double srznach_max = 0;
                int uchenik = 0;
                double [] other = new double[6];
                for (int i = 0; i < 6; i++)
                {
                    if (srznach_max < b1[i] / 4)
                    {
                        srznach_max = b1[i] / 4;
                        uchenik = 6 + i;
                    }
                    other[i] = b1[i] / 4;

                }
                MessageBox.Show($"Лучший средний балл: {srznach_max} - {MainWindow.Students[uchenik]}\n\nСредний балл остальных:\n{MainWindow.Students[6]} - {other[0]}\n{MainWindow.Students[7]} - {other[1]}\n{MainWindow.Students[8]} - {other[2]}\n{MainWindow.Students[9]} - {other[3]}\n{MainWindow.Students[10]} - {other[4]}\n{MainWindow.Students[11]} - {other[5]}");
            }
            if (MainWindow.teacherId == 4 || MainWindow.teacherId == 5)
            {
                double srznach_max = 0;
                int uchenik = 0;
                double [] other = new double[6];
                for (int i = 0; i < 6; i++)
                {
                    if (srznach_max < c1[i] / 4)
                    {
                        srznach_max = c1[i] / 4;
                        uchenik = 12 + i;
                    }
                    other[i] = Convert.ToInt32(c1[i]);
                    other[i] = c1[i] / 4;

                }
                MessageBox.Show($"Лучший средний балл: {srznach_max} - {MainWindow.Students[uchenik]}\n\nСредний балл остальных:\n{MainWindow.Students[12]} - {other[0]}\n{MainWindow.Students[13]} - {other[1]}\n{MainWindow.Students[14]} - {other[2]}\n{MainWindow.Students[15]} - {other[3]}\n{MainWindow.Students[16]} - {other[4]}\n{MainWindow.Students[17]} - {other[5]}");
            }
        }



        public class Student
        {
            public string Name { get; set; }
            public string Grade { get; set; } // Инициализируем список оценок

            // Свойство для отображения всех оценок в одной строке
            public string GradesAsString => string.Join(", ", Grade);
        }
    }
}

