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
        }

        private void Main_Load(object sender, EventArgs e)
        {
            game.LoadQuestions();
            game.Start();
            game.SelectQuestions();

            initQuestion();
        }
    }
}
