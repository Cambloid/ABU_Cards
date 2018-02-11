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
    public class Card_007 : ABUCardBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override int CardIndex 
        {
            get
            {
                return 7; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Description() 
        {
            StringBuilder build = new StringBuilder();

            build.AppendLine("Wer ist in der Schweiz rechtsfähig?");
            build.AppendLine("a) Nur die Schweizer");
            build.AppendLine("b) Alle Menschen");
            build.AppendLine("c) Nur alle volljährigen Schweizer");
            build.AppendLine("d) Alle Einwohner, ausser den Staatenlosen");

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
