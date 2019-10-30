using System;
using System.Collections;
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
        private bool mouseDown;
        private Point lastLocation;
        private String dir = "";
        private Boolean canEdit, isReduc;
        private DataTable _CurrentDataTable;
        private String _CurrentTitle;
        private String[] _CurrentHeaders;
        public Main()
        {
            InitializeComponent();
            RunComponent();
        }

        private void RunComponent()
        {
            loadComponent();
            loadDataInGrid("agenda");
        }

        private void loadComponent()
        {
            string workingDirectory = Environment.CurrentDirectory;
            dir = System.IO.Directory.GetParent(workingDirectory).Parent.FullName;

            //load image picture
            string edit = dir + "/img/edit.png";
            this.picEdit.Image = Image.FromFile(edit);
        }

        private void loadDataInGrid(String xFileName)
        {
            _CurrentTitle = xFileName;
            // read datas and put them in datagridview1
            string delimit = ",";
            string tableName = "Table";
            string pathName = dir + "/datas/" + xFileName + ".csv";

            DataSet data = new DataSet();
            System.IO.StreamReader sr = new System.IO.StreamReader(pathName);

            string headerLine = sr.ReadLine();
            _CurrentHeaders = headerLine.Split(delimit.ToCharArray());
            data.Tables.Add(tableName);
            foreach (String h in _CurrentHeaders)
            {
                data.Tables[tableName].Columns.Add(h);
            }
            Console.WriteLine(data.Tables);
            string allData = sr.ReadToEnd();
            string[] rows = allData.Split("\n".ToCharArray());

            foreach (string r in rows)
            {
                string[] items = r.Split(delimit.ToCharArray());
                if (items.Length != _CurrentHeaders.Length)
                {
                    Console.WriteLine("Error with row : " + r);
                    continue;
                }
                    
                data.Tables[tableName].Rows.Add(items);
            }
            _CurrentDataTable = data.Tables[0];
            this.dgv.DataSource = data.Tables[0].DefaultView;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.Sort(this.dgv.Columns[0], ListSortDirection.Ascending);
            this.dgv.ReadOnly = true;
        }
         
        private void Form2_Load(object sender, EventArgs e)
        {}


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
            loadDataInGrid("agenda");
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            loadDataInGrid("clients");
        }

        private void btnReduc_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tlpButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnFacture_Click(object sender, EventArgs e)
        {

        }

        private void btnProduit_Click(object sender, EventArgs e)
        {

        }

        private void tlbMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFacture_Click_1(object sender, EventArgs e)
        {
            loadDataInGrid("factures");
        }

        private void tlpHeader_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void tlpHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void tlpHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void tlpHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void tlbMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictLogo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProduit_Click_1(object sender, EventArgs e)
        {
            loadDataInGrid("products");
        }

        private void lblWelcome_Click_1(object sender, EventArgs e)
        {

        }

        private void tlpButtons_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            loadDataInGrid("users");
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            openAddRow();  
        }
        private void openAddRow(ArrayList xArrayParam = null)
        {
            Form addRow;
            if (xArrayParam == null)
            {
                addRow = new AddRow(this, _CurrentTitle, _CurrentHeaders);
            }
            else
            {
                addRow = new AddRow(this, _CurrentTitle, _CurrentHeaders,xArrayParam);
            }
            
            addRow.ShowDialog();
        }

        public void addRow(ArrayList xArrParam)
        {
            DataRow newRow = _CurrentDataTable.NewRow();
            for(int i=0;i< xArrParam.Count; i++)
            {
                newRow[i] = xArrParam[i];
            }
            _CurrentDataTable.Rows.Add(newRow);
        }

        private void cellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("cell value changed");
            Console.WriteLine(e.ColumnIndex+" " + e.RowIndex);
            Console.WriteLine(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            
        }

        private void dgv_cellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dgv.ClearSelection();
                    this.dgv.Rows[rowSelected].Selected = true;
                    
                    String nom = this.dgv.Rows[rowSelected].Cells[1].Value.ToString() + " " + this.dgv.Rows[rowSelected].Cells[2].Value.ToString();
                    if (_CurrentTitle.Equals("clients"))
                    {
                        addRendezVous(nom);
                    }
                    
                }
            }
            else
            {
                this.dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }

        }

        private void addRendezVous(String xNom)
        {
            ArrayList arr = new ArrayList();
            arr.Add(xNom);
            loadDataInGrid("agenda");
            openAddRow(arr);
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
