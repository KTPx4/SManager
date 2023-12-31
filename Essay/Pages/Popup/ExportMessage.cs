﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay.Pages.Popup
{
    public partial class ExportMessage : DevExpress.XtraEditors.XtraForm
    {
        public ExportMessage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult |= DialogResult.Yes;
            this.Close();

        }
    }
}