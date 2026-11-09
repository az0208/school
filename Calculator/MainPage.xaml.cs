using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
            if(OperatorTXT.Text == string.Empty)
            {
                OperatorTXT.Text = "+";
            }
        }

        private void signminus_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                OperatorTXT.Text = "-";
            }
        }

        private void signmulti_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                OperatorTXT.Text = "X";
            }
        }

        private void signdivide_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty)
            {
                OperatorTXT.Text = "/";
            }
        }

        private void signC_Click(object sender, RoutedEventArgs e)
        {
            OperatorTXT.Text = string.Empty;
            FirstNumberTXT.Text = string.Empty;
            SecondNumberTXT.Text = string.Empty;
            AnswerTXT.Text = string.Empty;
        }

        private void signequals_Click(object sender, RoutedEventArgs e)
        {
            if(FirstNumberTXT.Text != string.Empty && SecondNumberTXT.Text != string.Empty && OperatorTXT.Text != string.Empty)
            {
                if(SecondNumberTXT.Text != "0")
                {
                    double num1;
                    double num2;
                    double answer;
                    num1 = double.Parse(FirstNumberTXT.Text);
                    num2 = double.Parse(SecondNumberTXT.Text);
                    if (OperatorTXT.Text == "+")
                    {
                        answer = num1 + num2;
                        AnswerTXT.Text = answer.ToString();
                    }
                    if (OperatorTXT.Text == "-")
                    {
                        answer = num1 - num2;
                        AnswerTXT.Text = answer.ToString();
                    }
                    if (OperatorTXT.Text == "X")
                    {
                        answer = num1 * num2;
                        AnswerTXT.Text = answer.ToString();
                    }
                    if (OperatorTXT.Text == "/")
                    {
                        answer = num1 / num2;
                        AnswerTXT.Text = answer.ToString();
                    }
                }
                else
                {
                    AnswerTXT.Text = "Math Error";
                }
            }
            else
            {
                AnswerTXT.Text = "Missing Data";
            }
            

        }

        private void signdot_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty && !FirstNumberTXT.Text.Contains("."))
            {
                FirstNumberTXT.Text += ".";
            }
            if (OperatorTXT.Text != string.Empty && !SecondNumberTXT.Text.Contains("."))
            {
                SecondNumberTXT.Text += ".";
            }
        }

        private void signDEL_Click(object sender, RoutedEventArgs e)
        {
            if (OperatorTXT.Text == string.Empty && FirstNumberTXT.Text != string.Empty && AnswerTXT.Text == string.Empty)
            {
                FirstNumberTXT.Text = FirstNumberTXT.Text.Substring(0, FirstNumberTXT.Text.Length - 1);
            }
            if (OperatorTXT.Text != string.Empty && SecondNumberTXT.Text == string.Empty && AnswerTXT.Text == string.Empty)
            {
                OperatorTXT.Text = OperatorTXT.Text.Substring(0, OperatorTXT.Text.Length - 1);
            }
            if (SecondNumberTXT.Text != string.Empty && AnswerTXT.Text == string.Empty)
            {
                SecondNumberTXT.Text = SecondNumberTXT.Text.Substring(0, SecondNumberTXT.Text.Length - 1);
            }

        }

        private async void signtut_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Content = new TextBlock
            {
                Text = "דף עזרה\n\n" +
               "1. לחצו על מספר בשביל להכניס מספר ראשון למחשבון.\n\n" +
               "2. בחרו פעולת חשבון.\n\n" +
               "3. הכניסו מספר נוסף בשביל להכניס מספר שני למחשבון.\n\n" +
               "4. לחצו על = כדי לקבל תוצאה.\n\n" +
               "5. לחצו על C כדי לנקות את המחשבון.\n\n" +
               "6. לחצו על Ans כדי להשתמש בתוצאה האחרונה שחישבתם.\n\n" +
               "7. לחצו על Del כדי למחוק את הספרה האחרונה שהכנסתם.\n\n" +
               "8. תגלו מה כפתור ההפתעה עושה.",
                TextWrapping = TextWrapping.Wrap,
                FontSize = 10
            };

            dialog.Background = new SolidColorBrush(
                Windows.UI.Colors.LightPink
            );

            dialog.CloseButtonText = "סגור";

            await dialog.ShowAsync();
        }

        private void signsuprise_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            Windows.UI.Color[] colors =
            {
                Windows.UI.Colors.Red,
                Windows.UI.Colors.Blue,
                Windows.UI.Colors.Green,
                Windows.UI.Colors.Yellow,
                Windows.UI.Colors.Purple,
                Windows.UI.Colors.DarkRed,
                Windows.UI.Colors.Orange,
                Windows.UI.Colors.Pink,
                Windows.UI.Colors.Cyan,
                Windows.UI.Colors.Magenta,
                Windows.UI.Colors.Brown,
                Windows.UI.Colors.Gray,
                Windows.UI.Colors.LightBlue,
                Windows.UI.Colors.LightGreen,
                Windows.UI.Colors.LightPink,
                Windows.UI.Colors.DarkBlue,
                Windows.UI.Colors.DarkGreen,
                Windows.UI.Colors.DarkOrange,
                Windows.UI.Colors.DarkViolet,
                Windows.UI.Colors.Gold,
                Windows.UI.Colors.Turquoise,
                Windows.UI.Colors.Coral,
                Windows.UI.Colors.Salmon,
                Windows.UI.Colors.Khaki,
                Windows.UI.Colors.Plum,
                Windows.UI.Colors.Orchid,
                Windows.UI.Colors.Tan,
                Windows.UI.Colors.Lime,
                Windows.UI.Colors.Teal,
                Windows.UI.Colors.Silver,
                Windows.UI.Colors.DeepPink,
                Windows.UI.Colors.Azure,
                Windows.UI.Colors.LightPink

            };

            MainGrid.Background = new SolidColorBrush(
                colors[random.Next(colors.Length)]
            );
        }

        private void signanswer_Click(object sender, RoutedEventArgs e)
        {
            
            if (AnswerTXT.Text != string.Empty)
            {
                FirstNumberTXT.Text = AnswerTXT.Text;
                SecondNumberTXT.Text = string.Empty;
                OperatorTXT.Text = string.Empty;
                AnswerTXT.Text = string.Empty;
            }
        }
    }
}
