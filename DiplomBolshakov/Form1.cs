using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomBolshakov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h1 = 0;
            double h2 = 0;
            if (YesRButton.Checked)
            {
                double Fu1 = 0;
                double IndNor1 = 0;
                double CSS = 0;
                try
                {
                    Fu1 = Convert.ToDouble(FU1TBox.Text.Replace('.', ','));
                    IndNor1 = Convert.ToDouble(IndNor1TBox.Text.Replace('.', ','));
                    CSS = Convert.ToDouble(CSSTBox.Text.Replace('.', ','));
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные!");
                    return;
                }

                h1 = 0.6626 * Fu1 + 1.2090 * IndNor1 + 0.2151 * CSS - 21.6656;
                h2 = 0.4872 * Fu1 + 1.6586 * IndNor1 + 0.2512 * CSS - 24.2580;
            }
            else if (NoRButton.Checked)
            {
                double KSR1 = 0;
                double IndNor1 = 0;
                double ADsyst = 0;
                double ADdias = 0;

                try
                {
                    KSR1 = Convert.ToDouble(KSR1TBox.Text.Replace('.', ','));
                    IndNor1 = Convert.ToDouble(IndNor1TBox2.Text.Replace('.', ','));
                    ADsyst = Convert.ToDouble(ADsystTBox.Text.Replace('.', ','));
                    ADdias = Convert.ToDouble(ADdiasTBox.Text.Replace('.', ','));
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные!");
                    return;
                }

                h1 = 8.0369 * KSR1 + 0.7633 * IndNor1 + 0.2670 * ADsyst + 0.0886 * ADdias - 39.7573;
                h2 = 9.4877 * KSR1 + 1.0765 * IndNor1 + 0.3126 * ADsyst + 0.0390 * ADdias - 50.1281;
            }
            else
            {
                MessageBox.Show("Не выбрано заболевание лёгких");
                return;
            }

            if (h1 > h2)
            {
                Resultlabel.ForeColor = Color.Black;
                Resultlabel.Font = new Font(Resultlabel.Font, FontStyle.Regular);
                Resultlabel.Text = "Прогноз осложнений: нет";
            }
            else
            {
                Resultlabel.ForeColor = Color.Red;
                Resultlabel.Font = new Font(Resultlabel.Font, FontStyle.Bold);
                Resultlabel.Text = "Прогноз осложнений: да";
            }
        }

        private void YesRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YesRButton.Checked)
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
            }
        }

        private void NoRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoRButton.Checked)
            {
                panel1.Enabled = false;
                panel2.Enabled = true;
            }
        }
    }
}
