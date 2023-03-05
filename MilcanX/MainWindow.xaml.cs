using MilcanX.Class.DAL;
using MilcanX.Windovs;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using MilcanX.Class.DTO;

namespace MilcanX
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

        private void btnSimge_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }

        private void btnBuyult_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnProductList_Click(object sender, RoutedEventArgs e)
        {
            dgProductList.ItemsSource = ProductDAL.GetAll();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tbx = sender as TextBox;
            if (tbx.Text!=string.Empty)
            {
                var filteredList = ProductDAL.FilteredList(tbx.Text);
                dgProductList.ItemsSource = filteredList;

            }
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            UcProductWindow uc = new UcProductWindow();
            this.Visibility = Visibility.Hidden;
            uc.Show();
        }     

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ProductDTO product=dgProductList.SelectedItem as ProductDTO;

            if (product!=null)
            {

                int _selectedID =Convert.ToInt32( product.ProductID);
                ProductDAL.DeleteItemFromTable(_selectedID);
            }

        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            dgProductList.ItemsSource = EmployeeDAL.GetAll();
        }
    }
}
