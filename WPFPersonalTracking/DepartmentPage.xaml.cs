using System;
using System.Windows;
using WPFPersonalTracking.DB;

namespace WPFPersonalTracking
{
    /// <summary>
    /// Interaction logic for Department.xaml
    /// </summary>
    public partial class DepartmentPage : Window
    {
        public DepartmentPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public Department department;
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(txtDepartmentName.Text.Trim()=="")
            {
                MessageBox.Show("Please fill Department name");
            }
            else
            {
                using (PERSONALTRACKINGContext db = new PERSONALTRACKINGContext())
                {
                    if (department != null && department.Id != 0)
                    {
                        Department updated = new Department();
                        updated.DepartmentName = txtDepartmentName.Text;
                        updated.Id = department.Id;
                        db.Departments.Update(updated);
                        db.SaveChanges();
                        txtDepartmentName.Text = "";
                        MessageBox.Show("Department Updated!");
                    }
                    else
                    {
                        Department dept = new Department();
                        dept.DepartmentName = txtDepartmentName.Text;
                        db.Departments.Add(dept);
                        db.SaveChanges();
                        txtDepartmentName.Text = "";
                        MessageBox.Show("Department Saved!");
                    }
                       


                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(department!=null && department.Id!=0)
            {
                txtDepartmentName.Text = department.DepartmentName;
            }
        }
    }
}
