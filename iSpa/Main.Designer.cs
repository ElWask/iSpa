namespace iSpa
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.btnAgrandir = new System.Windows.Forms.Button();
            this.btnReduc = new System.Windows.Forms.Button();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.tlbMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.btnFacture = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.tlbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.tlpHeader.ColumnCount = 6;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHeader.Controls.Add(this.picAdd, 0, 0);
            this.tlpHeader.Controls.Add(this.closeBtn, 5, 0);
            this.tlpHeader.Controls.Add(this.btnAgrandir, 4, 0);
            this.tlpHeader.Controls.Add(this.btnReduc, 3, 0);
            this.tlpHeader.Controls.Add(this.picEdit, 0, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(990, 40);
            this.tlpHeader.TabIndex = 25;
            this.tlpHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpHeader_Paint_1);
            this.tlpHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpHeader_MouseDown);
            this.tlpHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlpHeader_MouseMove);
            this.tlpHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlpHeader_MouseUp);
            // 
            // picAdd
            // 
            this.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(40, 0);
            this.picAdd.Margin = new System.Windows.Forms.Padding(0);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(40, 40);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAdd.TabIndex = 28;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(950, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 40);
            this.closeBtn.TabIndex = 21;
            this.closeBtn.Text = "r";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgrandir
            // 
            this.btnAgrandir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgrandir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgrandir.FlatAppearance.BorderSize = 0;
            this.btnAgrandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrandir.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Bold);
            this.btnAgrandir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.btnAgrandir.Location = new System.Drawing.Point(910, 0);
            this.btnAgrandir.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgrandir.Name = "btnAgrandir";
            this.btnAgrandir.Size = new System.Drawing.Size(40, 40);
            this.btnAgrandir.TabIndex = 26;
            this.btnAgrandir.Text = "1";
            this.btnAgrandir.UseVisualStyleBackColor = true;
            this.btnAgrandir.Click += new System.EventHandler(this.btnAgrandir_Click);
            // 
            // btnReduc
            // 
            this.btnReduc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReduc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReduc.FlatAppearance.BorderSize = 0;
            this.btnReduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduc.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Bold);
            this.btnReduc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.btnReduc.Location = new System.Drawing.Point(870, 0);
            this.btnReduc.Margin = new System.Windows.Forms.Padding(0);
            this.btnReduc.Name = "btnReduc";
            this.btnReduc.Size = new System.Drawing.Size(40, 40);
            this.btnReduc.TabIndex = 27;
            this.btnReduc.Text = "0";
            this.btnReduc.UseVisualStyleBackColor = true;
            this.btnReduc.Click += new System.EventHandler(this.btnReduc_Click);
            // 
            // picEdit
            // 
            this.picEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEdit.Image = ((System.Drawing.Image)(resources.GetObject("picEdit.Image")));
            this.picEdit.Location = new System.Drawing.Point(0, 0);
            this.picEdit.Margin = new System.Windows.Forms.Padding(0);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(40, 40);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEdit.TabIndex = 23;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tlbMain
            // 
            this.tlbMain.ColumnCount = 1;
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbMain.Controls.Add(this.dgv, 0, 1);
            this.tlbMain.Controls.Add(this.tlpHeader, 0, 0);
            this.tlbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbMain.Location = new System.Drawing.Point(210, 0);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.RowCount = 2;
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbMain.Size = new System.Drawing.Size(990, 660);
            this.tlbMain.TabIndex = 30;
            this.tlbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tlbMain_Paint_1);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.dgv.Location = new System.Drawing.Point(3, 43);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.ShowEditingIcon = false;
            this.dgv.ShowRowErrors = false;
            this.dgv.Size = new System.Drawing.Size(984, 614);
            this.dgv.TabIndex = 24;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick_1);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClient.Location = new System.Drawing.Point(0, 236);
            this.btnClient.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(210, 51);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "&Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnProduit
            // 
            this.btnProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProduit.FlatAppearance.BorderSize = 0;
            this.btnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnProduit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProduit.Location = new System.Drawing.Point(0, 288);
            this.btnProduit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(210, 51);
            this.btnProduit.TabIndex = 2;
            this.btnProduit.Text = "&Produit";
            this.btnProduit.UseVisualStyleBackColor = false;
            this.btnProduit.Click += new System.EventHandler(this.btnProduit_Click_1);
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnFacture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFacture.FlatAppearance.BorderSize = 0;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnFacture.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFacture.Location = new System.Drawing.Point(0, 340);
            this.btnFacture.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(210, 51);
            this.btnFacture.TabIndex = 3;
            this.btnFacture.Text = "&Facture";
            this.btnFacture.UseVisualStyleBackColor = false;
            this.btnFacture.Click += new System.EventHandler(this.btnFacture_Click_1);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 132);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(204, 52);
            this.lblWelcome.TabIndex = 28;
            this.lblWelcome.Text = "lblWelcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click_1);
            // 
            // pictLogo
            // 
            this.pictLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(3, 3);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(204, 126);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictLogo.TabIndex = 27;
            this.pictLogo.TabStop = false;
            this.pictLogo.Click += new System.EventHandler(this.pictLogo_Click_1);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAgenda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgenda.Location = new System.Drawing.Point(0, 184);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(210, 51);
            this.btnAgenda.TabIndex = 1;
            this.btnAgenda.Text = "&Agenda";
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.btnAgenda, 0, 2);
            this.tlpButtons.Controls.Add(this.pictLogo, 0, 0);
            this.tlpButtons.Controls.Add(this.lblWelcome, 0, 1);
            this.tlpButtons.Controls.Add(this.btnProduit, 0, 4);
            this.tlpButtons.Controls.Add(this.btnClient, 0, 3);
            this.tlpButtons.Controls.Add(this.btnFacture, 0, 5);
            this.tlpButtons.Controls.Add(this.btnUsers, 0, 6);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 8;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpButtons.Size = new System.Drawing.Size(210, 660);
            this.tlpButtons.TabIndex = 29;
            this.tlpButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpButtons_Paint_1);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnUsers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsers.Location = new System.Drawing.Point(0, 392);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(210, 51);
            this.btnUsers.TabIndex = 29;
            this.btnUsers.Text = "&Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1200, 660);
            this.Controls.Add(this.tlbMain);
            this.Controls.Add(this.tlpButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tlpHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.tlbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button btnAgrandir;
        private System.Windows.Forms.Button btnReduc;
        private System.Windows.Forms.TableLayoutPanel tlbMain;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button btnFacture;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.PictureBox picAdd;
    }
}