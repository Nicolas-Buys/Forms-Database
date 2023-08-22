using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_Practice
{
    public partial class MainForm : Form
    {
        Form Login;

        DataHandler handler = new DataHandler();
        public MainForm(Form form)
        {
            Login = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            string FirstName = txtUpdateName.Text, LastName = txtUpdateSurname.Text;
            handler.ExecuteQuery(handler.GetInfoAndQuery(ID, FirstName, LastName));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDDelete.Text);
            handler.ExecuteQuery(handler.GetInfoAndQuery(ID));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string FirstName = txtAddName.Text, LastName = txtAddSurname.Text;
            handler.ExecuteQuery(handler.GetInfoAndQuery(FirstName, LastName));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bye bye");
        }
    }
}
