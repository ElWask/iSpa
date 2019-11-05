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
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        private Label lblTitle;
        private TextBox txtBoxUsername;
        private Label lblError;
        private Panel pnlLineUsername;
        private Panel pnlLinePassword;
        private TextBox txtBoxPass;
        private Button btnClose;
        private Button btnLogin;
        private Boolean isEyeClosed;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.PictureBox picBoxPass;
        private Panel pnlTop;
        private Button btnReduc;
        private System.Windows.Forms.PictureBox picBoxEye;

        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLineUsername = new System.Windows.Forms.Panel();
            this.pnlLinePassword = new System.Windows.Forms.Panel();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.picBoxPass = new System.Windows.Forms.PictureBox();
            this.picBoxEye = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReduc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEye)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(156, 110);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "iSpa";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsername.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxUsername.Location = new System.Drawing.Point(90, 183);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(186, 21);
            this.txtBoxUsername.TabIndex = 1;
            this.txtBoxUsername.Text = "Username";
            this.txtBoxUsername.GotFocus += new System.EventHandler(this.RemoveText);
            this.txtBoxUsername.LostFocus += new System.EventHandler(this.AddText);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(47, 349);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(50, 400);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Connexion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlLineUsername
            // 
            this.pnlLineUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLineUsername.Location = new System.Drawing.Point(50, 210);
            this.pnlLineUsername.Name = "pnlLineUsername";
            this.pnlLineUsername.Size = new System.Drawing.Size(300, 1);
            this.pnlLineUsername.TabIndex = 16;
            // 
            // pnlLinePassword
            // 
            this.pnlLinePassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLinePassword.Location = new System.Drawing.Point(50, 293);
            this.pnlLinePassword.Name = "pnlLinePassword";
            this.pnlLinePassword.Size = new System.Drawing.Size(300, 1);
            this.pnlLinePassword.TabIndex = 19;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPass.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxPass.Location = new System.Drawing.Point(90, 266);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(186, 21);
            this.txtBoxPass.TabIndex = 2;
            this.txtBoxPass.Text = "Username";
            this.txtBoxPass.UseSystemPasswordChar = true;
            this.txtBoxPass.GotFocus += new System.EventHandler(this.RemoveText);
            this.txtBoxPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxPass_KeyUp);
            this.txtBoxPass.LostFocus += new System.EventHandler(this.AddText);
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
            // picBoxLogo
            // 
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(166, 40);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(68, 65);
            this.picBoxLogo.TabIndex = 21;
            this.picBoxLogo.TabStop = false;
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUser.Image")));
            this.picBoxUser.Location = new System.Drawing.Point(50, 170);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(34, 34);
            this.picBoxUser.TabIndex = 22;
            this.picBoxUser.TabStop = false;
            // 
            // picBoxPass
            // 
            this.picBoxPass.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPass.Image")));
            this.picBoxPass.Location = new System.Drawing.Point(50, 253);
            this.picBoxPass.Name = "picBoxPass";
            this.picBoxPass.Size = new System.Drawing.Size(34, 34);
            this.picBoxPass.TabIndex = 23;
            this.picBoxPass.TabStop = false;
            // 
            // picBoxEye
            // 
            this.picBoxEye.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEye.Image")));
            this.picBoxEye.Location = new System.Drawing.Point(316, 256);
            this.picBoxEye.Name = "picBoxEye";
            this.picBoxEye.Size = new System.Drawing.Size(34, 31);
            this.picBoxEye.TabIndex = 24;
            this.picBoxEye.TabStop = false;
            this.picBoxEye.Click += new System.EventHandler(this.picBoxEye_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.pnlTop.Controls.Add(this.btnReduc);
            this.pnlTop.Controls.Add(this.btnClose);
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
            // Login
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.picBoxEye);
            this.Controls.Add(this.picBoxPass);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.pnlLinePassword);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.pnlLineUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEye)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginCred();
        }

        private bool controlAccess(string usr, string pass)
        {
            if (usr.Equals("admin") && pass.Equals("admin")) return true;
            if (usr.Equals("user") && pass.Equals("user")) return true;
            return false;
        }

        private void txtBoxPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginCred();
            }
        }

        private void loginCred()
        {
            Console.WriteLine(txtBoxUsername.Text + txtBoxPass.Text);
            lblError.Text = "";
            if (txtBoxUsername.Text.Equals("") || txtBoxPass.Text.Equals(""))
            {
                lblError.Text = "Erreur d'identifiant, veuillez remplir tout les champs requis";
                return;
            }
            if (!controlAccess(txtBoxUsername.Text, txtBoxPass.Text))
            {
                lblError.Text = "Erreur d'identifiant, veuillez réessayer";
                return;
            }
            Form main = new Main(txtBoxUsername.Text);
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
        public void RemoveText(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "Username")
            {
                txtBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(this.txtBoxPass.Text))
                txtBox.Text = "Username";
        }

        private void picBoxEye_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string dir = System.IO.Directory.GetParent(workingDirectory).Parent.FullName;
            if (!this.isEyeClosed)
            {
                string eyeClosed = dir + "/img/eye closed.png";
                this.picBoxEye.Image = Image.FromFile(eyeClosed);
                this.txtBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                string eye = dir + "/img/eye.png";
                this.picBoxEye.Image = Image.FromFile(eye);
                this.txtBoxPass.UseSystemPasswordChar = true;
            }
            this.isEyeClosed = !this.isEyeClosed;
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

    }
}
