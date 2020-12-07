using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.BLL;
using System.Windows.Forms;
using QUANLYBANHANG.Model;


namespace QUANLYBANHANG
{
    public partial class Form1 : Form
    {
        private static CustomerBLL cus = new CustomerBLL();
        public Form1()
        {
            InitializeComponent();
            tblCustomer.DataSource = cus.GetAll();
            btnEditCus.Visible = false;
            btnDeleteCus.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lbID_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void btnShowCus_Click(object sender, EventArgs e)
        {
            tblCustomer.DataSource = cus.GetAll();
        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            String[] name = tbNameCus.Text.Split(' ');
            Customer customer = new Customer();
            for (int i=0; i<name.Length-1; i++)
            {
                if (i != name.Length -2)
                {
                    name[i] = name[i] + ' ';
                }
                customer.firstName += name[i];
            }
            customer.lastName = name[name.Length - 1];
            customer.ID = Convert.ToInt32(tbIDCus.Text);
            customer.gender = tbGenderCus.Text;
            customer.address = tbAdressCus.Text;
            customer.birthDate = Convert.ToDateTime(tbBirthCus.Text);
            Console.WriteLine(customer.firstName);
            CustomerBLL.UpdateCus(customer);
            tblCustomer.DataSource = cus.GetAll();
        }

        private void tblCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tblCustomer.Rows[e.RowIndex];
            Customer customer = cus.GetCusByID(row.Cells["id_cus"].Value.ToString());
            tbNameCus.Text = customer.firstName + ' ' + customer.lastName;
            tbIDCus.Text = customer.ID.ToString();
            tbUsernameCus.Text = customer.username.ToString();
            tbBirthCus.Text = customer.birthDate.ToString();
            tbGenderCus.Text = customer.gender.ToString();
            tbAdressCus.Text = customer.address.ToString();
            tbJoinDateCus.Text = customer.joinDate.ToString();
            btnEditCus.Visible = true;
            btnDeleteCus.Visible = true;
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            CustomerBLL.DeleteCus(tbIDCus.Text);
            tblCustomer.DataSource = cus.GetAll();
        }
    }
}
