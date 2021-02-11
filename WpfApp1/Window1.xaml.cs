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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private string login;
        Test1Entities db = new Test1Entities();
        public Window1()
        {
            InitializeComponent();
            //login = f;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = db.Employee.SingleOrDefault(t => t.Employee_last_name == tb.Text && t.Employee_first_name == pb.Password);
            if (emp == null)
            {
                MessageBox.Show("sdfgsg");

            }
            else 
            {
                MainWindow m = new MainWindow();
                m.Show();
                Close();
                
            }
        }
    }
}
