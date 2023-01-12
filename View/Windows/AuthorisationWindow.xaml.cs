using BarberRazor.AppData;
using BarberRazor.View.Pages;
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
using System.Windows.Shapes;

namespace BarberRazor.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorisationWindow.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window
    {
        public AuthorisationWindow()
        {
            InitializeComponent();


        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var administrator = AppConnect.auth.Administrator.FirstOrDefault(a => a.Login == LoginTb.Text && a.Password == PassPb.Password);
                if (administrator != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else 
                {
                    MessageBox.Show("Проверьте введенные данные (логин/пароль введены неверно или не введены)! ", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Критическа работа приложения!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void LoginBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
