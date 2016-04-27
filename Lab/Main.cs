using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Main : Form
    {
        Game game = new Game();

        public Main()
        {
            InitializeComponent();
        }

        public void initQuestion()
        {
            questionInput.Text = game.NextQuestion().Value;
            labelQuestion.Text = "Вопрос № " + (game.Question - 1);
            labelPlayer.Text = "Игрок №  " + (game.Player);
            numericAnswer.Value = 1;
            questionInput.SelectionLength = 0;
            labelResult.Text = game.Player1 + " | " + game.Player2;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            game.LoadQuestions();
            game.Start();
            game.SelectQuestions();

            initQuestion();
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            int answer = Convert.ToInt32(numericAnswer.Value);
            game.CheckAnswer(answer);
            if (game.HasNextQuestion())
            {
                initQuestion();
            }
            else
            {
                int winner = 0;
                if (game.Player1 > game.Player2)
                {
                    winner = 1;
                }
                else if (game.Player2 > game.Player1)
                {
                    winner = 2;
                }

                if (winner == 0)
                {
                    MessageBox.Show("Победила дружба");
                }
                else
                {
                    MessageBox.Show("Победил игрок № " + winner);
                }
                this.Close();
            }
        }
    }
}
