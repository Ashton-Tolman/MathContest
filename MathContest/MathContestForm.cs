using System.CodeDom.Compiler;

namespace MathContest
{
    public partial class MathContestForm : Form
    {
        public MathContestForm()
        {
            InitializeComponent();
            SetDefaults();
        }
        //Custom Methods-------------------------------------------------------

        int sumbissions = 0;

        private void SetDefaults()
        {
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            GradeTextBox.Text = "";
            StudentAnswerTextBox.Text = "";
            SubmitButton.Enabled = false;
            SummaryButton.Enabled = false;
            AdditionRadioButton.Checked = true;
            GenerateProblem();
            FirstNumberTextBox.Enabled = false;
            SecondNumberTextBox.Enabled = false;
            ValidateFields();
        }

        private bool ValidateFields()
        {
            bool valid = true;
            if (NameTextBox.Text != "")
            {
                NameTextBox.BackColor = Color.White;
            }
            else
            {
                NameTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            return valid;
        }

        private int GenerateProblem()
        {
            int answer = 0, firstNumber = 0, secondNumber = 0;
            
            Random randomNumber = new Random();
            firstNumber = randomNumber.Next(1, 20);
            secondNumber = randomNumber.Next(1, 20);

            FirstNumberTextBox.Text = $"{firstNumber}";
            SecondNumberTextBox.Text = $"{secondNumber}";

            switch (true)
            {
                case bool when AdditionRadioButton.Checked = true:
                    break;
                case bool when SubtractionRadioButton.Checked = true:
                    break;
                case bool when MultiplicationRadioButton.Checked = true:
                    break;
                case bool when DivisionRadioButton.Checked = true:
                    break;
            }
            return answer;
        }

        //Event handlers-------------------------------------------------------
        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateFields())
            {

            }
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateFields())
            {

            }
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateFields())
            {

            }
        }
    }
}
