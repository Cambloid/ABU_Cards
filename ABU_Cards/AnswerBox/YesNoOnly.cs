using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABU_Cards.AnswerBox.Base;

namespace ABU_Cards.AnswerBox
{
    public partial class YesNoOnly : UserControl, IAnswerBox
    {
        public YesNoOnly()
        {
            InitializeComponent();
        }
        
        public Solution Answer
        {
            get
            {
                return new Solution(new List<dynamic> { this.chkJa.Checked, this.chkNein.Checked });
            }
        }

        public void CheckAnswer(Solution correctSolution)
        {
            if(correctSolution.Answers[0].Equals(this.Answer.Answers[0]))
            {
                this.chkJa.BackColor = Color.Green;
            } else
            {
                this.chkJa.BackColor = Color.Red;
            }

            if (correctSolution.Answers[1].Equals(this.Answer.Answers[1]))
            {
                this.chkNein.BackColor = Color.Green;
            }
            else
            {
                this.chkNein.BackColor = Color.Red;
            }
        }

        public void ResetBox()
        {
            this.chkJa.BackColor   = Color.Transparent;
            this.chkNein.BackColor = Color.Transparent;
        }
    }
}
