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
    public class Card_009 : ABUCardBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override int CardIndex 
        {
            get
            {
                return 9; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Description() 
        {
            StringBuilder build = new StringBuilder();

            build.AppendLine("Die Rechtsfähigkeit ist:");

            build.AppendLine("a) Die Fähigkeit zu machen, was ich will.");
            build.AppendLine("b) Das Recht vor Gericht zu klagen.");
            build.AppendLine("c) Die Fähigkeit, Rechte und Pflichten zu haben.");
            build.AppendLine("d) Die Fähigkeit, Verträge zu unterschreiben.");

            return build.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Solution CorrectSolution() 
        {
            return new Solution(new List<dynamic> { new bool[] { false, true, false, false}, new bool[] { true, false, true, true } });
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool CanBeChecked
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override IAnswerBox CardAnswerBox 
        {
            get
            {
                return new AnswerBox.YesNoTable(new string[] { "a)", "b)", "c)", "d)" }); 
            }
        }

    }
}
