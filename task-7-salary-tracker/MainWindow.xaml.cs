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

namespace Positions
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {  
                    Seller mySeller = new Seller();

                    mySeller.SetProfit(double.Parse(FirstElementText.Text));
                    mySeller.SetBasicSalary(double.Parse(SecondElementText.Text));

                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата Продавца: " + Math.Round(mySeller.ShowSalary(), 3) + " Рублей"; 
                    StackSalary.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    FirstElementText.Foreground = Brushes.Red;
                }
            
            
                OlderSeller myOlderSeller = new OlderSeller();

                try
                {
                    myOlderSeller.SetProfit(double.Parse(FirstElementText.Text));
                    myOlderSeller.SetBasicSalary(double.Parse(SecondElementText.Text));

                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата Старшего Продавца: " + Math.Round(myOlderSeller.ShowSalary(), 3) + " Рублей"; 
                    StackSalary.Children.Add(myTextBlock);
                }
                catch
                {
                    
                    FirstElement.Foreground = Brushes.Red;
                }
                
            
            
                Manager myManager = new Manager();

                try
                {
                    myManager.SetProfit(double.Parse(FirstElementText.Text));
                    myManager.SetBasicSalary(double.Parse(SecondElementText.Text));

                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата Менеджера: " + Math.Round(myManager.ShowSalary(), 3) + " Рублей"; 
                    StackSalary.Children.Add(myTextBlock);
                }
                catch
                {

                    FirstElement.Foreground = Brushes.Red;
                }


                Driver myDriver = new Driver();

                try
                {
                    myDriver.SetProfit(double.Parse(FirstElementText.Text));
                    myDriver.SetBasicSalary(double.Parse(SecondElementText.Text));

                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата Водителя: " + Math.Round(myDriver.ShowSalary(), 3) + " Рублей" + "\n" + "-------------------------------------"; 
                    StackSalary.Children.Add(myTextBlock);
                    
                }
                catch
                {

                    FirstElement.Foreground = Brushes.Red;
                }


        }

        private void FirstElementText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(FirstElement.Foreground!=Brushes.Black)
                FirstElement.Foreground = Brushes.Black;
        }

        private void SecondElementText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SecondElement.Foreground != Brushes.Black)
                SecondElement.Foreground = Brushes.Black;
        }

        

    }
}
