using ABU_Cards.AnswerBox.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABU_Cards.AnswerBox.Base
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAnswerBox
    {
        /// <summary>
        /// Answer from the Answerboxes
        /// </summary>
        Solution Answer { get; set; }

        /// <summary>
        /// Correct Solution for AnswerBoxes
        /// </summary>
        /// <param name="correctSolution"></param>
        void CheckAnswer(Solution correctSolution);

        /// <summary>
        /// Status bzw. GUI zurücksetzen
        /// </summary>
        void ResetBox();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Control GetControl();
    }
}
