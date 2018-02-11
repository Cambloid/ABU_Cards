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
    public class Card_011 : ABUCardBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override int CardIndex 
        {
            get
            {
                return 11; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Description() 
        {
            StringBuilder build = new StringBuilder();

            build.AppendLine("Nennen Sie drei Aufgaben der Rechtsordnung:");

            return build.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Solution CorrectSolution() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("- Ordnung in der Gesellschaft");
            sb.AppendLine("- Gleichheit");
            sb.AppendLine("- Sicherheit");
            sb.AppendLine("(oder ähnliche Antworten wie z.B. Gerechtigkeit,");
            sb.AppendLine("keine Anarchie oder kein rechtloser Zustand)");

            return new Solution(new List<dynamic> { sb.ToString() });
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool CanBeChecked
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override IAnswerBox CardAnswerBox 
        {
            get
            {
                return new AnswerBox.MultilineTextInput(); 
            }
        }

    }
}
