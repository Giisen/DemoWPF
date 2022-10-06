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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string defaultText = String.Empty;

        public MainWindow()
        {
            InitializeComponent();
            MinText.Text = defaultText;
            

        }


        private void ClickPad(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                    MinText.Text += (string)btn.Content;
            }
        }







        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //    if (e.Source is Button btn)
        //    {
        //        if (btn == null)
        //        {
        //            MinText.Text = btn.Content.ToString();
        //        }
        //        else
        //        {
        //            MinText.Text = Input.Text;
        //        }

        //    }

        //}

        private void Sank_10_px_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                if (btn == null)
                {
                    MinText.Text = btn.Content.ToString();
                }
                else
                {
                    if (MinText.FontSize > 20)
                        MinText.FontSize = MinText.FontSize - 10;
                }
            }
        }

        private void Hoj_10_px_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                if (btn == null)
                {
                    MinText.Text = btn.Content.ToString();
                }
                else
                {
                    if (MinText.FontSize < 100)
                    {
                        MinText.FontSize = MinText.FontSize + 10;
                    }

                }
            }
        }

        private void Comic_Sans_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                if (btn == null)
                {
                    MinText.Text = btn.Content.ToString();
                }
                else
                {
                    MinText.FontFamily = new FontFamily("Comic Sans MS");
                }
            }
        }

        private void Consolas_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                if (btn == null)
                {
                    MinText.Text = btn.Content.ToString();
                }
                else
                {
                    MinText.FontFamily = new FontFamily("Consolas");
                }
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                if (btn == null)
                {
                    MinText.Text = btn.Content.ToString();
                }
                else
                {
                    MinText.Text = defaultText;
                }
            }
        }

        private void Clear_OnClick(object sender, RoutedEventArgs e)
        {
            MinText.Text = "";
        }

        private void Equal_OnClick(object sender, RoutedEventArgs e)
        {
            
            var split = MinText.Text.Split('+');

            int One=int.Parse(split[0]);
            int Two=int.Parse(split[1]);
            int result = One + Two;

            MinText.Text=result.ToString();

        }



        //private void _7_OnClick(object sender, RoutedEventArgs e)
        //{
        //    if (e.Source is Button btn)
        //    {
        //        if (btn == null)
        //        {
        //            MinText.Text = btn.Content.ToString();
        //        }
        //        else
        //        {
        //            MinText.Text += "7";
        //        }
        //    }
        //}

        //    private void _8_OnClick(object sender, RoutedEventArgs e)
        //    {
        //        if (e.Source is Button btn)
        //        {
        //            if (btn == null)
        //            {
        //                MinText.Text = btn.Content.ToString();
        //            }
        //            else
        //            {
        //                MinText.Text += "8";
        //            }
        //        }
        //    }

        //    private void _9_Click(object sender, RoutedEventArgs e)
        //    {

        //        if (e.Source is Button btn)
        //        {
        //            if (btn == null)
        //            {
        //                MinText.Text = btn.Content.ToString();
        //            }
        //            else
        //            {
        //                MinText.Text += "9";
        //            }
        //        }

        //    }

        //    private void _4_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (e.Source is Button btn)
        //        {
        //            if (btn == null)
        //            {
        //                MinText.Text = btn.Content.ToString();
        //            }
        //            else
        //            {
        //                MinText.Text += "4";
        //            }
        //        }
        //    }

        //    private void _5_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (e.Source is Button btn)
        //        {
        //            if (btn == null)
        //            {
        //                MinText.Text = btn.Content.ToString();
        //            }
        //            else
        //            {
        //                MinText.Text += "5";
        //            }
        //        }
        //    }

        //    private void _6_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (e.Source is Button btn)
        //        {
        //            if (btn == null)
        //            {
        //                MinText.Text = btn.Content.ToString();
        //            }
        //            else
        //            {
        //                MinText.Text += "6";
        //            }
        //        }
        //    }

        //    private void _1_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (e.Source is Button btn)
        //        {
        //            if (btn == null)
        //            {
        //                MinText.Text = btn.Content.ToString();
        //            }
        //            else
        //            {
        //                MinText.Text += "1";
        //            }
        //        }
        //    }

        //    private void _2_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (e.Source is Button btn)
        //        {
        //            if (btn == null)
        //            {
        //                MinText.Text = btn.Content.ToString();
        //            }
        //            else
        //            {
        //                MinText.Text += "2";
        //            }
        //        }
        //    }

        //    private void _3_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (e.Source is Button btn)
        //        {
        //            if (btn == null)
        //            {
        //                MinText.Text = btn.Content.ToString();
        //            }
        //            else
        //            {
        //                MinText.Text += "3";
        //            }
        //        }
        //    }

        //    private void _0_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (e.Source is Button btn)
        //        {
        //            if (btn == null)
        //            {
        //                MinText.Text = btn.Content.ToString();
        //            }
        //            else
        //            {
        //                MinText.Text += "0";
        //            }
        //        }
        //    }
        //}


    }
}
        
            
        

