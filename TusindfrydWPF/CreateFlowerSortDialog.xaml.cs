using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public FlowerSort newFlower;
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            ButtonRdy();
            newFlower = new FlowerSort();
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonRdy();
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
            DialogResult = true;

        }

        private void tbBilledeSti_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                imgBillede.Source = new BitmapImage(new Uri(tbBilledeSti.Text));
                newFlower.PicturePath = tbBilledeSti.Text;
            }

            catch (UriFormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            ButtonRdy();
        }
            private void tbName_LostFocus(object sender, RoutedEventArgs e)
            {
                newFlower.Name = tbName.Text;
                if (tbName.Text != "")
                {
                    newFlower.Name = (tbName.Text);
                }
                else MessageBox.Show("Skriv en eksisterende blomstersort");
                ButtonRdy();
            }

            private void tbProduktionsId_LostFocus(object sender, RoutedEventArgs e)
            {
                newFlower.ProductionTime = int.Parse(tbProduktionsId.Text);
            }

            private void tbHalveringstid_LostFocus(object sender, RoutedEventArgs e)
            {
                newFlower.HalfLifeTime = int.Parse(tbHalveringstid.Text);
            }

            private void tbStørrelse_LostFocus(object sender, RoutedEventArgs e)
            {
                newFlower.Size = int.Parse(tbStørrelse.Text);
            }
    }

    }
