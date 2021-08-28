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

namespace Telegram_WPF
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



        private void click_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            userName.Content = cavidanName.Content;

            mesaj1.Content = "Salam";
            mesaj2.Content = "Alekum Salam";
            mesaj3.Content = "Necesen?";
            mesaj4.Content = "Wukur sen?";


        }

        private void clickM_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            userName.Content = memmedagaName.Content;

            mesaj1.Content = "S.A";
            mesaj2.Content = "A.S";
            mesaj3.Content = "Gelsen?";
            mesaj4.Content = "He";

        }

        private void clickQ_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {


            userName.Content = qabilName.Content;

            mesaj1.Content = "Denze gedsen?";
            mesaj2.Content = "Yo";
            mesaj3.Content = "Niye?";
            mesaj4.Content = "Nem";
        }

        private void clickS_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            userName.Content = saniyeName.Content;

            mesaj1.Content = "Gunel";
            mesaj2.Content = "?";
            mesaj3.Content = "Kimem men?";
            mesaj4.Content = "nem aq";

        }
    }
}
