using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyanRossLab3
{
    public partial class Form8 : Form
    {
        int score, scoreCount, scoreTotal = 0;
        List<int> allScores = new List<int>(20);

        private void btnClear_Click(object sender, EventArgs e)
        {
            score = 0;
            scoreCount = 0;
            scoreTotal = 0;
            txtScore.Clear();
            txtAverage.Clear();
            txtScoreCount.Clear();
            txtScoreTotal.Clear();
            allScores.Clear();

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            allScores.Sort();
            string scoresString = "";
            for(int i = 0; i < allScores.Count; i++)
                    scoresString += allScores[i].ToString() + "\n";
            MessageBox.Show(scoresString, "Sorted Scores");
            txtScore.Focus();
        }

        public Form8()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            score = Convert.ToInt32(txtScore.Text);
            allScores.Add(score);
            scoreTotal = scoreTotal + score;
            txtScoreTotal.Text = Convert.ToString(scoreTotal);
            scoreCount = allScores.Count;
            txtScoreCount.Text = Convert.ToString(scoreCount);
            int average = scoreTotal / scoreCount;
            txtAverage.Text = Convert.ToString(average);

            txtScore.Focus();
        }
    }
}
