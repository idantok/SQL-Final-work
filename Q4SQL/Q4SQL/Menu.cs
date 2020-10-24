using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4SQL
{
    public partial class Menu : Form
    {
        Resources res = new Resources();
        Employees emp = new Employees();
        public Menu()
        {
            InitializeComponent();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            EmployeeSearch emps = new EmployeeSearch();
            emps.Show();
        }

        private void Employee_ser_btn_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var emp = new Employees();
            emp.Closed += (s, args) => this.Close();
            emp.Show();
        }

        private void Res_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var res = new Resources();
            res.Closed += (s, args) => this.Close();
            res.Show();
        }
    }
}
