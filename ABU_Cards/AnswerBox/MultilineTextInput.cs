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
    public partial class MultilineTextInput : UserControl, IAnswerBox
    {
        /// <summary>
        /// 
        /// </summary>
        public MultilineTextInput()
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
                return new Solution(new List<dynamic> { this.txtInput.Text });
            }
            set
            {
                this.txtInput.Text   = value.Answers[0];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correctSolution"></param>
        public void CheckAnswer(Solution correctSolution)
        {
            return;
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

    }
}
