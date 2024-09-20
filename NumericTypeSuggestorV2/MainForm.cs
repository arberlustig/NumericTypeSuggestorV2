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

            if (string.IsNullOrEmpty(minValueInput.Text))
            {
                minValueInput.BackColor = Color.Red;
            }
            else
            {
                minValueInput.BackColor = Color.White;

                bool minValueIsExisting = BigInteger.TryParse(minValueInput.Text, out BigInteger minValue);
                bool maxValueExisting =  BigInteger.TryParse(maxValueInput.Text,out BigInteger maxValue);

                if(minValue > maxValue)
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


            return !(char.IsDigit(keyChar)  || char.IsControl(keyChar));
        }

        private void minValueInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsNotValid(e.KeyChar))
            {

                e.Handled = true;   
            }

        }
    }
}
