﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Beylik_Savaşları
{
    public partial class FormCanik : Form
    {
        public frmHarita harita;
        public FormCanik()
        {
            InitializeComponent();
        }

        private void FormCanik_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            harita.btnCanikK.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
