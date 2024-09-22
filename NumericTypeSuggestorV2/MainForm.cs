using System.Numerics;

namespace NumericTypeSuggestorV2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void minValueInput_TextChanged(object sender, EventArgs e)
        {
            bool minValueIsExisting = BigInteger.TryParse(minValueInput.Text, out BigInteger minValue);
            bool maxValueExisting = BigInteger.TryParse(maxValueInput.Text, out BigInteger maxValue);


            if (string.IsNullOrEmpty(minValueInput.Text) && minValueIsExisting == true)
            {
                minValueInput.BackColor = Color.Red;
            }
            else
            {
                minValueInput.BackColor = Color.White;



                if (minValue > maxValue)
                {
                    maxValueInput.BackColor = Color.Red;
                }
                else
                {
                    maxValueInput.BackColor = Color.White;
                }
            }

        }

        private bool IsNotValid(char keyChar)
        {


            return !(char.IsDigit(keyChar) || char.IsControl(keyChar));
        }

        private void minValueInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNotValid(e.KeyChar))
            {

                e.Handled = true;
            }

        }

        private void maxValueInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNotValid(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maxValueInput_TextChanged(object sender, EventArgs e)
        {
            bool minValueIsExisting = BigInteger.TryParse(minValueInput.Text, out BigInteger minValue);
            bool maxValueExisting = BigInteger.TryParse(maxValueInput.Text, out BigInteger maxValue);

            if (string.IsNullOrEmpty(maxValueInput.Text))
            {
                maxValueInput.BackColor = Color.Red;
            }
            else
            {
                minValueInput.BackColor = Color.White;



                if (minValue > maxValue || minValueIsExisting == false)
                {
                    minValueInput.BackColor = Color.Red;
                }
                else
                {
                    maxValueInput.BackColor = Color.White;
                }



            }

            UpdateResult();

        }

        private void integralCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void mustBePreciseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void UpdateResult()
        {
            bool integralOnlyState = integralCheckBox.Checked;
            bool mustBePreciseState = mustBePreciseCheckBox.Checked;
            bool minValueExisting = decimal.TryParse(minValueInput.Text, out decimal minValue);
            bool maxValueExisting = decimal.TryParse(maxValueInput.Text, out decimal maxValue);

            //integral numbers

            if ((minValue >= 0 && maxValue <= 100_000))
            {
                resultOutput.Text = "float";
            }
            else if ((minValue < long.MinValue || maxValue > ulong.MaxValue) && integralOnlyState)
            {
                resultOutput.Text = "BigInteger";
            }
            else if ((minValue >= -1 && maxValue <= 5) && integralOnlyState)
            {
                resultOutput.Text = "sbyte";
            }
            else if ((minValue >= -30_000 && maxValue <= 30_000) && integralOnlyState)
            {
                resultOutput.Text = "short";
            }
            else if ((minValue >= 0 && maxValue <= 1_000_000) && integralOnlyState)
            {
                resultOutput.Text = "uint";
            }
            else if ((minValue >= -1 && maxValue <= 1_000_000) && integralOnlyState)
            {
                resultOutput.Text = "int";
            }
           




        }
    }
}
