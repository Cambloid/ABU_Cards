using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABU_Cards.AnswerBox.Base;
using MaterialSkin.Controls;

namespace ABU_Cards.AnswerBox
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CheckBoxStackVertical : UserControl, IAnswerBox
    {
        private int checkBoxCount = 0;
        private List<MaterialCheckBox> checkBoxCollection = null;
        private List<PictureBox> pictureBoxCollection = null;
        private string[] checkBoxText = null;

        /// <summary>
        /// 
        /// </summary>
        public CheckBoxStackVertical()
        {
            InitializeComponent();
            //this.checkBoxCount = 1;
            //this.generateCheckBoxes(this.checkBoxCount);
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckBoxStackVertical(string[] values)
        {
            InitializeComponent();

            this.checkBoxCollection   = new List<MaterialCheckBox>();
            this.pictureBoxCollection = new List<PictureBox>();
            
            this.checkBoxCount = values.Count();
            this.checkBoxText = values;
            this.generateCheckBoxes(checkBoxCount);
        }

        /// <summary>
        /// 10 Checkboxen brauchen 10 antworten im Array bei der Karte CorrectSolution vom Typ boolean
        /// </summary>
        /// <param name="count"></param>
        private void generateCheckBoxes(int count)
        {
            this.picPattern.Visible = false;
            this.chkPattern.Visible = false;
            this.lblPattern.Visible = false;

            MaterialCheckBox chk = null;
            PictureBox box = null;
            MaterialLabel label = null;
            for (int i = 0; i < count; i++)
            {
                chk = new MaterialCheckBox();
                chk.Size = new Size(24, 24);
                chk.Location = new Point(this.chkPattern.Location.X, this.chkPattern.Location.Y + ((this.chkPattern.Height - 5) * i));
                this.Controls.Add(chk);

                label = new MaterialLabel();
                label.Size = new Size(100, 24);
                label.Location = new Point(this.lblPattern.Location.X, chk.Location.Y - 1);
                label.Text = this.checkBoxText[i];
                this.Controls.Add(label);

                box = new PictureBox();
                box.Location = new Point(this.picPattern.Location.X, chk.Location.Y - 2);
                box.Size = new Size(25, 25);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(box);

                this.checkBoxCollection.Add(chk);
                this.pictureBoxCollection.Add(box);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Solution Answer
        {
            get
            {
                // Lösungen von allen Checkboxen holen und diese zurückgeben
                List<dynamic> solution = new List<dynamic>();
                for (int i = 0; i < this.checkBoxCount; i++)
                {
                    solution.Add(this.checkBoxCollection[i].Checked);
                }
                return new Solution(solution);
            }
            set
            {
                // Angemeldete Lösung an Checkboxen übertragen 
                for (int i = 0; i < this.checkBoxCount; i++)
                {
                    this.checkBoxCollection[i].Checked = value.Answers[i];
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correctSolution"></param>
        public void CheckAnswer(Solution correctSolution)
        {
            for (int i = 0; i < this.checkBoxCount; i++)
            {
                if (this.checkBoxCollection[i].Checked.Equals(correctSolution.Answers[i])) {
                    this.pictureBoxCollection[i].Image = new Bitmap(global::ABU_Cards.Properties.Resources.ic_check_black_48dp_1x);
                    
                } else {
                    this.pictureBoxCollection[i].Image = new Bitmap(global::ABU_Cards.Properties.Resources.ic_close_black_48dp_1x);

                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Control GetControl()
        {
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetBox()
        {
            for (int i = 0; i < this.checkBoxCount; i++)
            {
                this.checkBoxCollection[i].Checked = false;
                this.pictureBoxCollection[i].Image = null;
            }
        }

    }
}
