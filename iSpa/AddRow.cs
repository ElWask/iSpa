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
    public partial class AddRow : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private Button btnClose;
        private Button btnCancel;
        private Panel panelHeader;
        private Button btnReduc;
        private Main _MotherForm;
        private String _Title;
        private String[] _Headers;
        private List<TextBox> _Inputs;


        public AddRow(Main xMain, string xTitle, string[] xHeaders)
        {   
            InitializeComponent();
            _MotherForm = xMain;
            _Title = xTitle;
            _Headers = xHeaders;
            _Inputs = new List<TextBox>();
            loadComponent(_Headers);
        }

        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnReduc = new System.Windows.Forms.Button();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxHour = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxType = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(25, 30);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(25, 30, 25, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(370, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "r";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.panelHeader.Controls.Add(this.btnReduc);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(400, 30);
            this.panelHeader.TabIndex = 25;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // btnReduc
            // 
            this.btnReduc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReduc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReduc.FlatAppearance.BorderSize = 0;
            this.btnReduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduc.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Bold);
            this.btnReduc.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnReduc.Location = new System.Drawing.Point(340, 0);
            this.btnReduc.Margin = new System.Windows.Forms.Padding(0);
            this.btnReduc.Name = "btnReduc";
            this.btnReduc.Size = new System.Drawing.Size(30, 30);
            this.btnReduc.TabIndex = 0;
            this.btnReduc.Text = "0";
            this.btnReduc.UseVisualStyleBackColor = true;
            this.btnReduc.Click += new System.EventHandler(this.btnReduc_Click);
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 2;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.Controls.Add(this.btnSave, 1, 0);
            this.tlpFooter.Controls.Add(this.btnCancel, 0, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(0, 400);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.Size = new System.Drawing.Size(400, 100);
            this.tlpFooter.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(225, 30);
            this.btnSave.Margin = new System.Windows.Forms.Padding(25, 30, 25, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(0, 0);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDate.TabIndex = 0;
            // 
            // tlpBody
            // 
            this.tlpBody.ColumnCount = 2;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBody.Location = new System.Drawing.Point(0, 99);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.Size = new System.Drawing.Size(400, 301);
            this.tlpBody.TabIndex = 27;
            this.tlpBody.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // txtBoxHour
            // 
            this.txtBoxHour.Location = new System.Drawing.Point(0, 0);
            this.txtBoxHour.Name = "txtBoxHour";
            this.txtBoxHour.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHour.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(0, 0);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 0;
            // 
            // txtBoxType
            // 
            this.txtBoxType.Location = new System.Drawing.Point(0, 0);
            this.txtBoxType.Name = "txtBoxType";
            this.txtBoxType.Size = new System.Drawing.Size(100, 20);
            this.txtBoxType.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(0, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            // 
            // lblHour
            // 
            this.lblHour.Location = new System.Drawing.Point(0, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(100, 23);
            this.lblHour.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 69);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(103, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 69);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "lblTitle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddRow
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpBody);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddRow_Load);
            this.panelHeader.ResumeLayout(false);
            this.tlpFooter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void loadComponent(String[] xHeaders)
        {
            loadLblTxtBox(xHeaders);
            
        }
        private void loadLblTxtBox(String[] xHeaders)
        {
            this.tlpBody.RowCount = xHeaders.Length * 2;
            this.lblTitle.Text = _Title.ToUpperInvariant();

            for (int i = 0; i < xHeaders.Length; i++)
            {
                String headName = xHeaders[i];
                // lbl
                Label newLbl = new Label();
                newLbl.AutoSize = true;
                newLbl.Dock = System.Windows.Forms.DockStyle.Fill;
                newLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                newLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
                newLbl.Location = new System.Drawing.Point(3, 190);
                newLbl.Name = "lbl" + headName;
                newLbl.Size = new System.Drawing.Size(194, 25);
                newLbl.TabIndex = 25;
                newLbl.Text = headName;
                newLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.tlpBody.Controls.Add(newLbl, 0, 2*i);
                // txtBox
                TextBox txtBox = new TextBox();
                txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
                txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
                txtBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                txtBox.ForeColor = System.Drawing.Color.WhiteSmoke;
                txtBox.Location = new System.Drawing.Point(203, 193);
                txtBox.Name = "txtBox"+headName;
                txtBox.Size = new System.Drawing.Size(194, 21);
                txtBox.TabIndex = 21;
                txtBox.Text = "Nom du "+headName;
                txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                txtBox.GotFocus += new System.EventHandler(this.RemoveText);
                this.tlpBody.Controls.Add(txtBox, 1, 2 * i);
                _Inputs.Add(txtBox);
                // 
                // panel
                // 
                Panel panel = new Panel();
                panel.BackColor = System.Drawing.Color.WhiteSmoke;
                panel.Dock = System.Windows.Forms.DockStyle.Top;
                panel.Location = new System.Drawing.Point(203, 128);
                panel.Name = "panel1";
                panel.Size = new System.Drawing.Size(194, 1);
                panel.TabIndex = 16;
                this.tlpBody.Controls.Add(panel, 1, 2 * i + 1);

                this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
                this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddRow_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addRowCred();
            }
        }

        private void addRowCred()
        {
            Form main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
        public void RemoveText(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "jj.MM.yyyy" || txtBox.Text == "hh:mm" || txtBox.Text == "Nom du client" || txtBox.Text == "Type de séance" )
            {
                txtBox.Text = "";
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnReduc_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date, heure;
            String nom, type, first_name, last_name, email, adresse, dob, prix, desc, four;
            long id;
            Boolean hasPayed, isActif;

            if (_Title.Equals("agenda"))
            {
                
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxDate"));
                date = Convert.ToDateTime(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxHeure"));
                heure = Convert.ToDateTime(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxNom"));
                nom = txtBoxName.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxType"));
                type = txtBoxType.Text;
                _MotherForm.addRow(date, heure, nom, type);
            }

            if (_Title.Equals("clients"))
            {
                //id,first_name,last_name,d.o.b,email,adresse
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxfirst_name"));
                first_name = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxlast_name"));
                last_name = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxd.o.b"));
                dob = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxemail"));
                email = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxadresse"));
                adresse = textBox.Text;
                //_MotherForm.addRow(first_name, last_name, dob, email, adresse);
            }

            if (_Title.Equals("factures"))
            {
                //Date d'ouverture,ID Client,Nom Client,Type,Prix,Payé
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxDate d'ouverture"));
                date = Convert.ToDateTime(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxID Client"));
                id = long.Parse(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxNom Client"));
                nom = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxType"));
                type = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxPrix"));
                prix = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxPayé"));
                hasPayed = Convert.ToBoolean(textBox.Text);
                //_MotherForm.addRow(date, id, nom, type, prix, hasPayed);
            }
            if (_Title.Equals("products"))
            {
                //id,nom,description,fournisseur,prix
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxid"));
                id = long.Parse(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxNom"));
                nom = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxdescription"));
                desc = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxfournisseur"));
                four = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxprix"));
                prix = textBox.Text;
                //_MotherForm.addRow(id, nom, desc, four, prix);
            }

            if (_Title.Equals("users"))
            {
                //ID Utilisateur,Nom Utilisateur,Type,Actif
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxID Utilisateur"));
                id = long.Parse(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxNom Utilisateur"));
                nom = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxType"));
                type = textBox.Text;
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxActif"));
                isActif = Convert.ToBoolean(textBox.Text);
                //_MotherForm.addRow(id, nom, type, isActif);
            }
        }
    }
}
