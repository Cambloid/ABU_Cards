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
    public partial class IntegerOnly : UserControl, IAnswerBox
    {
        /// <summary>
        /// 
        /// </summary>
        public IntegerOnly()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public IntegerOnly(string text)
        {
            InitializeComponent();
            this.lblText.Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public Solution Answer
        {
            get
            {
                return new Solution(new List<dynamic> { this.convertIntFromString(this.txtInput.Text) });
            }
            set
            {
                this.txtInput.Text   = value.Answers[0].ToString();
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
                picCheck.Image = new Bitmap(global::ABU_Cards.Properties.Resources.ic_check_black_48dp_1x);
            } else {
                picCheck.Image = new Bitmap(global::ABU_Cards.Properties.Resources.ic_close_black_48dp_1x);
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
            this.txtInput.Clear();
        }

        private int convertIntFromString(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return 0;
            }
            return Convert.ToInt32(input);
        }

    }
}
