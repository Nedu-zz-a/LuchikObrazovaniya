using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LuchikObrazovaniya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static int teacherId { set; get; } // Индекс препода
        public static string teacherFio { set; get; } //ФИО препода
        public static string teacherNapr { set; get; } // направление тичера
        //ФИО студентов
        public static string[] Students { set; get; } = { "Маркина Милана Денисовна", "Новикова Александра Давидовна", "Васильев Макар Семёнович", "Новикова Алсу Дмитриевна", "Федотова Милана Максимовна", "Фетисова Юлия Васильевна", "Кузнецов Виктор Константинович", "Дорофеев Степан Маркович", "Фомин Кирилл Андреевич", "Горшкова Александра Львовна", "Волков Максим Александрович", "Зиновьева Анастасия Ивановна", "Хохлова Софья Ивановна", "Румянцева Александра Георгиевна", "Беляев Ярослав Егорович", "Русакова Мария Всеволодовна", "Кузнецова Алина Артёмовна", "Марков Роман Давидович" };
        //Оценки каждого ученика
        public static int[,] UCH_Marks { set; get; } = { { 3, 4, 2, 5 }, { 4, 2, 2, 5 }, { 5, 4, 4, 4 }, { 4, 5, 2, 5 }, { 5, 3, 4, 5 }, { 5, 3, 1, 3 }, { 2, 5, 5, 3 }, { 5, 3, 3, 5 }, { 4, 3, 3, 3 }, { 5, 5, 4, 5 }, { 5, 5, 3, 2 }, { 5, 4, 4, 3 }, { 4, 4, 3, 5 }, { 5, 5, 4, 4 }, { 5, 5, 5, 5 }, { 3, 2, 4, 5 }, { 4, 5, 3, 4 }, { 4, 4, 5, 5 } };
        //Логин и пароль для каждого тичера
        int[,] login_password = { { 1111, 1111 }, { 2222, 2222 }, { 3333, 3333 }, { 4444, 4444 }, { 5555, 5555 }, { 6666, 6666 } };
        //ФИО тичера и её направление
        string[,] FIO_Napr = { { "Елена Николаевна", "Сетевик" }, { "Ярослава Сергеевна", "Сетевик" }, { "Наталья Струженикова", "Программист" }, { "Ольга Кружок", "Программист" }, {"Анна Валерьевна", "Безопасик" }, { "Мария Никитивна", "Безопасник" } };


        private void log_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (loginTeacher.Text == login_password[i,0].ToString() && PasswordTeacher.Password.ToString() == login_password[i,1].ToString())
                {
                    teacherId = i;
                    teacherFio = FIO_Napr[i, 0];
                    teacherNapr = FIO_Napr[i, 1];
                    Accaunt accaunt = new Accaunt();
                    accaunt.Show();
                    this.Close();
                    break;
                }
                else
                {
                    if (i == 5)
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
        }
    }
}
