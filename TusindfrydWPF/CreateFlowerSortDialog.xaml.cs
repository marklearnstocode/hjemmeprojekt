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

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
            FlowerSort newFlower = new FlowerSort();
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            ButtonRdy();
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void ButtonRdy()
        {
        if (tbName.Text != "" &&
            tbBilledeSti.Text != "" &&
            tbHalveringstid.Text != "" &&
            tbProduktionsId.Text != "" &&
            tbStørrelse.Text != "")
            
            {
                btnOK.IsEnabled = true;
            }
        else { btnOK.IsEnabled = false; }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbBilledeSti_LostFocus(object sender, RoutedEventArgs e)
        {
            imgBillede.Source = new BitmapImage(new Uri(tbBilledeSti.Text));
            newFlower.PicturePath = tbBilledeSti.Text;
        }
    }
}
