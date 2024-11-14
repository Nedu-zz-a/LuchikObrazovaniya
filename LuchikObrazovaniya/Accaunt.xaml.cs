using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public static double[] a1 = new double[6];
        public static double[] b1 = new double[6];
        public static double[] c1 = new double[6]; // для средних значений

        public Accaunt()
        {
            InitializeComponent();
            MainWindow mainWindow = new MainWindow(); 
            FIO.Text = MainWindow.teacherFio;  //Берём ФИО препода
            Napravlenie.Text = MainWindow.teacherNapr; // Его направление
            

            if (MainWindow.teacherId == 0 || MainWindow.teacherId == 1) //Условия если вошли под 1 ил 2 преподом
            {

                string a = "", b = "", c = "", d = "", e = "", f = ""; // для оценок
                for (int i = 0; i < 6; i++) //Перебор кждого ученика
                {
                    for (int j = 0; j < 4; j++) //Перебор каждой оценки ученика
                    {
                        if (i == 0) { a += Convert.ToString(MainWindow.UCH_Marks[i, j]); a1[0] += MainWindow.UCH_Marks[i, j]; } // заносит в переменную а все оценки ученика, а в массив а1 - ссумму всех оценок для среднего значения
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
                List<Student> students = new List<Student> //Создание листа для строк в DataGrid
                {

                    new Student { Name = MainWindow.Students[0], Grade = a}, //Создание строк в DataGrid
                    new Student { Name = MainWindow.Students[1], Grade = b},
                    new Student { Name = MainWindow.Students[2], Grade = c},
                    new Student { Name = MainWindow.Students[3], Grade = d},
                    new Student { Name = MainWindow.Students[4], Grade = e},
                    new Student { Name = MainWindow.Students[5], Grade = f},
                };
                gradesDataGrid.ItemsSource = students;
            }

            if (MainWindow.teacherId == 2 || MainWindow.teacherId == 3) //Повторение предыдущего
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

        private void quit_Click(object sender, RoutedEventArgs e) //Выход к авторизации
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            if (vedomost != null || vedomost.IsVisible)
            {
                vedomost.Close();
               
            }
            if (raspisanie != null || raspisanie.IsVisible)
            {
                raspisanie.Close();
               
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e) //Закрытие программы
        {
            this.Close();
        }

        public class Student 
        {
            public string Name { get; set; }
            public string Grade { get; set; } // Инициализируем список оценок
        }


        int indikator = 0;
        int indikator1 = 0;

        Raspisanie raspisanie;

        private void raspisanie_Click(object sender, RoutedEventArgs e)
        {
            if (raspisanie == null || !raspisanie.IsVisible)
            {
                raspisanie = new Raspisanie();
                raspisanie.Closed += (s, args) =>
                {
                    raspisanie = null;
                };
                raspisanie.Left = this.Left + this.Width + 1;
                raspisanie.Top = this.Top;
                raspisanie.Show();
            }
            else
            {
                raspisanie.Close();
                raspisanie = null;
            }
            }
            

         
            Vedomost vedomost;

        private void Vedomostik_Click(object sender, RoutedEventArgs e) // Нахождение среднего балла
        {
            if (vedomost == null || !vedomost.IsVisible)
            {
                vedomost = new Vedomost();
                vedomost.Closed += (s, args) =>
                {
                    vedomost = null;
                    Vedomostik.Content = "Открыть ведомость";
                };
                vedomost.Left = this.Left - this.Width + 240;
                vedomost.Top = this.Top;
                vedomost.Show();
                Vedomostik.Content = "Закрыть ведомость";
            }
            else
            {
                vedomost.Close();
                vedomost = null;
                Vedomostik.Content = "Открыть ведомость";
            }
        }
    }
}

