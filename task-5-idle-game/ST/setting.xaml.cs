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
using System.Windows.Shapes;

namespace task_5_idle_game
{
    /// <summary>
    /// Логика взаимодействия для setting.xaml
    /// </summary>
    public partial class setting : Window
    {
        public setting()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)this.Owner;
            mainWindow.upClick.FontFamily = but1.FontFamily;
            mainWindow.upPowerClickButtuon.FontFamily = but1.FontFamily;
            mainWindow.upAuto.FontFamily = but1.FontFamily;
            mainWindow.upAutoClickButton.FontFamily = but1.FontFamily;
            mainWindow.labelScore.FontFamily = but1.FontFamily;
            mainWindow.check.FontFamily = but1.FontFamily;
            mainWindow.workLabel.FontFamily = but1.FontFamily;
            mainWindow.clackLabel.FontFamily = but1.FontFamily;
            mainWindow.newLabel.FontFamily = but1.FontFamily;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)this.Owner;
            mainWindow.upClick.FontFamily = but2.FontFamily;
            mainWindow.upPowerClickButtuon.FontFamily = but2.FontFamily;
            mainWindow.upAuto.FontFamily = but2.FontFamily;
            mainWindow.upAutoClickButton.FontFamily = but2.FontFamily;
            mainWindow.labelScore.FontFamily = but2.FontFamily;
            mainWindow.check.FontFamily = but2.FontFamily;
            mainWindow.workLabel.FontFamily = but2.FontFamily;
            mainWindow.clackLabel.FontFamily = but2.FontFamily;
            mainWindow.newLabel.FontFamily = but2.FontFamily;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)this.Owner;
            mainWindow.upClick.FontFamily = but3.FontFamily;
            mainWindow.upPowerClickButtuon.FontFamily = but3.FontFamily;
            mainWindow.upAuto.FontFamily = but3.FontFamily;
            mainWindow.upAutoClickButton.FontFamily = but3.FontFamily;
            mainWindow.labelScore.FontFamily = but3.FontFamily;
            mainWindow.check.FontFamily = but3.FontFamily;
            mainWindow.workLabel.FontFamily = but3.FontFamily;
            mainWindow.clackLabel.FontFamily = but3.FontFamily;
            mainWindow.newLabel.FontFamily = but3.FontFamily;
        }
    }
}
