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

namespace WPFTicTacToe
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
        //Used to count the current amount of clicks
        int counter = 0;

        private void Button_Click(object sender, RoutedEventArgs x)
        {
            var button = (Button)sender;

            //Checks if the button content is empty
            if(button.Content == null)
            {
                //Checks if the current counter int is divisible with 2
                if (counter % 2 == 0)
                {
                    button.Content = "X";
                }
                //If not divisible with 2, does this
                else
                {
                    button.Content = "O";
                }
                //Adds to the counter after a successful click
                counter++;
            }
        }
    }
}
