﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvt1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Btncomprar_Click(object sender, EventArgs e)
        {
            Close();
            Form5 OutroForm = new Form5();
            OutroForm.ShowDialog();
        }
    }
}
