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

namespace task_6_geometry
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
            if (RadioCircle.IsChecked.Value)
            {
                
                try
                {
                    Circle myCircle = new Circle();

                    
                    myCircle.SetRadius(Double.Parse(TextRadius.Text));

                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Площадь: " + myCircle.Area(); 
                    StackCircles.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelRadius.Foreground = Brushes.Red;
                }
            }
            else if (RadioCylinder.IsChecked.Value)
            {
                Cylinder cylinder = new Cylinder();

                bool success = true;
                try
                {
                    cylinder.SetRadius(double.Parse(TextRadius.Text));
                }
                catch 
                {
                    success = false;
                    LabelRadius.Foreground = Brushes.Red;
                }
                try
                {
                    cylinder.SetHeight(double.Parse(TextHeight.Text));
                }
                catch
                {
                    success = false;
                    HeightRadius.Foreground = Brushes.Red;
                }
                if (success)
                {
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Объем: " + cylinder.Volume(); 
                    StackCylinders.Children.Add(myTextBlock);
                }
            }
            else if (RadioSphere.IsChecked.Value)
            {
                try
                {
                    Sphere sphere = new Sphere();

                    sphere.SetRadius(double.Parse(TextRadius.Text));

                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Объем: " + sphere.Volume(); 
                    StackSpheres.Children.Add(myTextBlock);
                }
                catch
                {
                    LabelRadius.Foreground = Brushes.Red;
                }
            }
        }

        private void TextRadius_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(LabelRadius.Foreground!=Brushes.Black)
                LabelRadius.Foreground = Brushes.Black;
        }

        private void TextHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (HeightRadius.Foreground != Brushes.Black)
                HeightRadius.Foreground = Brushes.Black;
        }
    }
}
