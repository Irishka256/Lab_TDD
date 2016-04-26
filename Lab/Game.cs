using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    /// <summary>
    /// Класс игровой логики
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Номер игрока
        /// </summary>
        private int player;
        /// <summary>
        /// Номер вопроса
        /// </summary>
        private int question;
        /// <summary>
        /// Список вопросов <Ответ, Вопрос>
        /// </summary>
        private List<KeyValuePair<int, String>> questions;

        public Game() { }

        public void LoadQuestions()
        {

        }


        public int Player
        {
            get { return player; }
            set { player = value; }
        }

        public int Question
        {
            get { return question; }
            set { question = value; }
        }

        public List<KeyValuePair<int, String>> Questions
        {
            get { return questions; }
            set { questions = value; }
        }

    }
}
