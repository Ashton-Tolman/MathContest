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


        //Global variables
        int submissions = 0;
        int correctAnswers = 0;


        //calls the method to fill the first and second numbers
        //as well as all defaults
        private void SetDefaults()
        {
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            GradeTextBox.Text = "";
            StudentAnswerTextBox.Text = "";
            SubmitButton.Enabled = false;
            SummaryButton.Enabled = false;
            AdditionRadioButton.Checked = true;
            FirstNumberTextBox.Enabled = false;
            SecondNumberTextBox.Enabled = false;
            ValidateFields();
            FillNumbers();
        }


        //Normal field validation and range validation for grade and age
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


            //age range validations
            try
            {
                if (int.Parse(AgeTextBox.Text) >= 7 && int.Parse(AgeTextBox.Text) <= 11)
                {
                    AgeTextBox.BackColor = Color.White;
                }
                else
                {
                    AgeTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                AgeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }


            //grade range validations
            try
            {
                if (int.Parse(GradeTextBox.Text) >= 1 && int.Parse(GradeTextBox.Text) <= 4)
                {
                    GradeTextBox.BackColor = Color.White;
                }
                else
                {
                    GradeTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                GradeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }



            if (StudentAnswerTextBox.Text != "")
            {
                StudentAnswerTextBox.BackColor = Color.White;
            }
            else
            {
                StudentAnswerTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            return valid;
        }


        //method to fill the first and second numbers
        private void FillNumbers()
        {
            int firstNumber = 0, secondNumber = 0;

            Random randomNumber = new Random();
            firstNumber = randomNumber.Next(1, 20);
            secondNumber = randomNumber.Next(1, 20);

            FirstNumberTextBox.Text = firstNumber.ToString();
            SecondNumberTextBox.Text = secondNumber.ToString();
        }


        //generates the answer to the math problems
        //as well as picks the operatioin
        private int GenerateProblem()
        {
            int answer = 0, firstNumber = 0, secondNumber = 0;

            firstNumber = int.Parse(FirstNumberTextBox.Text);

            secondNumber = int.Parse(SecondNumberTextBox.Text);


            switch (true)
            {
                case bool when AdditionRadioButton.Checked == true:
                    answer = firstNumber + secondNumber;

                    break;
                case bool when SubtractionRadioButton.Checked == true:
                    answer = firstNumber - secondNumber;

                    break;
                case bool when MultiplicationRadioButton.Checked == true:
                    answer = firstNumber * secondNumber;

                    break;
                case bool when DivisionRadioButton.Checked == true:
                    answer = firstNumber / secondNumber;

                    break;
            }
            return answer;
        }

        //Event handlers-------------------------------------------------------
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int studentAnswer = 0;
            int rightAnswer = GenerateProblem();

            try
            {
                studentAnswer = int.Parse(StudentAnswerTextBox.Text);
                if (studentAnswer == rightAnswer)
                {
                    MessageBox.Show("Thats right!");
                    correctAnswers++;
                }
                else
                {
                    MessageBox.Show("Sorry, thats wrong!");
                }
                submissions++;
                FillNumbers();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid answer ");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {

        }


        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submissions >= 1)
            {
                SetDefaults();
            }
            else
            {
                if (ValidateFields())
                {
                    SubmitButton.Enabled = true;
                }
            }
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submissions >= 1)
            {
                SetDefaults();
            }
            else
            {
                if (ValidateFields())
                {
                    SubmitButton.Enabled = true;
                }
            }
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submissions >= 1)
            {
                SetDefaults();
            }
            else
            {
                if (ValidateFields())
                {
                    SubmitButton.Enabled = true;
                }
            }
        }

        private void StudentAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                StudentAnswerTextBox.BackColor = Color.LightYellow;
            }
        }
    }
}
