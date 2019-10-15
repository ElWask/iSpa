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
            this.closeBtn = new System.Windows.Forms.Button();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAgrandir = new System.Windows.Forms.Button();
            this.btnReduc = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.btnFacture = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.btnAgenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(1171, -1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 21;
            this.closeBtn.Text = "r";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // picEdit
            // 
            this.picEdit.Location = new System.Drawing.Point(210, 0);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(50, 50);
            this.picEdit.TabIndex = 23;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(210, 50);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(990, 610);
            this.dgv.TabIndex = 24;
            // 
            // btnAgrandir
            // 
            this.btnAgrandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgrandir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgrandir.FlatAppearance.BorderSize = 0;
            this.btnAgrandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrandir.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Bold);
            this.btnAgrandir.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgrandir.Location = new System.Drawing.Point(1141, -1);
            this.btnAgrandir.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgrandir.Name = "btnAgrandir";
            this.btnAgrandir.Size = new System.Drawing.Size(30, 30);
            this.btnAgrandir.TabIndex = 26;
            this.btnAgrandir.Text = "1";
            this.btnAgrandir.UseVisualStyleBackColor = true;
            this.btnAgrandir.Click += new System.EventHandler(this.btnAgrandir_Click);
            // 
            // btnReduc
            // 
            this.btnReduc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReduc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReduc.FlatAppearance.BorderSize = 0;
            this.btnReduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduc.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Bold);
            this.btnReduc.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnReduc.Location = new System.Drawing.Point(1111, -1);
            this.btnReduc.Margin = new System.Windows.Forms.Padding(0);
            this.btnReduc.Name = "btnReduc";
            this.btnReduc.Size = new System.Drawing.Size(30, 30);
            this.btnReduc.TabIndex = 27;
            this.btnReduc.Text = "0";
            this.btnReduc.UseVisualStyleBackColor = true;
            this.btnReduc.Click += new System.EventHandler(this.btnReduc_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.btnAgenda, 0, 2);
            this.tlpButtons.Controls.Add(this.pictLogo, 0, 0);
            this.tlpButtons.Controls.Add(this.lblWelcome, 0, 1);
            this.tlpButtons.Controls.Add(this.btnFacture, 0, 5);
            this.tlpButtons.Controls.Add(this.btnProduit, 0, 4);
            this.tlpButtons.Controls.Add(this.btnClient, 0, 3);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 7;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpButtons.Size = new System.Drawing.Size(210, 660);
            this.tlpButtons.TabIndex = 29;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClient.Location = new System.Drawing.Point(0, 250);
            this.btnClient.Margin = new System.Windows.Forms.Padding(0);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(210, 59);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "btnClient";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnProduit
            // 
            this.btnProduit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnProduit.Location = new System.Drawing.Point(0, 309);
            this.btnProduit.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(210, 59);
            this.btnProduit.TabIndex = 2;
            this.btnProduit.Text = "btnProduit";
            this.btnProduit.UseVisualStyleBackColor = false;
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFacture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFacture.Location = new System.Drawing.Point(0, 368);
            this.btnFacture.Margin = new System.Windows.Forms.Padding(0);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(210, 59);
            this.btnFacture.TabIndex = 3;
            this.btnFacture.Text = "btnFacture";
            this.btnFacture.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 132);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(204, 59);
            this.lblWelcome.TabIndex = 28;
            this.lblWelcome.Text = "lblWelcome";
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
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAgenda.Location = new System.Drawing.Point(0, 191);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(210, 59);
            this.btnAgenda.TabIndex = 1;
            this.btnAgenda.Text = "btnAgenda";
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1200, 660);
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.btnReduc);
            this.Controls.Add(this.btnAgrandir);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAgrandir;
        private System.Windows.Forms.Button btnReduc;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnFacture;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button btnClient;
    }
}