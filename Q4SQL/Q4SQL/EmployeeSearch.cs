using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Q4SQL
{
    public partial class EmployeeSearch : Form
    {
        
        public EmployeeSearch()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            if (rx.IsMatch(textBox.Text))
                {
                SqlFunctions.RefreshEmployee(dataGridViewSearch_dg, textBox.Text);
                if (dataGridViewSearch_dg.Rows.Count == 0)
                {
                    dataGridViewSearch_dg.Visible = false;
                    noResult_lbl.Visible = true;
                }
                // Empty
                else
                {
                    dataGridViewSearch_dg.Visible = true;
                    noResult_lbl.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Somthing Wrong");
                dataGridViewSearch_dg.Visible = true;
                noResult_lbl.Visible = false;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            textBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        }
    }
}
