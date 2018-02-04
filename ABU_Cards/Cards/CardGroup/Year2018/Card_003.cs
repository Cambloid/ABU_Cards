using ABU_Cards.Cards.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABU_Cards.AnswerBox.Base;
using System.Windows.Forms;

namespace ABU_Cards.Cards.CardGroup.Year2018
{
    /// <summary>
    /// 
    /// </summary>
    public class Card_003 : ABUCardBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override int CardIndex 
        {
            get
            {
                return 3; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Description() 
        {
            StringBuilder build = new StringBuilder();

            build.AppendLine("Volljährig ist, wer mindestens das _____");
            build.AppendLine("Altersjahr erreicht hat");

            return build.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Solution CorrectSolution() 
        {
            return new Solution(new List<dynamic> { 18 });
        }
        
        /// <summary>
        /// 
        /// </summary>
        public override IAnswerBox CardAnswerBox 
        {
            get
            {
                return new AnswerBox.IntegerOnly(); 
            }
        }

    }
}
