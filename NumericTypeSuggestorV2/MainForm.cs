using System.Diagnostics.CodeAnalysis;
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
            bool minValueExisting = double.TryParse(minValueInput.Text, out double minValue);
            bool maxValueExisting = double.TryParse(maxValueInput.Text, out double maxValue);

            //integral numbers


            if ((minValue >= -1 && maxValue <= 100) && mustBePreciseState)
            {
                resultOutput.Text = "decimal";
            }
            else if ((minValue < long.MinValue || maxValue > ulong.MaxValue) && integralOnlyState)
            {
                resultOutput.Text = "BigInteger";
            }
            else if ((minValue >= SByte.MinValue && maxValue <= SByte.MaxValue) && integralOnlyState)
            {
                resultOutput.Text = "sbyte";
            }
            else if ((minValue >= short.MinValue && maxValue <= short.MaxValue) && integralOnlyState)
            {
                resultOutput.Text = "short";
            }
            else if ((minValue >= uint.MinValue && maxValue <= uint.MaxValue) && integralOnlyState)
            {
                resultOutput.Text = "uint";
            }
            else if ((minValue >= int.MinValue && maxValue <= int.MaxValue) && integralOnlyState)
            {
                resultOutput.Text = "int";
            }
            else if ((minValue >= 0 && maxValue <= 100_000) && integralOnlyState == false && mustBePreciseState == false)
            {
                resultOutput.Text = "float";
            }
            else if ((minValue < float.MinValue && maxValue <= 0))
            {
                resultOutput.Text = "double";
            }
            else
            {
                resultOutput.Text = "Not enough Data";
            }





        }
    }
}
