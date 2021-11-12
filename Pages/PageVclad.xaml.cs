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
using WpfApp8.Pages;

namespace WpfApp8.Resourses
{
    /// <summary>
    /// Логика взаимодействия для PageVclad.xaml
    /// </summary>
    public partial class PageVclad : Page
    {
        public PageVclad()
        {
            InitializeComponent();
            Vclad.Background = Brushes.LightBlue;
        }

        private void Credit_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageCredits());
        }

        private void Ipoteka_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageIpoteka());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageCards());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageInvest());
        }
    }
}
