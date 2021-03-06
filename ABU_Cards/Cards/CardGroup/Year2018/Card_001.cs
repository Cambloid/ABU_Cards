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
    public class Card_001 : ABUCardBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override int CardIndex 
        {
            get
            {
                return 1; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Description() 
        {
            StringBuilder build = new StringBuilder();

            build.AppendLine("Haben Sie als 20-jährige/r Arbeitnehmer/in");
            build.AppendLine("Anspruch auf 5 Wochen Ferien pro Jahr?");

            return build.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Solution CorrectSolution() 
        {
            return new Solution(new List<dynamic> { true, false });
        }
        
        /// <summary>
        /// 
        /// </summary>
        public override IAnswerBox CardAnswerBox 
        {
            get
            {
                return new AnswerBox.YesNoOnly(); 
            }
        }

    }
}
