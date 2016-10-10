using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class ScoreCalculator : Form
    {
        int score, scoreCount, scoreTotal = 0;
        public ScoreCalculator()
        {
            InitializeComponent();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            score = 0;
            scoreCount = 0;
            scoreTotal = 0;
            textScore.Clear();
            textAverage.Clear();
            textScoreCount.Clear();
            textScoreTotal.Clear();

            textScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            score = Convert.ToInt32(textScore.Text);
            scoreTotal = scoreTotal + score;
            textScoreTotal.Text = Convert.ToString(scoreTotal);
            scoreCount = scoreCount + 1;
            textScoreCount.Text = Convert.ToString(scoreCount);
            int average = scoreTotal / scoreCount;
            textAverage.Text = Convert.ToString(average);

            textScore.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
