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

namespace ABU_Cards.AnswerBox
{
    /// <summary>
    /// 
    /// </summary>
    public partial class YesNoTable : UserControl, IAnswerBox
    {

        private string[] names = null;

        /// <summary>
        /// 
        /// </summary>
        public YesNoTable()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public YesNoTable(string[] names)
        {
            InitializeComponent();
            this.names = names;

            this.fillGrid(names);
        }


        /// <summary>
        /// 
        /// </summary>
        public Solution Answer
        {
            get
            {
                bool[] yesCol = new bool[this.names.Count()];
                bool[] noCol  = new bool[this.names.Count()];
                for(int i = 0; i < this.names.Count(); i++)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[i];
                    yesCol[i] = (bool)row.Cells[1].Value;
                    noCol[i] = (bool)row.Cells[2].Value;
                }
                return new Solution(new List<dynamic> { yesCol, noCol });
            }
            set
            {
                bool[] yesCol = value.Answers[0];
                bool[] noCol  = value.Answers[1];

                // Angemeldete Lösung an Checkboxen übertragen 
                for (int i = 0; i < this.names.Count(); i++)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[i];
                    row.Cells[1].Value = yesCol[i];
                    row.Cells[2].Value = noCol[i];
                }

                // this.chkJa.Checked   = value.Answers[0];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correctSolution"></param>
        public void CheckAnswer(Solution correctSolution)
        {
            bool[] yesCol = correctSolution.Answers[0];
            bool[] noCol = correctSolution.Answers[1];

            for (int i = 0; i < this.names.Count(); i++)
            {
                DataGridViewRow row = this.dataGridView1.Rows[i];
                bool rowYes = (bool)row.Cells[1].Value;
                bool rowNo  = (bool)row.Cells[2].Value;
                
                if(rowYes == yesCol[i])
                {
                    row.Cells[1].Style.BackColor = Color.Green;
                } else
                {
                    row.Cells[1].Style.BackColor = Color.Red;
                }

                if (rowNo == noCol[i])
                {
                    row.Cells[2].Style.BackColor = Color.Green;
                }
                else
                {
                    row.Cells[2].Style.BackColor = Color.Red;
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
            this.dataGridView1.Rows.Clear();
            this.fillGrid(this.names);
        }
    
        /// <summary>
        /// 
        /// </summary>
        private void fillGrid(string[] names)
        {
            DataGridViewTextBoxColumn dgText = new DataGridViewTextBoxColumn();
            dgText.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgText.HeaderText = "Text";
            dgText.ReadOnly = true;
            dataGridView1.Columns.Insert(0, dgText);

            DataGridViewCheckBoxColumn dgJa = new DataGridViewCheckBoxColumn();
            dgJa.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgJa.HeaderText = "Ja";
            dgJa.FalseValue = false;
            dgJa.TrueValue = true;
            dataGridView1.Columns.Insert(1, dgJa);

            DataGridViewCheckBoxColumn dgNein = new DataGridViewCheckBoxColumn();
            dgNein.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgNein.HeaderText = "Nein";
            dgNein.FalseValue = false;
            dgNein.TrueValue = true;
            dataGridView1.Columns.Insert(2, dgNein);

            foreach (string name in names)
            {
                this.dataGridView1.Rows.Add(name, false, false);
            }
        }

    }
}
