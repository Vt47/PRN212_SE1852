﻿using System;
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
using BusinessObjects;
using Services;

namespace SampleManagemenWpftApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService = new ProductService();
        bool isLoaded = false;
        public ProductWindow()
        {
            InitializeComponent();
            isLoaded = false;

            productService.InitializeDataset();

            lvProduct.ItemsSource=productService.GetProducts();
            isLoaded = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            isLoaded = false;
            Product p = new Product();
            p.Id= int.Parse(txtMa.Text);
            p.Name = txtTen.Text;
            p.Quantity = int.Parse(txtSoLuong.Text);
            p.Price = double.Parse(txtDonGia.Text);
            bool kq = productService.SaveProduct(p);
            if (kq == true)
            {
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = productService.GetProducts();
            }
            isLoaded = true;
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(isLoaded == false)
                return;
            if (e.AddedItems.Count < 0)
            
                return;
                Product p = e.AddedItems[0] as Product;
                txtMa.Text = p.Id.ToString();
                txtTen.Text = p.Name;
                txtSoLuong.Text = p.Quantity.ToString();
                txtDonGia.Text = p.Price.ToString();
            
        }

        private void btnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isLoaded = false;
                Product pUpdate = new Product();
                pUpdate.Id = int.Parse(txtMa.Text);
                pUpdate.Name = txtTen.Text;
                pUpdate.Quantity = int.Parse(txtSoLuong.Text);
                pUpdate.Price = double.Parse(txtDonGia.Text);
                bool kq = productService.UpdateProduct(pUpdate);
                if (kq == true)
                {
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = productService.GetProducts();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
                isLoaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap không hợp lệ " + ex.Message);
            }
           
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ret = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ret == MessageBoxResult.No) 
                return;
            try
            {
                isLoaded = false;
                int id = int.Parse(txtMa.Text);
                bool kq = productService.DeleteProduct(id);
                if (kq == true)
                {
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = productService.GetProducts();
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtSoLuong.Text = "";
                    txtDonGia.Text = "";
                }
                isLoaded = true;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
    }
}
