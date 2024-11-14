using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LuchikObrazovaniya
{
    /// <summary>
    /// Логика взаимодействия для Vedomost.xaml
    /// </summary>
    public partial class Vedomost : Window
    {
        private MainWindow _mainWindow;
        public Vedomost()
        {
            InitializeComponent();

            if (MainWindow.teacherId == 0 || MainWindow.teacherId == 1)
            {
                double srznach_max = 0; //Для высшего среднего значения
                int uchenik = 0;                // Индекс ученика, у которого наивысшее сред знач
                double[] other = new double[6]; //массив для удобства запоминания всех сред значаений
                for (int i = 0; i < 6; i++) //Перебор каждого ученика из группы
                {
                    if (srznach_max < Accaunt.a1[i] / 4) //Условия для поиска высшего сред значения
                    {
                        srznach_max = Accaunt.a1[i] / 4;
                        uchenik = i;

                    }
                    other[i] = Accaunt.a1[i] / 4; //массив для всех средних значений

                }
                TheBestSrZnach.Text = $"Лучший: {srznach_max}\n{MainWindow.Students[uchenik]}";
                srZnachOther.Text = $"{other[0]}\n{MainWindow.Students[0]}\n{other[1]}\n{MainWindow.Students[1]}\n{other[2]}\n{MainWindow.Students[2]}\n{other[3]}\n{MainWindow.Students[3]}\n{other[4]}\n{MainWindow.Students[4]}\n{other[5]}\n{MainWindow.Students[5]}";
                //Вывод высшего среднего значения в всех остальных значений вместе с ФИО ученика
            }
            if (MainWindow.teacherId == 2 || MainWindow.teacherId == 3) // Повторение
            {
                double srznach_max = 0;
                int uchenik = 0;
                double[] other = new double[6];
                for (int i = 0; i < 6; i++)
                {
                    if (srznach_max < Accaunt.b1[i] / 4)
                    {
                        srznach_max = Accaunt.b1[i] / 4;
                        uchenik = 6 + i;
                    }
                    other[i] = Accaunt.b1[i] / 4;

                }
                TheBestSrZnach.Text = $"Лучший: {srznach_max}\n{MainWindow.Students[uchenik]}";
                srZnachOther.Text = $"{other[0]}\n{MainWindow.Students[6]}\n{other[1]}\n{MainWindow.Students[7]}\n{other[2]}\n{MainWindow.Students[8]}\n{other[3]}\n{MainWindow.Students[9]}\n{other[4]}\n{MainWindow.Students[10]}\n{other[5]}\n{MainWindow.Students[11]}";
            }
            if (MainWindow.teacherId == 4 || MainWindow.teacherId == 5)
            {
                double srznach_max = 0;
                int uchenik = 0;
                double[] other = new double[6];
                for (int i = 0; i < 6; i++)
                {
                    if (srznach_max < Accaunt.c1[i] / 4)
                    {
                        srznach_max = Accaunt.c1[i] / 4;
                        uchenik = 12 + i;
                    }
                    other[i] = Convert.ToInt32(Accaunt.c1[i]);
                    other[i] = Accaunt.c1[i] / 4;

                }
                TheBestSrZnach.Text = $"Лучший: {srznach_max}\n{MainWindow.Students[uchenik]}";
                srZnachOther.Text = $"{other[0]}\n{MainWindow.Students[12]}\n{other[1]}\n{MainWindow.Students[13]}\n{other[2]}\n{MainWindow.Students[14]}\n{other[3]}\n{MainWindow.Students[15]}\n{other[4]}\n{MainWindow.Students[16]}\n{other[5]}\n{MainWindow.Students[17]}";
            }
        }
    }
}
