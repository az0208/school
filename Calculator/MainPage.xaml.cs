using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void digit1_Click(object sender, RoutedEventArgs e)
        {
            if(OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "1";
            }
            else
            {
                SecondNumberTXT.Text += "1";
            }
        }

        private void digit2_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "2";
            }
            else
            {
                SecondNumberTXT.Text += "2";
            }
        }

        private void digit3_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "3";
            }
            else
            {
                SecondNumberTXT.Text += "3";
            }
        }

        private void digit4_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "4";
            }
            else
            {
                SecondNumberTXT.Text += "4";
            }
        }

        private void digit5_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "5";
            }
            else
            {
                SecondNumberTXT.Text += "5";
            }
        }

        private void digit6_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "6";
            }
            else
            {
                SecondNumberTXT.Text += "6";
            }
        }

        private void digit7_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "7";
            }
            else
            {
                SecondNumberTXT.Text += "7";
            }
        }

        private void digit8_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "8";
            }
            else
            {
                SecondNumberTXT.Text += "8";
            }
        }

        private void digit9_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "9";
            }
            else
            {
                SecondNumberTXT.Text += "9";
            }
        }

        private void digit0_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text += "0";
            }
            else
            {
                SecondNumberTXT.Text += "0";
            }
        }

        private void signplus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signminus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signmulti_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signdivide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signequals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signdot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signDEL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signtut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signsuprise_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
