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
    public partial class TextBoxStackVertical : UserControl, IAnswerBox
    {
        private int textBoxCount = 0;
        private List<MaterialSingleLineTextField> textBoxCollection = null;
        private List<PictureBox> pictureBoxCollection = null;
        private string[] textBoxText = null;

        /// <summary>
        /// 
        /// </summary>
        public TextBoxStackVertical()
        {
            InitializeComponent();
            //this.checkBoxCount = 1;
            //this.generateCheckBoxes(this.checkBoxCount);
        }

        /// <summary>
        /// 
        /// </summary>
        public TextBoxStackVertical(string[] values)
        {
            InitializeComponent();

            this.textBoxCollection   = new List<MaterialSingleLineTextField>();
            this.pictureBoxCollection = new List<PictureBox>();
            
            this.textBoxCount = values.Count();
            this.textBoxText = values;
            this.generateCheckBoxes(textBoxCount);
        }

        /// <summary>
        /// 10 Checkboxen brauchen 10 antworten im Array bei der Karte CorrectSolution vom Typ boolean
        /// </summary>
        /// <param name="count"></param>
        private void generateCheckBoxes(int count)
        {
            this.picPattern.Visible = false;
            this.txtPattern.Visible = false;
            this.lblPattern.Visible = false;

            MaterialSingleLineTextField txt = null;
            PictureBox box = null;
            MaterialLabel label = null;
            for (int i = 0; i < count; i++)
            {
                txt = new MaterialSingleLineTextField();
                txt.Size = new Size(50, 24);
                txt.Location = new Point(this.txtPattern.Location.X, this.txtPattern.Location.Y + ((this.txtPattern.Height - 3) * i));
                this.Controls.Add(txt);

                label = new MaterialLabel();
                label.Size = new Size(100, 24);
                label.Location = new Point(this.lblPattern.Location.X, txt.Location.Y - 1);
                label.Text = this.textBoxText[i];
                this.Controls.Add(label);

                box = new PictureBox();
                box.Location = new Point(this.picPattern.Location.X, txt.Location.Y - 2);
                box.Size = new Size(25, 25);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(box);

                this.textBoxCollection.Add(txt);
                this.pictureBoxCollection.Add(box);
            }
        }

        /// <summary>
        /// List Entry 0: int[]
        /// </summary>
        public Solution Answer
        {
            get
            {
                // Lösungen von allen Checkboxen holen und diese zurückgeben
                List<dynamic> solution = new List<dynamic>();
                for (int i = 0; i < this.textBoxCount; i++)
                {
                    solution.Add(this.convertIntFromString(this.textBoxCollection[i].Text));
                }
                return new Solution(solution);
            }
            set
            {
                // Angemeldete Lösung an Checkboxen übertragen 
                for (int i = 0; i < this.textBoxCount; i++)
                {
                    this.textBoxCollection[i].Text = value.Answers[i].ToString();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correctSolution"></param>
        public void CheckAnswer(Solution correctSolution)
        {
            for (int i = 0; i < this.textBoxCount; i++)
            {
                if (this.convertIntFromString(this.textBoxCollection[i].Text).Equals(correctSolution.Answers[i])) {
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
            for (int i = 0; i < this.textBoxCount; i++)
            {
                this.textBoxCollection[i].Text = string.Empty;
                this.pictureBoxCollection[i].Image = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int convertIntFromString(string input)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(input);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return result;
        }

    }
}
