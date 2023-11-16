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

namespace WPFSimpleGUI
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

        private void Scroll_Up_Click(object sender, RoutedEventArgs e)
        {
            string temp = tbline1.Text;
            tbline1.Text = tbline2.Text;
            tbline2.Text = tbline3.Text;
            tbline3.Text = tbline4.Text;
            tbline4.Text = temp;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            tbline1.Clear();
            tbline2.Clear();
            tbline3.Clear();
            tbline4.Clear();
        }

        private void Scroll_Down_Click(object sender, RoutedEventArgs e)
        {
            string temp = tbline4.Text;
            temp = tbline4.Text;
            tbline4.Text = tbline3.Text;
            tbline3.Text = tbline2.Text;
            tbline2.Text = tbline1.Text;
            tbline1.Text = temp;
        }
    }
}
