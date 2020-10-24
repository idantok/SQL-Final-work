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
    public partial class EmployeeProjectMission : Form
    {
        public EmployeeProjectMission(string empid)
        {
            InitializeComponent();
            empid_lbl.Text = empid.ToString(); ;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees emp = new Employees();
            emp.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
        }

        private void EmployeeProjectMission_Load(object sender, EventArgs e)
        {
            SqlFunctions.RefreshEmployeePrjoect(dataGridViewProject_dg, empid_lbl.Text);
            SqlFunctions.RefreshEmployeeMission(dataGridViewMission_dg, empid_lbl.Text);
            if (dataGridViewProject_dg.Rows.Count == 0)
            {
                dataGridViewProject_dg.Visible = false;
                projects_lbl.Visible = true;
            }
            // Empty
            else
            {
                dataGridViewProject_dg.Visible = true;
                projects_lbl.Visible = false;
            }
            if (dataGridViewMission_dg.Rows.Count == 0)
            {
                dataGridViewMission_dg.Visible = false;
                missions_lbl.Visible = true;
            }
            // Empty
            else
            {
                dataGridViewMission_dg.Visible = true;
                missions_lbl.Visible = false;
            }
        }
    }
}
