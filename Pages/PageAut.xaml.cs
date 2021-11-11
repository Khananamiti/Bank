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
    /// Логика взаимодействия для PageAut.xaml
    /// </summary>
    public partial class PageAut : Page
    {
        public PageAut()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if ((login.Text == "") || (password.Password == ""))
            {
                MessageBox.Show("Вы что-то не ввели.");
            }
            else
            {
                FrameClass.frmObj.Navigate(new PageMainVhod());
            }

        }

        private void regin_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageReg());
        }
    }
}
