using ABU_Cards.Base.Interfaces;
using ABU_Cards.Cards.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ABU_Cards.Cards.Base
{
    public class CardCollector
    {
        private List<ABUCardBase> cardCollection;

        public CardCollector()
        {

        }

        /// <summary>
        /// Sammle alle Karten
        /// </summary>
        public void CollectAllCards() {
            List<ABUCardBase> objects = new List<ABUCardBase>();

            Type[] classCollection = Assembly.GetAssembly(typeof(ABUCardBase)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(ABUCardBase))).ToArray();
            foreach (Type type in classCollection)
            {
                objects.Add((ABUCardBase)Activator.CreateInstance(type));
            }

            objects.Sort();
            this.cardCollection = objects;
        }

        public List<ABUCardBase> CardCollection 
        {
            get { return this.cardCollection; }
        }


    }
}
