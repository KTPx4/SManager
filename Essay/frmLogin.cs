﻿using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components;
namespace Essay
{
    public partial class frmLogin : Form
    {


        private bool _dragging = false;
        private Point _startPoint;
        private String Password = "";




        public frmLogin()
        {
            InitializeComponent();
        }

        //Form load
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Style();

        }

        private void Style()
        {

            panelLogin.BackColor = Color.FromArgb(100, 183, 195, 199);

            //Moving form
            panelTitle = new DraggablePanel(panelTitle, this);


        }

        //Title custom
        private void ptbMini_MouseHover(object sender, EventArgs e)
        {
            panelMini.BackColor = Color.FromArgb(100, 250, 250, 250);
        }

        private void ptbClose_MouseHover(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(100, 250, 250, 250);

        }

        private void ptbMini_MouseLeave(object sender, EventArgs e)
        {
            panelMini.BackColor = Color.Transparent;
        }

        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Transparent;
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Close?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void ptbMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }





        // buton login
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackgroundColor = Color.Fuchsia;
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundColor = Color.Transparent;
            btnLogin.ForeColor = Color.Fuchsia;
        }


        // btn Clear text
        private void btnClear_Hover(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;

            ptb.Size = new Size(17, 18);


        }
        private void btnClear_Leave(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;

            ptb.Size = new Size(15, 16);

        }

        private void ptbClear_1_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void ptbClear_2_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }







        //show - hide pass



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Password);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = ckShow.Checked ? '\0' : '*';
        }


        // Action for Login
        private void Login()
        {
            if (txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Username or Password not invalid", "Login Failed");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
