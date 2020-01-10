using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private Panel pnlTop;
        private Button btnReduc;
        private Main _MotherForm;
        private String _Title;
        private String[] _Headers;
        private int _SizeTable;
        private List<TextBox> _Inputs;
        private ArrayList _ArrayParam;


        public AddRow(Main xMain, string xTitle, string[] xHeaders, int xSizeTable)
        {   
            InitializeComponent();
            _MotherForm = xMain;
            _Title = xTitle;
            _Headers = xHeaders;
            _SizeTable = xSizeTable;
            _Inputs = new List<TextBox>();
            loadComponent();
        }
        public AddRow(Main xMain, string xTitle, string[] xHeaders, int xSizeTable, ArrayList xArrayParam)
        {
            InitializeComponent();
            _MotherForm = xMain;
            _Title = xTitle;
            _Headers = xHeaders;
            _SizeTable = xSizeTable;
            _ArrayParam = xArrayParam;
            _Inputs = new List<TextBox>();
            loadComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRow));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReduc = new System.Windows.Forms.Button();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxHour = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxType = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpError = new System.Windows.Forms.TableLayoutPanel();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.tlpError.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(15, 20);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(15, 20, 20, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.pnlTop.Controls.Add(this.btnReduc);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(400, 30);
            this.pnlTop.TabIndex = 25;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
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
            this.tlpFooter.Location = new System.Drawing.Point(0, 425);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.Size = new System.Drawing.Size(400, 75);
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
            this.btnSave.Location = new System.Drawing.Point(220, 20);
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 20, 15, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBody.Location = new System.Drawing.Point(0, 99);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.Size = new System.Drawing.Size(400, 261);
            this.tlpBody.TabIndex = 27;
            // 
            // txtBoxHour
            // 
            this.txtBoxHour.Location = new System.Drawing.Point(0, 0);
            this.txtBoxHour.Name = "txtBoxHour";
            this.txtBoxHour.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHour.TabIndex = 0;
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
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 3;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHeader.Controls.Add(this.lblTitle, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(0, 30);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(400, 69);
            this.tlpHeader.TabIndex = 28;
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
            // tlpError
            // 
            this.tlpError.ColumnCount = 1;
            this.tlpError.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpError.Controls.Add(this.lblError, 0, 0);
            this.tlpError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpError.Location = new System.Drawing.Point(0, 363);
            this.tlpError.Name = "tlpError";
            this.tlpError.RowCount = 1;
            this.tlpError.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpError.Size = new System.Drawing.Size(400, 62);
            this.tlpError.TabIndex = 29;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(394, 62);
            this.lblError.TabIndex = 0;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddRow
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.tlpBody);
            this.Controls.Add(this.tlpError);
            this.Controls.Add(this.tlpHeader);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRow";
            this.TopMost = true;
            this.pnlTop.ResumeLayout(false);
            this.tlpFooter.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.tlpError.ResumeLayout(false);
            this.tlpError.PerformLayout();
            this.ResumeLayout(false);

        }

        private void loadComponent()
        {
            loadLblTxtBox();
            loadExtraParam();
            
        }
        private void loadLblTxtBox()
        {
            String[] headers = _Headers;
            this.tlpBody.RowCount = headers.Length * 2;
            this.lblTitle.Text = _Title.ToUpperInvariant();

            for (int i = 0; i < headers.Length; i++)
            {
                String headName = headers[i];
                if (headName is null) break;
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
                txtBox.Text = headName;
                if (headName.Equals("XPRIXUNITAIRE"))
                {
                    txtBox.Text = "0";
                }
                else if (headName.Equals("XDOB") || headName.Equals("XDATE"))
                {
                    txtBox.Text = "dd.mm.yyyy";
                }
                else if (headName.Equals("XHEURE"))
                {
                    txtBox.Text = "hh:mm";
                }
                else if (headName.Equals("XPAYE") || headName.Equals("XACTIF"))
                {
                    txtBox.Text = "true ou false";
                }
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

        private void loadExtraParam()
        {
            if (_Title.Equals("agenda") && _ArrayParam != null)
            {
                _Inputs[2].Text = _ArrayParam[0].ToString();
            }
            if (_Title.Equals("factures") && _ArrayParam != null)
            {
                _Inputs[2].Text = _ArrayParam[0].ToString();
                _Inputs[3].Text = _ArrayParam[1].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxLast_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveAndClose();
            }
        }
        public void RemoveText(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "dd.mm.yyyy" || txtBox.Text == "hh:mm" || txtBox.Text == "true ou false")
            {
                txtBox.Text = "";
                return;
            }
            for (int i = 0; i < _Headers.Length; i++)
            {
                if (txtBox.Text == _Headers[i])
                {
                    txtBox.Text = "";
                    break;
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnReduc_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAndClose();
        }
        private void saveAndClose()
        {
            Boolean isAnyEmpty = false;
            ArrayList arrParam = new ArrayList();
            errorMessage("");

            isAnyEmpty = _Inputs.Any(x => x.Text.Equals(""));
            if (isAnyEmpty)
            {
                errorMessage("Veuillez remplir tout les élements du formulaire");
                return;
            }

            if (_Title.Equals("agenda"))
            {
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXDATE"));
                if (!isDateValid(textBox.Text))
                {
                    errorMessage("Date non conforme(ex:01.01.2019)");
                    return;
                }
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXHEURE"));
                if (!isHourValid(textBox.Text))
                {
                    errorMessage("Heure non conforme (ex:08:15)");
                    return;
                }
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXNOMCLIENT"));
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXTYPE"));
                arrParam.Add(textBox.Text);

                //insert agenda with query
                DataSetISpaDataTableAdapters.VW_AGENDATableAdapter tableAdapter = new DataSetISpaDataTableAdapters.VW_AGENDATableAdapter();
                tableAdapter.InsertQuery(Convert.ToDateTime(arrParam[0]), Convert.ToDateTime(arrParam[1]) , arrParam[2].ToString(), arrParam[3].ToString());

                //tableAdapter.InsertQuery(Convert.ToDateTime(arrParam[0]), Convert.ToDateTime(arrParam[1]), arrParam[2].ToString(), arrParam[3].ToString());

                _MotherForm.addRow(arrParam);
            }

            if (_Title.Equals("clients"))
            {
                //first_name,last_name,d.o.b,email,adresse
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXPRENOM"));
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXNOM"));
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXDOB"));
                if (!isDateValid(textBox.Text))
                {
                    errorMessage("Date de naissance non conforme (ex:01.01.2019");
                    return;
                }
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXEMAIL"));
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXADRESSE"));
                arrParam.Add(textBox.Text);

                //insert client with query
                DataSetISpaDataTableAdapters.VW_CLIENTTableAdapter tableAdapter = new DataSetISpaDataTableAdapters.VW_CLIENTTableAdapter();
                tableAdapter.InsertQuery(arrParam[0].ToString(), arrParam[1].ToString(), Convert.ToDateTime(arrParam[2]), arrParam[3].ToString(), arrParam[4].ToString());


                _MotherForm.addRow(arrParam);
            }

            if (_Title.Equals("factures"))
            {
                //Date d'ouverture,ID Client,Nom Client,Type,Prix,Payé
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXDATE"));
                if (!isDateValid(textBox.Text))
                {
                    errorMessage("Date de naissance non conforme (ex:01.01.2019)");
                    return;
                }
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXHEURE"));
                if (!isHourValid(textBox.Text))
                {
                    errorMessage("Heure non conforme (ex:08:15)");
                    return;
                }
                arrParam.Add(textBox.Text);
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXNOMCLIENT"));
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXTYPE"));
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXPRIX"));
                double outDouble;
                if (double.TryParse(textBox.Text, out outDouble))
                {
                    errorMessage("Prix non conforme (ex: 5,00");
                    return;
                }
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXPAYE"));
                if (!(textBox.Text.ToLower() == "true" || textBox.Text.ToLower() == "false"))
                {
                    errorMessage("Boolean de paiement non conforme (ex:true ou false");
                    return;
                }
                arrParam.Add(textBox.Text);

                DateTime date1 = Convert.ToDateTime(arrParam[0]);
                DateTime time1 = Convert.ToDateTime(arrParam[1]);

                //insert factures with query
                DataSetISpaDataTableAdapters.VW_FACTURE1TableAdapter tableAdapter = new DataSetISpaDataTableAdapters.VW_FACTURE1TableAdapter();
                tableAdapter.InsertQuery(date1, time1, arrParam[2].ToString(), arrParam[3].ToString(), arrParam[4].ToString(), Convert.ToDecimal(arrParam[5]));

                _MotherForm.addRow(arrParam);
            }
            if (_Title.Equals("products"))
            {
                //nom,description,fournisseur,prix
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXNOM"));
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXDESCRIPTION"));
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXFOURNISSEUR"));
                arrParam.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXPRIX"));
                arrParam.Add(textBox.Text);

                //insert product with query
                DataSetISpaDataTableAdapters.VW_PRODUITTableAdapter tableAdapter = new DataSetISpaDataTableAdapters.VW_PRODUITTableAdapter();
                tableAdapter.InsertQuery(arrParam[0].ToString(), arrParam[1].ToString(), arrParam[2].ToString(), Convert.ToDecimal(arrParam[3]));

                _MotherForm.addRow(arrParam);
            }

            if (_Title.Equals("users"))
            {
                DataSetISpaData datas = new DataSetISpaData();
                ArrayList arr = new ArrayList();
                

                // set attributes from form
                TextBox textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXNOM"));
                arr.Add(textBox.Text);
                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXPASSWORD"));
                arr.Add(textBox.Text);

                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXTYPE"));
                arr.Add(textBox.Text);

                textBox = _Inputs.Find(x => x.Name.Contains("txtBoxXACTIF"));
                if (!(textBox.Text.ToLower() == "true" || textBox.Text.ToLower() == "false"))
                {
                    errorMessage("Boolean Actif non conforme (ex:true ou false)");
                    return;
                }
                arr.Add(textBox.Text == "true" ? 1 : 0);

                //insert user with query
                DataSetISpaDataTableAdapters.VW_USERTableAdapter tableAdapter = new DataSetISpaDataTableAdapters.VW_USERTableAdapter();
                tableAdapter.InsertQuery(arr[0].ToString(), arr[1].ToString(), arr[2].ToString(), Convert.ToDecimal(arr[3]));

                //refresh current table
                _MotherForm.addRow(arrParam);
            }
            this.Close();
        }
        private bool isDateValid(String xDate)
        {
            DateTime date;
            if (!DateTime.TryParse(xDate, out date))
            {
                return false;
            }

            if (!DateTime.TryParseExact(
                xDate,
                "dd.MM.yyyy",
                new CultureInfo("fr-CH"),
                DateTimeStyles.None,
                out date))
            {
                return false;
            }

            return true;
        }
        private bool isHourValid(String xHour)
        {
            DateTime heure;
            if (!DateTime.TryParseExact(
                xHour,
                "HH:mm",
                new CultureInfo("fr-CH"),
                DateTimeStyles.None,
                out heure))
            {
                return false;
            }

            return true;
        }
        private void errorMessage(String xMsg)
        {
            lblError.Text = xMsg;
        }
    }
}
