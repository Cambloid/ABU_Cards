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
    /// <summary>
    /// 
    /// </summary>
    public partial class YesNoOnly : UserControl, IAnswerBox
    {
        /// <summary>
        /// 
        /// </summary>
        public YesNoOnly()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Solution Answer
        {
            get
            {
                return new Solution(new List<dynamic> { this.chkJa.Checked, this.chkNein.Checked });
            }
            set
            {
                this.chkJa.Checked   = value.Answers[0];
                this.chkNein.Checked = value.Answers[1];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correctSolution"></param>
        public void CheckAnswer(Solution correctSolution)
        {
            if(correctSolution.Answers[0].Equals(this.Answer.Answers[0]))
            {
                this.chkJa.BackColor = Color.Green;
            } else {
                this.chkJa.BackColor = Color.Red;
            }

            if (correctSolution.Answers[1].Equals(this.Answer.Answers[1]))
            {
                this.chkNein.BackColor = Color.Green;
            } else {
                this.chkNein.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Control GetControl()
        {
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetBox()
        {
            this.chkJa.BackColor   = Color.Transparent;
            this.chkNein.BackColor = Color.Transparent;
        }

    }
}
