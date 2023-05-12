using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            int horas, rodas;
            double servico, total, precohora;

            horas = (int)nudhoras.Value;
            rodas = (int)nudrodas.Value;
            servico = 0;

            if (rbnacional.Checked)
            {
                precohora = horas * 60;
            }
            else if (rbimportado.Checked)
            {
                precohora = horas * 85;
            }
            else
            {
                precohora = 0;
                MessageBox.Show("Erro na execução");
            }


            if (cbalinhamento.Checked)
            {
                servico += 25;
            }

            if (cbalanceamento.Checked)
            {
                servico += (rodas * 12);
            }

            if (cbcamber.Checked)
            {
                servico += 30;
            }

            if (cbcaster.Checked)
            {
                servico += 20;
            }

            if (rodas == 2)
            {
                servico = 0;
                MessageBox.Show("Erro");
            }

            total = precohora + servico;

            txtvalorpagar.Text = total.ToString();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, btncalcular.Width, btncalcular.Height);
            btncalcular.Region = new Region(forma);
        }

        private void Proximo_Click_1(object sender, EventArgs e)
        {
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();
            Close();
        }
    }
}
