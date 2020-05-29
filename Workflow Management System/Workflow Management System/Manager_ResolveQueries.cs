using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workflow_Management_System
{
    public partial class Manager_ResolveQueries : Form
    {
        public Manager_ResolveQueries()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerHome mh = new ManagerHome();
            mh.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }

        private void Manager_ResolveQueries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDBDataSet5.Query' table. You can move, or remove it, as needed.
            this.queryTableAdapter.Fill(this.workFlowDBDataSet5.Query);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(Query_Id,System.String) like '{0}%' OR Query_Description like '{0}%'", textBox1.Text.ToString());
            dataGridView1.DataSource = bs;
        }
    }
}
