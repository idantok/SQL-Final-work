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
    class SqlFunctions
    {


           static SqlConnection con = new SqlConnection("Data Source=LAPTOP-GEN75GGT;Initial Catalog=Project4u;Integrated Security=True");
           static public void RefreshEmployee(DataGridView _DataGridView)
        { 
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblEmployees ", con);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                 _DataGridView.DataSource = dataTable;
                 _DataGridView.ReadOnly = true ;
                con.Close();
        }


        static public void RefreshEmployee(DataGridView _DataGridView, string empid)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select EmpID, FirstName + ' '+ LastName as FullName,Salary, Year(Getdate()) - Year(StartDate) as Seniority from tblEmployees WHERE EmpID =" + empid, con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            _DataGridView.DataSource = dataTable;
            _DataGridView.ReadOnly = true;
            con.Close();
        }

        static public void RefreshEmployeePrjoect(DataGridView _DataGridView, string empid)
        {

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ProjectName FROM tblEmployees te JOIN tblProjects tp ON tp.ProjectManager = te.EmpID WHERE ProjectManager = "+empid, con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            _DataGridView.DataSource = dataTable;
            _DataGridView.ReadOnly = true;
            con.Close();
        }

        static public void RefreshEmployeeMission(DataGridView _DataGridView, string empid)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MissionName FROM tblEmployees te JOIN tblProjectMissions tpm ON tpm.Responsible = te.EmpID WHERE Responsible ="+empid, con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            _DataGridView.DataSource = dataTable;
            _DataGridView.ReadOnly = true;
            con.Close();
        }

        static public void RefreshResourcesBendak(DataGridView _DataGridView)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT r.ResourceID, Descreption, CostPrice, QuantityAvailable FROM tblResources r  JOIN tblWorkResources w  ON r.ResourceID = w.ResourceID JOIN tblMaterialResources m  ON R.ResourceID = m.ResourceID WHERE Supplier = 'BENDAK' AND UnitMeasure = 'KG' AND QuantityAvailable >= 5", con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            _DataGridView.DataSource = dataTable;
            _DataGridView.ReadOnly = true;
            con.Close();
        }

        static public void RefresResources(DataGridView _DataGridView)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From tblResources", con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            _DataGridView.DataSource = dataTable;
            _DataGridView.ReadOnly = true;
            con.Close();
        }

        static public void RefresMissionResponsible(DataGridView _DataGridView)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select distinct tblProjectMissions.Responsible, FirstName + ' ' + LastName AS FullName, Salary,(DATEDIFF(year, tblEmployees.StartDate, getdate())) as Seniority,count(Responsible) as NumOfMission from tblProjectMissions inner join tblEmployees on tblEmployees.EmpID = tblProjectMissions.Responsible left outer join tblProjects on Responsible = ProjectManager where tblProjects.ProjectManager is null group by tblProjectMissions.Responsible, FirstName, LastName, tblEmployees.StartDate, Salary", con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            _DataGridView.DataSource = dataTable;
            _DataGridView.ReadOnly = true;
            con.Close();
        }

        static public void updateFivePercent()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("update tblEmployees set Salary = Salary * 1.05 where DATEDIFF(YEAR, StartDate, getdate()) > 5", con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            con.Close();
        }



    }

}

