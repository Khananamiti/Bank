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
using WpfApp8.Clases;

namespace WpfApp8.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
        }

        private void zaregin_Click(object sender, RoutedEventArgs e)
        {
            if ((sureName.Text == ""))
            {
                MessageBox.Show("Поле Фамилия не заполнено");
            }
            else if ((name.Text == ""))
            {
                MessageBox.Show("Поле Имя не заполнено");
            }
            else if ((LastName.Text == ""))
            {
                MessageBox.Show("Поле Отчество не заполнено");
            }
            else if ((email.Text == ""))
            {
                MessageBox.Show("Поле e-mail не заполнено");
            }
            else if ((password.Password == ""))
            {
                MessageBox.Show("Поле Пароль не заполнено");
            }
            else if ((password_2.Password == "") || (password.Password != password_2.Password))
            {
                MessageBox.Show("Поле Повторите пароль не заполнено или пароли не совпадают");
            }
            else
            {
                FrameClass.frmObj.Navigate(new PageAut());
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageAut());
        }

        private void zaregin_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void back_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
