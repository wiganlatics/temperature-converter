
namespace TemperatureConverter
{
    using System;
    using System.Windows.Forms;

    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnToFahrenheit_Click(object sender, EventArgs e)
        {
            float celsius;
            if (float.TryParse(txtCelsius.Text, out celsius))
            {
                float fahrenheit = ((celsius * 9) / 5) + 32;
                lblFahrenheit.Text = string.Format("{0}{1}F", fahrenheit.ToString(), Convert.ToChar(176));
            }
            else
            {
                MessageBox.Show("Error, you must enter a valid number.", "Temperature Converter - Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToCelsius_Click(object sender, EventArgs e)
        {
            float fahrenheit;
            if (float.TryParse(txtFahrenheit.Text, out fahrenheit))
            {
                float celsius = ((fahrenheit - 32) * 5) / 9;
                lblCelsius.Text = string.Format("{0}{1}C", celsius.ToString(), Convert.ToChar(176));
            }
            else
            {
                MessageBox.Show("Error, you must enter a valid number.", "Temperature Converter - Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
