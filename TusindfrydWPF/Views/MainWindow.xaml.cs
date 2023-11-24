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
using TusindfrydWPF.Models;

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSorts = new List<FlowerSort>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog flowers = new CreateFlowerSortDialog();
            if (flowers.ShowDialog() == true)
            {
                flowerSorts.Add(flowers.newFlower);
            }
            tbBox1.Text = "";
            foreach (FlowerSort newFlower in flowerSorts)
            {
                tbBox1.Text += newFlower.Name + "\n";
            }

        }
    }
}
