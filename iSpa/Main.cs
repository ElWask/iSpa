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
        private Boolean canEdit, isReduc;
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

            //load image picture

            string edit = dir + "/img/edit.png";
            this.picEdit.Image = Image.FromFile(edit);

            // read datas and put them in datagridview1
            string delimit = ",";
            string tableName = "Table";
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
            this.dgv.DataSource = data.Tables[0].DefaultView;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.Sort(this.dgv.Columns[0], ListSortDirection.Ascending);
            this.dgv.ReadOnly = true;
        }

        private void loadClient()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string dir = System.IO.Directory.GetParent(workingDirectory).Parent.FullName;

            //load image picture

            string edit = dir + "/img/edit.png";
            this.picEdit.Image = Image.FromFile(edit);

            // read datas and put them in datagridview1
            string delimit = ",";
            string tableName = "Table";
            string fileName = dir + "/datas/client.csv";

            DataSet data = new DataSet();
            System.IO.StreamReader sr = new System.IO.StreamReader(fileName);

            string headerLine = sr.ReadLine();
            string[] headers = headerLine.Split(delimit.ToCharArray());
            data.Tables.Add(tableName);
            foreach (String h in headers)
            {
                data.Tables[tableName].Columns.Add(h);
            }




            string allData = sr.ReadToEnd();
            string[] rows = allData.Split("\r".ToCharArray());

            foreach (string r in rows)
            {
                string[] items = r.Split(delimit.ToCharArray());
                data.Tables[tableName].Rows.Add(items);
            }
            this.dgv.DataSource = data.Tables[0].DefaultView;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.Sort(this.dgv.Columns[0], ListSortDirection.Ascending);
            this.dgv.ReadOnly = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string clientId;
            object value = this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (value is DBNull) { return; }

            clientId = value.ToString();
            Console.WriteLine("client id "+clientId);
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string dir = System.IO.Directory.GetParent(workingDirectory).Parent.FullName;

            if (!this.canEdit)
            {
                string noEdit = dir + "/img/no edit.png";
                this.picEdit.Image = Image.FromFile(noEdit);
                dgv.ReadOnly = false;
            }
            else
            {
                string eye = dir + "/img/edit.png";
                this.picEdit.Image = Image.FromFile(eye);
                dgv.ReadOnly = true;
            }
            this.canEdit = !this.canEdit;
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            loadAgenda();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            loadClient();
        }

        private void btnAgrandir_Click(object sender, EventArgs e)
        {

            if (!this.isReduc)
            {
                this.btnAgrandir.Text = "2";
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.btnAgrandir.Text = "1";
                WindowState = FormWindowState.Normal;
            }
            this.isReduc = !this.isReduc;
        }
    }
}
