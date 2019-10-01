using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpa
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            RunComponent();
        }

        private void RunComponent()
        {
            loadAgenda();
        }

        private void loadAgenda()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string dir = System.IO.Directory.GetParent(workingDirectory).Parent.FullName;

            string delimit = ",";
            string tableName = "AgendaTable";
            string fileName = dir + "/datas/agenda.csv";

            DataSet data = new DataSet();
            System.IO.StreamReader sr = new System.IO.StreamReader(fileName);

            data.Tables.Add(tableName);
            data.Tables[tableName].Columns.Add("Date");
            data.Tables[tableName].Columns.Add("Heure");
            data.Tables[tableName].Columns.Add("Client");
            data.Tables[tableName].Columns.Add("Type");

            string allData = sr.ReadToEnd();
            string[] rows = allData.Split("\r".ToCharArray());

            foreach(string r in rows)
            {
                string[] items = r.Split(delimit.ToCharArray());
                data.Tables[tableName].Rows.Add(items);
            }
            this.dataGridView1.DataSource = data.Tables[0].DefaultView;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
