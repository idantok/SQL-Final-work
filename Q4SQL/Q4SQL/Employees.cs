using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Q4SQL
{
    public partial class Employees : Form
    {
        private string empID;
        private int index = 0;
        public Employees()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            SqlFunctions.RefreshEmployee(this.Employee_dg);
        }

        private void RefreshEmployee_btn_Click(object sender, EventArgs e)
        {
            if (index == 0)
                SqlFunctions.RefreshEmployee(this.Employee_dg);
            else
                SqlFunctions.RefresMissionResponsible(this.Employee_dg);

        }


        private void DataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.empID = Employee_dg.CurrentCell.Value.ToString(); // בחירת התעודת זהות של העובד
            this.Hide();
            EmployeeProjectMission epm = new EmployeeProjectMission(empID);
            epm.Show();
     

        }

        private void Emplyee_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (emplyee_cb.Text == "All")
            {
                SqlFunctions.RefreshEmployee(this.Employee_dg);
                index = 0;
            }
            else
            {
                SqlFunctions.RefresMissionResponsible(this.Employee_dg);
                index = 1;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure To raise anyone who works over 5 years?", "5% up", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlFunctions.updateFivePercent();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
                EmployeeSearch emps = new EmployeeSearch();
                emps.Show();
        
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu men = new Menu();
        }

        private void Employees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu men = new Menu();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var men = new Menu();
            men.Closed += (s, args) => this.Close();
            men.Show();
        }
    }
}
