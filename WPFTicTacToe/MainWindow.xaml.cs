using System.Windows;
using System.Windows.Controls;

namespace WPFTicTacToe
{
    public partial class MainWindow : Window
    {
        int counter = 0; //Used to count the current amount of clicks
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs x)
        {
            var button = (Button)sender;

            if(button.Content != null) return;
            //Checks if the current counter int is divisible with 2
            button.Content = counter % 2 == 0 ? "X" : "O";

            counter++; //Adds to the counter after a successful click
        }
    }
}