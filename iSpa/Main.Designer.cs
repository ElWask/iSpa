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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFacture = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnAgrandir = new System.Windows.Forms.Button();
            this.btnReduc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.panel2.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.pictLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 660);
            this.panel1.TabIndex = 25;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 130);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(163, 37);
            this.lblWelcome.TabIndex = 28;
            this.lblWelcome.Text = "lblWelcome";
            // 
            // pictLogo
            // 
            this.pictLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(0, 0);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(210, 122);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictLogo.TabIndex = 27;
            this.pictLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(122)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.btnFacture);
            this.panel2.Controls.Add(this.btnProduit);
            this.panel2.Controls.Add(this.btnAgenda);
            this.panel2.Controls.Add(this.btnClient);
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 480);
            this.panel2.TabIndex = 26;
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFacture.Location = new System.Drawing.Point(0, 151);
            this.btnFacture.Margin = new System.Windows.Forms.Padding(0);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(210, 50);
            this.btnFacture.TabIndex = 3;
            this.btnFacture.Text = "btnFacture";
            this.btnFacture.UseVisualStyleBackColor = false;
            // 
            // btnProduit
            // 
            this.btnProduit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnProduit.Location = new System.Drawing.Point(0, 101);
            this.btnProduit.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(210, 50);
            this.btnProduit.TabIndex = 2;
            this.btnProduit.Text = "btnProduit";
            this.btnProduit.UseVisualStyleBackColor = false;
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAgenda.Location = new System.Drawing.Point(0, 1);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(210, 50);
            this.btnAgenda.TabIndex = 1;
            this.btnAgenda.Text = "btnAgenda";
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClient.Location = new System.Drawing.Point(0, 51);
            this.btnClient.Margin = new System.Windows.Forms.Padding(0);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(210, 50);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "btnClient";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
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
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1200, 660);
            this.Controls.Add(this.btnReduc);
            this.Controls.Add(this.btnAgrandir);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFacture;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnAgrandir;
        private System.Windows.Forms.Button btnReduc;
    }
}