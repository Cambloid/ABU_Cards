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
    public class Card_004 : ABUCardBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override int CardIndex 
        {
            get
            {
                return 4; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Description() 
        {
            StringBuilder build = new StringBuilder();

            build.AppendLine("Urteilsfähig ist, wer");
            build.AppendLine("a) 18 Jahre alt ist.");
            build.AppendLine("b) 15 Jahre alt ist.");
            build.AppendLine("c) Schweizer Bürger/Bürgerin ist");
            build.AppendLine("d) rechtsfähig ist.");
            build.AppendLine("e) vernunftgemäss handeln kann.");

            return build.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Solution CorrectSolution() 
        {
            return new Solution(new List<dynamic> { false, false, false, false, true });
        }
        
        /// <summary>
        /// 
        /// </summary>
        public override IAnswerBox CardAnswerBox 
        {
            get
            {
                return new AnswerBox.CheckBoxStackVertical(new string[] { "a)", "b)", "c)", "d)", "e)" }); 
            }
        }

    }
}
