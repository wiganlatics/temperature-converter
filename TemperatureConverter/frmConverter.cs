/*
 * Licensed under MIT License. Copyright (c) 2017 Matthew Wright. See LICENSE.txt in solution root for further details.
 */

using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class frmConverter : Form
    {
        private const float absZeroCelsius = -273.15f;
        private const float absZeroFahrenheit = -459.67f;

        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnToFahrenheit_Click(object sender, EventArgs e)
        {
            float celsius;
            if (float.TryParse(txtCelsius.Text, out celsius))
            {
                if (celsius >= absZeroCelsius)
                {
                    float fahrenheit = ((celsius * 9) / 5) + 32;
                    lblFahrenheit.Text = string.Format("{0}{1}F", fahrenheit.ToString(), Convert.ToChar(176));
                }
                else
                {
                    MessageBox.Show(string.Format(Properties.Resources.AbsoluteZeroError, absZeroCelsius.ToString(), Convert.ToChar(176), "C"), Properties.Resources.AbsoluteZeroErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.ConversionError, Properties.Resources.ConversionErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToCelsius_Click(object sender, EventArgs e)
        {
            float fahrenheit;
            if (float.TryParse(txtFahrenheit.Text, out fahrenheit))
            {
                if (fahrenheit >= absZeroFahrenheit)
                {
                    float celsius = ((fahrenheit - 32) * 5) / 9;
                    lblCelsius.Text = string.Format("{0}{1}C", celsius.ToString(), Convert.ToChar(176));
                }
                else
                {
                    MessageBox.Show(string.Format(Properties.Resources.AbsoluteZeroError, absZeroFahrenheit.ToString(), Convert.ToChar(176), "F"), Properties.Resources.AbsoluteZeroErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.ConversionError, Properties.Resources.ConversionErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
