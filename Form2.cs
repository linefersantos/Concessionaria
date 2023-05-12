using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
            Form3 OutroForm = new Form3();
            OutroForm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
            Form4 OutroForm = new Form4();
            OutroForm.ShowDialog();
        }
    }
}
