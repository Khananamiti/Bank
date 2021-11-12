using System.Windows;
using WpfApp8.Clases;
using WpfApp8.Pages;
using WpfApp8.Resourses;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameClass.frmObj = FrMain;
            FrMain.Navigate(new PageMain());
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Credit_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageCredits());
        }

        private void Ipoteka_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageIpoteka());
        }

        private void Cards_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageCards());
        }

        private void Vklad_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageVclad());
        }

        private void Invest_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageInvest());
        }

        private void Vyhod_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frmObj.Navigate(new PageAut());
        }
    }
}
