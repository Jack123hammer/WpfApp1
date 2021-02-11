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

namespace WpfApp1
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Test1Entities db = new Test1Entities();
        public MainWindow()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            dg_output.ItemsSource = db.Build.ToList();
            cb.ItemsSource = db.Goods.ToList();
        }
        private void dg_output_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window1 r = new Window1();
            r.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Build f = dg_output.SelectedItem as Build;
            if (f == null)
                return;
            db.Build.Remove(f);
            db.SaveChanges();
            Update();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Build f = new Build
            {
                Name_of_furniture = "dfsdfs",
                Name_of_goods_build = (cb.SelectedItem as Goods).id_goods,
                Name_of_hardware = "dfsdfs",
                
                Number_of_district_build = 3,
                Quantity_of_furniture = 4,
                Quantity_of_hardware = 6
            };
            db.Build.Add(f);
            db.SaveChanges();
            Update();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Build f = dg_output.SelectedItem as Build;
            if (f == null)
                return;
            f.Name_of_hardware = tb.Text;
            db.SaveChanges();
            Update();
        }

        private void dg_output_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Build f = dg_output.SelectedItem as Build;
            if (f == null)
                return;
            tb.Text = f.Name_of_hardware;
        }

      
        private void tb_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            dg_output.ItemsSource = db.Build.Where(t => t.Name_of_hardware.Contains(tb_search.Text)).ToList();
        }
    }
}
