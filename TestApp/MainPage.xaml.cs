using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using StatusBarUtil;
using System.Threading;

namespace TestApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // コンストラクター
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StatusBar.ShowStatusBar(this, "Test1");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            StatusBar.ShowStatusBar(this, "Test2", true);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            while (i < 100)
            {
                StatusBar.ShowStatusBar(this, "Test3", i);
                i++;
                //Thread.Sleep(50);
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (StatusBar.isVisible)
                StatusBar.ShowStatusBar(this, !StatusBar.isVisible);
        }
    }
}