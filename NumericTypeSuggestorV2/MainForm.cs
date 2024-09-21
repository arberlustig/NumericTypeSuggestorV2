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


            if(integralOnlyState == true && 
                Math.Abs(maxValue + minValue) < 1_000_000 &&
                minValue >= 0 )
            {
                resultOutput.Text = "uint";
            }
            else
            {
                resultOutput.Text = "Not enough Data";
            }

            if(integralOnlyState == true &&
                Math.Abs(maxValue + minValue) < ulong.MaxValue &&
                minValue >= 0)
            {
                resultOutput.Text = "BigInteger";
            }
            else
            {
                resultOutput.Text = "Not enough Data";
            }

            if (mustBePreciseState == false &&
                integralOnlyState == false &&
                 Math.Abs(maxValue + minValue) < 100_000 &&
                minValue >= 0) 
                {
                    resultOutput.Text = "float";
                }
            else
                {
                    resultOutput.Text = "Not enough Data";
                }



            }
    }
}
