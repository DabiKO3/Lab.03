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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }


        private void btnAddProcessor_Click_1(object sender, EventArgs e)
        {
            Processor processor = new Processor();
            fProcessor ft = new fProcessor(processor);
            if (ft.ShowDialog() == DialogResult.OK)

            {
                tbProcessorInfo.Text +=
                    string.Format("Назва процесора: {0}. Виробник: {1}. Кількість ядер:" +
                    " {2:0.0} ''. Частота: {3:0.0} Ггц ''. Тепловіділення: {4:0.0} ''. " +
                    "Кількість транзитів: {5:0.0} {6} ",
                    processor.Name,
                    processor.Manufacturer,
                    processor.Cores,
                    processor.Frequency,
                    processor.TDP,
                    processor.Transistors,
                    processor.Yes ? " Так, пітримує багаточність " : " Ні, не пітримує багатоточність ",
                    processor.No ? " Ні, не пітримує багатоточність " : " Так, пітримує багаточність ");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
                               "Припинити роботу",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}