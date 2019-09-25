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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.agenda = new System.Windows.Forms.TabPage();
            this.client = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.produits = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fournisseurs = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.facturation = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.agenda.SuspendLayout();
            this.client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.produits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.fournisseurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.facturation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.agenda);
            this.tabControl1.Controls.Add(this.client);
            this.tabControl1.Controls.Add(this.produits);
            this.tabControl1.Controls.Add(this.fournisseurs);
            this.tabControl1.Controls.Add(this.facturation);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // agenda
            // 
            this.agenda.Controls.Add(this.dataGridView1);
            this.agenda.Location = new System.Drawing.Point(4, 22);
            this.agenda.Name = "agenda";
            this.agenda.Padding = new System.Windows.Forms.Padding(3);
            this.agenda.Size = new System.Drawing.Size(1152, 474);
            this.agenda.TabIndex = 0;
            this.agenda.Text = "Agenda";
            this.agenda.UseVisualStyleBackColor = true;
            this.agenda.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // client
            // 
            this.client.Controls.Add(this.dataGridView2);
            this.client.Location = new System.Drawing.Point(4, 22);
            this.client.Name = "client";
            this.client.Padding = new System.Windows.Forms.Padding(3);
            this.client.Size = new System.Drawing.Size(1152, 474);
            this.client.TabIndex = 1;
            this.client.Text = "Clients";
            this.client.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 462);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1140, 462);
            this.dataGridView2.TabIndex = 3;
            // 
            // produits
            // 
            this.produits.Controls.Add(this.dataGridView3);
            this.produits.Location = new System.Drawing.Point(4, 22);
            this.produits.Name = "produits";
            this.produits.Padding = new System.Windows.Forms.Padding(3);
            this.produits.Size = new System.Drawing.Size(1152, 474);
            this.produits.TabIndex = 2;
            this.produits.Text = "Produits";
            this.produits.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1140, 462);
            this.dataGridView3.TabIndex = 3;
            // 
            // fournisseurs
            // 
            this.fournisseurs.Controls.Add(this.dataGridView4);
            this.fournisseurs.Location = new System.Drawing.Point(4, 22);
            this.fournisseurs.Name = "fournisseurs";
            this.fournisseurs.Padding = new System.Windows.Forms.Padding(3);
            this.fournisseurs.Size = new System.Drawing.Size(1152, 474);
            this.fournisseurs.TabIndex = 3;
            this.fournisseurs.Text = "Fournisseurs";
            this.fournisseurs.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1140, 462);
            this.dataGridView4.TabIndex = 3;
            // 
            // facturation
            // 
            this.facturation.Controls.Add(this.dataGridView5);
            this.facturation.Location = new System.Drawing.Point(4, 22);
            this.facturation.Name = "facturation";
            this.facturation.Size = new System.Drawing.Size(1152, 474);
            this.facturation.TabIndex = 4;
            this.facturation.Text = "Facturation";
            this.facturation.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(1140, 462);
            this.dataGridView5.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.agenda.ResumeLayout(false);
            this.client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.produits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.fournisseurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.facturation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage agenda;
        private System.Windows.Forms.TabPage client;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage produits;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage fournisseurs;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage facturation;
        private System.Windows.Forms.DataGridView dataGridView5;
    }
}