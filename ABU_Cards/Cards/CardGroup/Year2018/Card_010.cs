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
    public class Card_010 : ABUCardBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override int CardIndex 
        {
            get
            {
                return 10; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Description() 
        {
            StringBuilder build = new StringBuilder();

            build.AppendLine("Geben Sie das gesetzlich");
            build.AppendLine("vorgeschriebene Alter an für die");
            build.AppendLine("a) letztwillige Verfügung (Testament)");
            build.AppendLine("b) religiöse Mündigkeit");
            build.AppendLine("c) Handlungsfähigkeit");
            build.AppendLine("d) Ehemündigkeit");

            return build.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Solution CorrectSolution() 
        {
            return new Solution(new List<dynamic> { 18, 16, 18, 18 });
        }
        
        /// <summary>
        /// 
        /// </summary>
        public override IAnswerBox CardAnswerBox 
        {
            get
            {
                return new AnswerBox.TextBoxStackVertical(new string[] { "a)", "b)", "c)", "d)" }); 
            }
        }

    }
}
