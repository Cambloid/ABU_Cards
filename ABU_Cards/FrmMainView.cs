using ABU_Cards.AnswerBox.Base;
using ABU_Cards.Cards.Base;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FrmMainView : MaterialForm
    {
        private CardCollector cards;
        private ABUCardBase currentCard = null;
        private Dictionary<ABUCardBase, Solution> userSuggestedSolution = null;
        private IAnswerBox currentAnswerBox = null;

        /// <summary>
        /// 
        /// </summary>
        public FrmMainView()
        {
            InitializeComponent();
            this.cards = new CardCollector();
            this.userSuggestedSolution = new Dictionary<ABUCardBase, Solution>();

            this.Shown += new System.EventHandler(this.FrmMainView_Shown);
            this.lsvCards.ItemSelectionChanged += lstCards_ItemSelectionChanged;
            this.btnNext.Click += btnNext_Click;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            
        }

        /// <summary>
        /// Liste alle Karten und generiere Dictionary
        /// </summary>
        private void fillCollections()
        {
            string cardName   = string.Empty;
            string cardIndex  = string.Empty;
            ListViewItem item = null;
            foreach (ABUCardBase card in this.cards.CardCollection)
            {

                this.userSuggestedSolution.Add(card, null);

                cardIndex = card.CardIndex.ToString();
                cardName  = "Karte " + cardIndex;
                
                item = new ListViewItem();

                item.Tag       = card;
                item.Text      = cardName;
                item.BackColor = Color.Red;
                
                this.lsvCards.Items.Add(item);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardToPresent"></param>
        private void presentCard(ABUCardBase cardToPresent)
        {
            // Set Gui
            this.lblText.Text = string.Empty;
            this.lblText.Text = cardToPresent.Description();
            this.btnCheck.Enabled = cardToPresent.CanBeChecked;

            // Load Last suggested Answer
            this.loadLastSuggestedUserAnswer(cardToPresent);
            
            // Fill Globals
            this.currentCard = cardToPresent;
            this.currentAnswerBox = cardToPresent.CardAnswerBox;
            
            this.pnlAnswer.Controls.Clear();
            this.pnlAnswer.Controls.Add(this.currentAnswerBox.GetControl());
        }

        /// <summary>
        /// 
        /// </summary>
        private void loadLastSuggestedUserAnswer(ABUCardBase cardToPresent)
        {
            Solution userSolution = this.userSuggestedSolution[cardToPresent];
            if (userSolution != null)
            {
                this.currentAnswerBox.Answer = this.userSuggestedSolution[cardToPresent];
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void loadNextCard()
        {
            if (this.lsvCards.SelectedItems.Count == 0)
            {
                this.lsvCards.Items[0].Selected = true;
                return;
            }

            int rowCount = this.lsvCards.Items.Count;
            ListViewItem item = this.lsvCards.SelectedItems[0];
            int idx = 0;
            if (item != null)
            {
                idx = item.Index;
            }

            if (idx >= rowCount - 1)
            {
                this.lsvCards.Items[0].Selected = true;

            }
            else
            {
                this.lsvCards.Items[idx + 1].Selected = true;
            }

        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainView_Shown(object sender, EventArgs e)
        {
            this.cards.CollectAllCards();
            this.fillCollections();

            this.loadNextCard();
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Save user selected Answers
            Solution sol = this.currentAnswerBox.Answer;
            if (sol != null)
            {
                this.userSuggestedSolution[this.currentCard] = sol;
            }

            this.loadNextCard();
        }


    }
}
