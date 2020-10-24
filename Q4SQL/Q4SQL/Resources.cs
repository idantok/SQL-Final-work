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
    public partial class Resources : Form
    {
        private int index = 0;
        public Resources()
        {
            InitializeComponent();
        }
        

        private void Resources_Load(object sender, EventArgs e)
        {
            SqlFunctions.RefresResources(this.Resources_dg);
            
        }


        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "All")
            { 
                SqlFunctions.RefresResources(this.Resources_dg);
                 index = 0;
            }
            else
            { 
                SqlFunctions.RefreshResourcesBendak(this.Resources_dg);
                index = 1;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (index == 0)
                SqlFunctions.RefresResources(this.Resources_dg);
            else
                SqlFunctions.RefreshResourcesBendak(this.Resources_dg);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var men = new Menu();
            men.Closed += (s, args) => this.Close();
            men.Show();
        }
    }
}
