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

        public static int teacherId { set; get; }
        public static string teacherFio { set; get; }
        public static string teacherNapr { set; get; }
        public static string[] Students { set; get; } = { "Маркина Милана Денисовна", "Новикова Александра Давидовна", "Васильев Макар Семёнович", "Новикова Алсу Дмитриевна", "Федотова Милана Максимовна", "Фетисова Юлия Васильевна", "Кузнецов Виктор Константинович", "Дорофеев Степан Маркович", "Фомин Кирилл Андреевич", "Горшкова Александра Львовна", "Волков Максим Александрович", "Зиновьева Анастасия Ивановна", "Хохлова Софья Ивановна", "Румянцева Александра Георгиевна", "Беляев Ярослав Егорович", "Русакова Мария Всеволодовна", "Кузнецова Алина Артёмовна", "Марков Роман Давидович" };


        int[,] login_password = { { 1111, 1111 }, { 2222, 2222 }, { 3333, 3333 }, { 4444, 4444 }, { 5555, 5555 }, { 6666, 6666 } };

        string[,] FIO_Napr = { { "Елена Николаевна", "Сетевик" }, { "Ярослава Сергеевна", "Сетевик" }, { "Наталья Струженикова", "Программист" }, { "Ольга Кружок", "Программист" }, {"Анна Валерьевна", "Безопасик" }, { "Мария Никитивна", "Безопасник" } };

        private void log_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (loginTeacher.Text == login_password[i,0].ToString() && PasswordTeacher.Text == login_password[i,1].ToString())
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
