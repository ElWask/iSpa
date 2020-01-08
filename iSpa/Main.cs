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
        private String _Role;
        public Main(String xRole)
        {
            _Role = xRole;
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
            if(!_Role.Equals("admin"))
                this.btnUsers.Visible = false;
        }

        private void loadDataInGrid(String xFileName)
        {
            _CurrentTitle = xFileName;
            lblWelcome.Text = xFileName;
            // read datas and put them in datagridview1
            string delimit = ",";
            string tableName = "Table";
            string pathName = dir + "/datas/" + xFileName + ".csv";
            //DataSet data = new DataSet();
            System.IO.StreamReader sr = new System.IO.StreamReader(pathName, Encoding.Default,true);

            //bdd access
            DataSetISpaData dataISpa = new DataSetISpaData();
            Console.WriteLine("file name" + xFileName);
            switch (xFileName)
            {
                case "agenda":
                    DataSetISpaDataTableAdapters.VW_AGENDATableAdapter liste1 = new DataSetISpaDataTableAdapters.VW_AGENDATableAdapter();
                    liste1.Fill(dataISpa.VW_AGENDA);
                    _CurrentDataTable = dataISpa.VW_AGENDA;
                    this.dgv.DataSource = dataISpa.VW_AGENDA.DefaultView;

                    break;
                case "clients":
                    DataSetISpaDataTableAdapters.VW_CLIENTTableAdapter liste2 = new DataSetISpaDataTableAdapters.VW_CLIENTTableAdapter();
                    liste2.Fill(dataISpa.VW_CLIENT);
                    _CurrentDataTable = dataISpa.VW_CLIENT;
                    this.dgv.DataSource = dataISpa.VW_CLIENT.DefaultView;
                    break;
                case "products":
                    DataSetISpaDataTableAdapters.VW_PRODUITTableAdapter liste3 = new DataSetISpaDataTableAdapters.VW_PRODUITTableAdapter();
                    liste3.Fill(dataISpa.VW_PRODUIT);
                    _CurrentDataTable = dataISpa.VW_PRODUIT;
                    this.dgv.DataSource = dataISpa.VW_PRODUIT.DefaultView;
                    break;
                case "factures":
                    DataSetISpaDataTableAdapters.VW_FACTURETableAdapter liste4 = new DataSetISpaDataTableAdapters.VW_FACTURETableAdapter();
                    liste4.Fill(dataISpa.VW_FACTURE);
                    _CurrentDataTable = dataISpa.VW_FACTURE;
                    this.dgv.DataSource = dataISpa.VW_FACTURE.DefaultView;
                    break;
                case "users":
                    DataSetISpaDataTableAdapters.VW_USERTableAdapter liste5 = new DataSetISpaDataTableAdapters.VW_USERTableAdapter();
                    liste5.Fill(dataISpa.VW_USER);
                    _CurrentDataTable = dataISpa.VW_USER;
                    this.dgv.DataSource = dataISpa.VW_USER.DefaultView;
                    break;
                default:
                    DataSetISpaDataTableAdapters.VW_AGENDATableAdapter liste6 = new DataSetISpaDataTableAdapters.VW_AGENDATableAdapter();
                    liste6.Fill(dataISpa.VW_AGENDA);
                    _CurrentDataTable = dataISpa.VW_AGENDA;
                    this.dgv.DataSource = dataISpa.VW_AGENDA.DefaultView;
                    Console.WriteLine("Default case");
                    break;
            };
            Console.WriteLine("START");
            String[] arrHeader = new String[10];
            int i = 0;

            foreach(DataColumn col in _CurrentDataTable.Columns)
            {
                arrHeader[i] = col.ColumnName;
                i++;

            }
 
            Console.WriteLine("salut" + arrHeader[0]+ arrHeader[1]+ arrHeader[2]+ arrHeader[3] + arrHeader[4] + arrHeader[5]);

            _CurrentHeaders = arrHeader;

            //_CurrentDataTable = data.Tables[0];
            //this.dgv.DataSource = data.Tables[0].DefaultView;
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.Sort(this.dgv.Columns[0], ListSortDirection.Ascending);
            this.dgv.ReadOnly = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
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
        }

        private void picEdit_Click(object sender, EventArgs e)
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


        private void btnFacture_Click(object sender, EventArgs e)
        {
            loadDataInGrid("factures");
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

        private void btnProduit_Click_1(object sender, EventArgs e)
        {
            loadDataInGrid("products");
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
                addRow = new AddRow(this, _CurrentTitle, _CurrentHeaders, _CurrentDataTable.Rows.Count);
            }
            else
            {
                addRow = new AddRow(this, _CurrentTitle, _CurrentHeaders, _CurrentDataTable.Rows.Count,xArrayParam);
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
        
            private void dgv_cellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals(e.FormattedValue.ToString()))
                return;
            DataSetISpaData datas = new DataSetISpaData();
            Console.WriteLine(_CurrentTitle);

            String[] arr = new String[dgv.Rows[e.RowIndex].Cells.Count];
            for (int i = 0; i < dgv.Rows[e.RowIndex].Cells.Count; i++)
            {
                arr[i] = dgv.Rows[e.RowIndex].Cells[i].ToString();
            }
            arr[e.ColumnIndex] = e.FormattedValue.ToString();
            switch (_CurrentTitle)
            {
                case "agenda":
                    DataSetISpaDataTableAdapters.VW_AGENDATableAdapter tableAdapter1 = new DataSetISpaDataTableAdapters.VW_AGENDATableAdapter();
                    break;
                case "clients":
                    DataSetISpaDataTableAdapters.VW_CLIENTTableAdapter tableAdapte2 = new DataSetISpaDataTableAdapters.VW_CLIENTTableAdapter();
                    break;
                case "produits":
                    DataSetISpaDataTableAdapters.VW_PRODUITTableAdapter tableAdapter3 = new DataSetISpaDataTableAdapters.VW_PRODUITTableAdapter();
                    break;
                case "facture":
                    DataSetISpaDataTableAdapters.VW_FACTURETableAdapter tableAdapte4 = new DataSetISpaDataTableAdapters.VW_FACTURETableAdapter();
                    break;
                case "users":
                    DataSetISpaDataTableAdapters.VW_USERTableAdapter tableAdapter5 = new DataSetISpaDataTableAdapters.VW_USERTableAdapter();
                    int answ = tableAdapter5.UpdateQuery(arr[0], arr[1], arr[2], Convert.ToDecimal(arr[3]), arr[4]);

                    Console.WriteLine("old value " + dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    Console.WriteLine("new value " + e.FormattedValue);
                    Console.WriteLine("answ " + answ);
                    break;
            }


            Console.WriteLine("cell value changed");
            Console.WriteLine(e.ColumnIndex + " " + e.RowIndex);
        }
        private void cellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

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
                    
                    String prenomNom = this.dgv.Rows[rowSelected].Cells[1].Value.ToString() + " " + this.dgv.Rows[rowSelected].Cells[2].Value.ToString();
                    String nom = this.dgv.Rows[rowSelected].Cells[2].Value.ToString();
                    String type = this.dgv.Rows[rowSelected].Cells[3].Value.ToString();
                    if (_CurrentTitle.Equals("clients"))
                    {
                        addRendezVous(prenomNom);
                        return;
                    }
                    if (_CurrentTitle.Equals("agenda"))
                    {
                        addFacture(nom,type);
                        return;
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
        private void addFacture(String xNom,String xType)
        {
            ArrayList arr = new ArrayList();
            arr.Add(xNom);
            arr.Add(xType);
            loadDataInGrid("factures");
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
