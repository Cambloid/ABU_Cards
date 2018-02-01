using ABU_Cards.Cards.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABU_Cards
{
    /// <summary>
    ///
    /// </summary>
    public partial class FrmMainView : Form
    {
        private CardCollector cards;
        
        /// <summary>
        ///
        /// </summary>
        public FrmMainView()
        {
            InitializeComponent();
            this.cards = new CardCollector();

            this.Shown += new System.EventHandler(this.FrmMainView_Shown);
            this.lstCards.ItemSelectionChanged += lstCards_ItemSelectionChanged;
        }
        
        private void fillListView()
        {
            string cardName   = string.Empty;
            string cardIndex  = string.Empty;
            ListViewItem item = null;
            ListViewGroup grp = null;
            foreach (ABUCardBase card in this.cards.CardCollection)
            {
                cardIndex = card.CardIndex.ToString();
                cardName  = "Karte " + cardIndex;
                
                grp  = new ListViewGroup("");
                item = new ListViewItem();

                item.Tag       = card;
                item.Group     = grp;
                item.Text      = cardName;
                item.BackColor = Color.Red;

                this.lstCards.Items.Add(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardToPresent"></param>
        private void presentCard(ABUCardBase cardToPresent)
        {
            this.pnlAnswer.Controls.Clear();
            this.pnlAnswer.Controls.Add(cardToPresent.CardAnswerBox);

            this.rtbQuestion.Clear();
            this.rtbQuestion.Text = cardToPresent.Description();

            this.btnCheck.Enabled = cardToPresent.CanBeChecked;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainView_Shown(object sender, EventArgs e)
        {
            this.cards.CollectAllCards();
            this.fillListView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCards_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem item = e.Item;
            if (item != null)
            {
                this.presentCard((ABUCardBase)item.Tag);
            }
        }

    }
}
