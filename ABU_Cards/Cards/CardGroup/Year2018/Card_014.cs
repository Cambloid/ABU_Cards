﻿using ABU_Cards.Cards.Base;
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
    public class Card_014 : ABUCardBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override int CardIndex 
        {
            get
            {
                return 14; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Description() 
        {
            StringBuilder build = new StringBuilder();

            build.AppendLine("Vervollständigen Sie folgenden Text!");
            build.AppendLine("OR 1:");
            build.AppendLine("\"Zum Abschluss eines Vertrages ist die");
            build.AppendLine("übereinstimmende gegenseitige ________________");
            build.AppendLine("der Parteien erforderlich.\"");

            return build.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Solution CorrectSolution() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Willensäusserung");

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
