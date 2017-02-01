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
using MedicoPlus_ver._1._0__Модуль_Реєстратура.Registry;

namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TitleBar_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Enter_Click(new object(), new RoutedEventArgs());
            }
        }
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            MySQL db = new MySQL();
            var users = db.users;
            try
            {
                foreach (user u in users)
                {

                    if (login.Text.Equals(u.login) && password.Password.Equals(u.pwd))
                    {
                        //userAccess = u.rules; пока закрыто, данные в другой базе
                        Shell shell = new Shell();
                        shell.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Користувача не знайдено.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
