﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Oracle_Test
{
    public partial class thuHoiQuyenRoleChinhSachScreen : Form
    {
        public thuHoiQuyenRoleChinhSachScreen()
        {
            InitializeComponent();
        }

        private void xem_btn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();

            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();

            try
            {
                string name = "admin1.xemQuyenRoleObject";
                OracleCommand cmd = new OracleCommand(name, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter
                    ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));
                cmd.Parameters.Add("rolename", OracleDbType.NVarchar2).Value = role_text.Text;
                cmd.ExecuteNonQuery();

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "User Id=" + globalConnect.userid +
                ";Password=" + globalConnect.password + ";Data Source=localhost:1521/xe";
            con.Open();
            //string connect_string = "grant create session to " + username_text.Text + ";";
            try
            {
                using (OracleCommand cmd = new OracleCommand("admin1.revokeExecuteFunction", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("object_name", OracleDbType.NVarchar2).Value = object_text.Text;
                    cmd.Parameters.Add("role_name", OracleDbType.NVarchar2).Value = rolename_text.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thu hồi thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            functionScreen f = new functionScreen();
            f.Show();
            this.Hide();
        }
    }
}
