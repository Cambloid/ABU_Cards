using ABU_Cards.AnswerBox.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABU_Cards.AnswerBox.Base
{
    public interface IAnswerBox
    {
        /// <summary>
        /// Answer from the Answerboxes
        /// </summary>
        Solution Answer { get; }

        /// <summary>
        /// Correct Solution for AnswerBoxes
        /// </summary>
        /// <param name="correctSolution"></param>
        void CheckAnswer(Solution correctSolution);

        /// <summary>
        /// Status bzw. GUI zurücksetzen
        /// </summary>
        void ResetBox();
    }
}
