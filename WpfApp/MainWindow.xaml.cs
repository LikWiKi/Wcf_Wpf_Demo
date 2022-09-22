using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            loadData();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=D-OS3-LINHNM2\SQLEXPRESS;Initial Catalog=PersonDb;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

        public void loadData()
        {
            ServiceReference.Service1Client person = new ServiceReference.Service1Client();
            var dt = person.GetAllPerson();
            dataGrid.ItemsSource = dt;
        }

        public void clearData()
        {
            txtId.Clear();
            txtName.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference.Service1Client person = new ServiceReference.Service1Client();

            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;

            person.InsertPerson(new ServiceReference.Person()
            {
                id = id,
                Name = name,
                PhoneNumber = phoneNumber
            });

            MessageBox.Show("Thêm mới thành công");
            loadData();
            clearData();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference.Service1Client person = new ServiceReference.Service1Client();

            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;

            person.UpdatePerson(new ServiceReference.Person()
            {
                id = id,
                Name = name,
                PhoneNumber = phoneNumber
            });

            MessageBox.Show("Cập nhật thành công");
            loadData();
            clearData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference.Service1Client person = new ServiceReference.Service1Client();
            int id = int.Parse(txtId.Text);
            person.DeletePerson(id);

            MessageBox.Show("Xóa thành công");
            loadData();
            clearData();
        }
    }
}
