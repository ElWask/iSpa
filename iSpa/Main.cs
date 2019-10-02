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

            string headerLine = sr.ReadLine();
            string[] headers = headerLine.Split(delimit.ToCharArray());
            data.Tables.Add(tableName);
            foreach(String h in headers)
            {
                data.Tables[tableName].Columns.Add(h);
            }

            string allData = sr.ReadToEnd();
            string[] rows = allData.Split("\r".ToCharArray());

            foreach(string r in rows)
            {
                string[] items = r.Split(delimit.ToCharArray());
                data.Tables[tableName].Rows.Add(items);
            }
            this.dataGridView1.DataSource = data.Tables[0].DefaultView;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy";
            this.dataGridView1.Columns["Date"].ValueType = typeof(DateTime);
            this.dataGridView1.Columns["Date"].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
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
