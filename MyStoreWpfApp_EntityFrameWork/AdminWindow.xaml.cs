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
using Microsoft.EntityFrameworkCore;
using MyStoreWpfApp_EntityFrameWork.Models;

namespace MyStoreWpfApp_EntityFrameWork
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        MyStoreContext context = new MyStoreContext();
        bool isLodListViewCompleted = false;
        public AdminWindow()
        {
            InitializeComponent();
            DisableDpiAwarenessAttribute();
        }

        private void DisableDpiAwarenessAttribute()
        {
            tvCategory.Items.Clear();
            TreeViewItem root = new TreeViewItem();
            root.Header = "Danh mục sản phẩm";
            root.Tag = "root";

            var categories = context.Categories.ToList();
            foreach (var category in categories)
            {
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category;
                root.Items.Add(cate_node);

                var products = context.Products.Where(p => p.CategoryId == category.CategoryId).ToList();
                foreach (var product in products)
                {
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header = product.ProductName;
                    product_node.Tag = product;
                    cate_node.Items.Add(product_node);
                }
            }
            tvCategory.Items.Add(root);
            root.ExpandSubtree();
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (isLodListViewCompleted = false)
            {
                return;
            }
            TreeViewItem item = e.NewValue as TreeViewItem;
            if (item != null)
            {
                Category category = item.Tag as Category;
                if (category != null)
                {
                    var products = context.Products.Where(p => p.CategoryId == category.CategoryId).ToList();
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                }
            }
            isLodListViewCompleted = true;
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isLodListViewCompleted = false)
                return;
            if (e.AddedItems.Count == 0)
            {
                return;
            }
            Product p = e.AddedItems[0] as Product;
            if (p == null)
                return;
            txtMa.Text = p.ProductId + "";
            txtTen.Text = p.ProductName;
            txtSoLuong.Text = p.UnitsInStock + "";
            txtDonGia.Text = p.UnitPrice + "";
            isLodListViewCompleted = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvitem = tvCategory.SelectedItem as TreeViewItem;
            if (tvitem == null)
            {
                MessageBox.Show("Ban phai chon danh muc truoc", "Loi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Category category = tvitem.Tag as Category;
            if (category == null)
            {
                MessageBox.Show("Ban phai chon danh muc truoc", "Loi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Product p = new Product();
            p.ProductName = txtTen.Text;
            p.UnitsInStock = short.Parse(txtSoLuong.Text);
            p.UnitPrice = decimal.Parse(txtDonGia.Text);
            p.CategoryId = category.CategoryId;
            context.Products.Add(p);
            context.SaveChanges();
            MessageBox.Show("Luu thanh cong");

            // Thêm sản phẩm vào TreeView
            TreeViewItem productNode = new TreeViewItem();
            productNode.Header = p.ProductName;
            productNode.Tag = p;

            tvitem.Items.Add(productNode);
            tvitem.IsExpanded = true;

            //Cập nhật ListView
            var products = context.Products.Where(pr => pr.CategoryId == category.CategoryId).ToList();
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = products;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (isLodListViewCompleted = false)
                return;
            //b1 tim ra san pham muon sua truoc
            int id = int.Parse(txtMa.Text);
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
                return;
            //b2 tien hanh doi gia tri cac thuoc tinhs cua doi tuong
            product.ProductName = txtTen.Text;
            product.UnitsInStock = short.Parse(txtSoLuong.Text);
            product.UnitPrice = decimal.Parse(txtDonGia.Text);
            //b3 xac nhan sua
            context.SaveChanges();
            //b4 cap nhat lai treeview va listview

            // Tìm node danh mục đang chọn
            TreeViewItem tvitem = tvCategory.SelectedItem as TreeViewItem;
            if (tvitem == null)
                return;
            Category category = tvitem.Tag as Category;
            if (category == null)
                return;

            // Xóa các node sản phẩm cũ trong danh mục
            tvitem.Items.Clear();

            // Thêm lại các node sản phẩm mới cho danh mục này
            var products = context.Products.Where(pr => pr.CategoryId == category.CategoryId).ToList();
            foreach (var prod in products)
            {
                TreeViewItem productNode = new TreeViewItem();
                productNode.Header = prod.ProductName;
                productNode.Tag = prod;
                tvitem.Items.Add(productNode);
            }
            tvitem.IsExpanded = true;

            // Cập nhật lại ListView
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = products;
            MessageBox.Show("Cap nhat san pham thanh cong", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);

            isLodListViewCompleted = true;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtMa.Text);
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                MessageBox.Show("Khong tim thay san pham can xoa", "Loi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBoxResult result = MessageBox.Show("Ban co chac chan muon xoa san pham ["+product.ProductName +"] nay?", "Xac nhan", 
                                                                                    MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
                return;
            context.Products.Remove(product);
            context.SaveChanges();
            //cap nhat lai treeview va listview
            TreeViewItem tvitem = tvCategory.SelectedItem as TreeViewItem;
            if (tvitem != null)
            {
                Category category = tvitem.Tag as Category;
                if (category != null)
                {
                    // Xóa hết các node sản phẩm cũ trong danh mục
                    tvitem.Items.Clear();

                    // Thêm lại các node sản phẩm mới cho danh mục này
                    var products = context.Products.Where(pr => pr.CategoryId == category.CategoryId).ToList();
                    foreach (var prod in products)
                    {
                        TreeViewItem productNode = new TreeViewItem();
                        productNode.Header = prod.ProductName;
                        productNode.Tag = prod;
                        tvitem.Items.Add(productNode);
                    }
                    tvitem.IsExpanded = true;

                    // Cập nhật lại ListView
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                    MessageBox.Show("Xoa san pham thanh cong", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
