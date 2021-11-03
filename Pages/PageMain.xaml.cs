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
using WpfApp8.Resourses;

namespace WpfApp8.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void Credits_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageCredits());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageIpoteka());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageCards());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageVclad());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageInvest());
        }
    }
}
