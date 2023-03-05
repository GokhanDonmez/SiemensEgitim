using MilcanX.Class.DAL;
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

namespace MilcanX.Windovs
{
    /// <summary>
    /// Interaction logic for UcProductWindow.xaml
    /// </summary>
    public partial class UcProductWindow : Window
    {
        bool _result;
        public UcProductWindow()
        {
            InitializeComponent();
            txtProductID.Text = ProductDAL.getProductID().ToString();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            
            // int _ProductID = Convert.ToInt32(txtProductID.Text);
            string _ProductName = txtProductName.Text;
            string _SupplierID = txtSupplierID.Text;
            string _CategoryID= txtCategoryID.Text;
            string _QuantityPerUnit = txtQuantityPerUnit.Text;
            decimal _UnitPrice =Convert.ToDecimal(txtUnitPrice.Text);
            int _UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text);
            int _UnitsOnOrder = Convert.ToInt32(txtUnitsOnOrder.Text);
            int _ReorderLevel = Convert.ToInt32(txtReorderLevel.Text);
            bool _Discontinued = (bool)cbDiscontinous.IsChecked;
            if (_ProductName != string.Empty)
            {
                _result = ProductDAL.AddElementToTable(_ProductName, _SupplierID, _CategoryID, _QuantityPerUnit, _UnitPrice, _UnitsInStock, _UnitsOnOrder, _ReorderLevel, _Discontinued);

                if (_result)
                {
                    MessageBox.Show("Başarılı");
                }
                else
                {
                    MessageBox.Show("Başarısız");
                }

            }
            else
            {
                MessageBox.Show("Ürün Adı Girilmedi. Kayıt Yapılmadı");
            }
                
            

        }
    }
}
