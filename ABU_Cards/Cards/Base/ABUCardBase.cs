using ABU_Cards.AnswerBox.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABU_Cards.Cards.Base
{
    /// <summary>
    /// 
    /// </summary>
    public class ABUCardBase
    {

        /// <summary>
        /// Konstruktor
        /// </summary>
        public ABUCardBase() { }

        /// <summary>
        /// 
        /// </summary>
        public virtual int CardIndex { get { return 0; } }

        /// <summary>
        /// Beschreibung welche Pro Kaertchen in der Textbox angezeigt wird
        /// </summary>
        /// <returns></returns>
        public virtual string Description()
        {
            return string.Empty;
        }

        /// <summary>
        /// Richtige Antwort pro Kaertchen wird hier angegeben
        /// </summary>
        public virtual Solution CorrectSolution() {
            return new Solution();
        }

        /// <summary>
        /// Option ob das Kärtchen auf fehler überprüft werden kann
        /// Ein Kärtchen wo man ein Text schreiben kann, kann
        /// Beispielsweise nicht überprüft werden.
        /// </summary>
        public virtual bool CanBeChecked { get { return true; } }

        /// <summary>
        ///
        /// </summary>
        public virtual IAnswerBox CardAnswerBox { get { return null; } }

    }
}
