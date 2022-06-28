using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Checker
{
    public partial class Form1 : Form
    {
        readonly string DefaultText = "Enter Password Here";

        public Form1()
        {
            InitializeComponent();
        }
        private void Password_One_Click(object sender, EventArgs e)
        {
            Password_One.SelectAll();
        }

        private void Password_Two_Click(object sender, EventArgs e)
        {
            Password_two.SelectAll();
        }

        public void Display_Passwd(TextBox passwd, Label[] labels)
        {
            try
            {

                if (passwd.TextLength <= 0 || passwd.Text == null)
                {
                    Zxcvbn.Core.EvaluatePassword(DefaultText);
                    passwd.Text = DefaultText;
                    passwd.SelectAll();
                }

                var Eval_Passwd = Zxcvbn.Core.EvaluatePassword(passwd.Text);

                switch (Eval_Passwd.Score)
                {
                    case 0:
                        labels[0].Text = "Very Weak";
                        labels[0].ForeColor = Color.Red;
                        Result_one.BackColor = Color.White;
                        break;
                    case 1:
                        labels[0].Text = "Weak";
                        labels[0].ForeColor = Color.Orange;
                        labels[0].BackColor = Color.White;
                        break;
                    case 2:
                        labels[0].Text = "Good";
                        labels[0].ForeColor = Color.Yellow;
                        labels[0].BackColor = Color.DarkKhaki;
                        break;
                    case 3:
                        labels[0].Text = "Strong";
                        labels[0].ForeColor = Color.Blue;
                        labels[0].BackColor = Color.White;
                        break;
                    case 4:
                        labels[0].Text = "Very Strong";
                        labels[0].ForeColor = Color.Green;
                        labels[0].BackColor = Color.White;
                        break;
                }

                labels[1].Text = "Guesses: " + Eval_Passwd.Guesses.ToString();
                labels[2].Text = "Warning: " + Eval_Passwd.Feedback.Warning;
                labels[3].Text = "Suggestions: " + Eval_Passwd.Feedback.Suggestions[0];
                labels[4].Text = "Crack Time: " + Eval_Passwd.CrackTimeDisplay.OnlineNoThrottling10PerSecond;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void Password_One_TextChanged(object sender, EventArgs e)
        {
            Label[] Labels_one = { Result_one, Guesses_one, Warning_one, Suggestion_one, Crack_Time_one };

            Display_Passwd(Password_One, Labels_one);

            Compare_Passwd();
        }

        private void Password_two_TextChanged(object sender, EventArgs e)
        {
            Label[] Labels_two = { Result_two, Guesses_two, Warning_two, Suggestion_two, Crack_Time_two };

            Display_Passwd(Password_two, Labels_two);

            Compare_Passwd();
        }

        public void Compare_Passwd()
        {
            var Passwd_one = Zxcvbn.Core.EvaluatePassword(Password_One.Text);
            var Passwd_two = Zxcvbn.Core.EvaluatePassword(Password_two.Text);
            if (Passwd_one.Score == Passwd_two.Score && Passwd_one.CrackTime.OnlineNoThrottling10PerSecond == Passwd_two.CrackTime.OnlineNoThrottling10PerSecond)
            {
                Comp_one.Text = Comp_two.Text = "Same";
                Comp_one.ForeColor = Comp_two.ForeColor = Color.Yellow;
                Comp_one.BackColor = Comp_two.BackColor = Color.DarkKhaki;
            }
            else if (Passwd_one.Score >= Passwd_two.Score && Passwd_one.CrackTime.OnlineNoThrottling10PerSecond >= Passwd_two.CrackTime.OnlineNoThrottling10PerSecond)
            {
                Comp_one.Text = "Stronger";
                Comp_one.ForeColor = Color.Green;
                Comp_one.BackColor = Color.White;
                Comp_two.Text = "Weaker";
                Comp_two.ForeColor = Color.Red;
                Comp_two.BackColor = Color.White;
            }
            else if (Passwd_one.Score <= Passwd_two.Score && Passwd_one.CrackTime.OnlineNoThrottling10PerSecond <= Passwd_two.CrackTime.OnlineNoThrottling10PerSecond)
            {
                Comp_one.Text = "Weaker";
                Comp_one.ForeColor = Color.Red;
                Comp_one.BackColor = Color.White;
                Comp_two.Text = "Stronger";
                Comp_two.ForeColor = Color.Green;
                Comp_two.BackColor = Color.White;
            }
        }
    }
}
