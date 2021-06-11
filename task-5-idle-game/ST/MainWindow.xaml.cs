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
using System.Windows.Threading;

namespace task_5_idle_game
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        setting settingWin;
        ulong pricePowerlevel;
        ulong priceAutolevel;
        ulong powerlevel;
        ulong score;
        ulong autolevel;
        ulong sumclick;
        DispatcherTimer autoTimer;

        public MainWindow()
        {
            InitializeComponent();
            autoTimer = new DispatcherTimer();
            autoTimer.Tick += new EventHandler(autoTimer_Tick);
            autoTimer.Interval = new TimeSpan(0, 0, 1);
            autoTimer.Start();
            powerlevel = 1;
            score = 0;
            autolevel = 0;
            sumclick = 0;
            pricePowerlevel = 10;
            priceAutolevel = 100;
        }

        private void autoTimer_Tick(object sender, EventArgs e)
        {
            score = score + autolevel;
            labelScore.Content = Convert.ToString(score);

            if (score >= 100)
            {
                workLabel.Background = Brushes.Green;
            }
            if (sumclick >= 100)
            {
                clackLabel.Background = Brushes.Green;
            }
            if (autolevel + powerlevel > 25)
            {
                newLabel.Background = Brushes.Green;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            settingWin = new setting();
            settingWin.Owner = this;
            settingWin.Show();
        }

        private void upPowerClickButtuon_Click(object sender, RoutedEventArgs e)
        {
            if (score >= pricePowerlevel)
            {
                powerlevel = powerlevel + 1;
                score = score - pricePowerlevel;
                pricePowerlevel = powerlevel * 10;

                upPowerClickButtuon.Content = Convert.ToString(pricePowerlevel);
                upClick.Content = "Купить силу клика - " + Convert.ToString(powerlevel - 1) + " уровня";
            }
        }

        private void upAutoClickButton_Click(object sender, RoutedEventArgs e)
        {
            if (score >= priceAutolevel)
            {
                autolevel = autolevel + 1;
                score = score - priceAutolevel;
                priceAutolevel = autolevel * 10;

                upAutoClickButton.Content = Convert.ToString(priceAutolevel);
                upAuto.Content = "Купить автоклик - " + Convert.ToString(autolevel) + " уровня";
            }
        }

        private void ClacButton1_Click(object sender, RoutedEventArgs e)
        {
            score = score + powerlevel;
            sumclick = sumclick + 1;
            labelScore.Content = Convert.ToString(score);
        }
    }
}
