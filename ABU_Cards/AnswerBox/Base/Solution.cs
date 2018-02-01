using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABU_Cards.AnswerBox.Base
{
    public class Solution
    {

        public Solution() {}

        public Solution(List<dynamic> answers) {
            this.Answers = answers;
        }
        
        /// <summary>
        /// Answers from the AnswerBoxes or to check the Answer
        /// </summary>
        public List<dynamic> Answers { get; set; }

    }
}
