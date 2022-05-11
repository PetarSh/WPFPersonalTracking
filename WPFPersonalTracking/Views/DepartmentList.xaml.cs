using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFPersonalTracking.DB;

namespace WPFPersonalTracking.Views
{
    /// <summary>
    /// Interaction logic for DepartmentList.xaml
    /// </summary>
    public partial class DepartmentList : UserControl
    {
        public DepartmentList()
        {
            InitializeComponent();
            using (PERSONALTRACKINGContext db = new PERSONALTRACKINGContext())
            {
                List<Department> departments = db.Departments.OrderBy(x=>x.DepartmentName).ToList();
                GridDepartment.ItemsSource = departments;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DepartmentPage departmentPage = new DepartmentPage();
            
            departmentPage.ShowDialog();
            using (PERSONALTRACKINGContext db = new PERSONALTRACKINGContext())
            {
                List<Department> departments = db.Departments.OrderBy(x => x.DepartmentName).ToList();
                GridDepartment.ItemsSource = departments;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Department department = (Department)GridDepartment.SelectedItem;
            DepartmentPage departmentPage = new DepartmentPage();
            departmentPage.department = department;
            departmentPage.ShowDialog();

            using (PERSONALTRACKINGContext db = new PERSONALTRACKINGContext())
            {
                List<Department> departments = db.Departments.OrderBy(x => x.DepartmentName).ToList();
                GridDepartment.ItemsSource = departments;
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
