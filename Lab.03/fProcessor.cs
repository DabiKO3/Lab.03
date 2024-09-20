using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._03
{
    public partial class fProcessor : Form

    {
        internal Processor TheProcessor;

        internal fProcessor( Processor p)
        {
            TheProcessor = p;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fProcessor_Load(object sender, EventArgs e)
        {
               if (TheProcessor != null)
            {
                tbName.Text = TheProcessor.Name;
                tbManufacturer.Text = TheProcessor.Manufacturer;
                tbCores.Text = TheProcessor.Cores.ToString();
                tbFrequency.Text = TheProcessor.Frequency.ToString();
                tbTDP.Text = TheProcessor.TDP.ToString();
                tbTransistors.Text = TheProcessor.Transistors.ToString();

                chbYes.Checked = TheProcessor.Yes;
                chbNo.Checked = TheProcessor.No;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheProcessor.Name = tbName.Text.Trim();
            TheProcessor.Manufacturer = tbManufacturer.Text.Trim();
            TheProcessor.Cores = int.Parse(tbCores.Text.Trim());
            TheProcessor.Frequency = int.Parse(tbFrequency.Text.Trim());
            TheProcessor.TDP = int.Parse(tbTDP.Text.Trim());
            TheProcessor.Transistors = int.Parse(tbTransistors.Text.Trim());

            TheProcessor.Yes = chbYes.Checked;
            TheProcessor.No = chbNo.Checked;

            DialogResult = DialogResult.OK;
        }

        private void chbNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
