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

namespace task_4_notepad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBlock.FontStyle == FontStyles.Italic)
            {
                TextBlock.FontStyle = FontStyles.Normal;
            }
            else
            {
                TextBlock.FontStyle = FontStyles.Italic;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (TextBlock.FontWeight == FontWeights.Bold)
            {
                TextBlock.FontWeight = FontWeights.Normal;
            }
            else
            {
                TextBlock.FontWeight = FontWeights.Bold;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (TextBlock.TextDecorations == TextDecorations.Underline)
            {
                TextBlock.TextDecorations = null;
            }
            else
            {
                TextBlock.TextDecorations = TextDecorations.Underline;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBlock.Foreground = but4.Foreground;
            TextBlock.Background = but4.Background;
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Foreground = but5.Foreground;
            TextBlock.Background = but5.Background;
        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Foreground = but6.Foreground;
            TextBlock.Background = but6.Background;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBlock.FontFamily = but7.FontFamily;
        }

        private void but8_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.FontFamily = but8.FontFamily;
        }

        private void but9_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.FontFamily = but9.FontFamily;
        }
    }
}
