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
            questions = new List<KeyValuePair<int, String>>();
            String[] paths = Directory.GetFiles("Questions", "*.qst");

            System.IO.StreamReader file = null;

            foreach (String path in paths)
            {
                try
                {
                    file = new System.IO.StreamReader(path);
                    if (file != null)
                    {
                        String question = String.Empty;
                        int answer = -1;
                        String line = String.Empty;
                        int count = 0;

                        while ((line = file.ReadLine()) != null)
                        {
                            if (count == 0)
                            {
                                answer = Convert.ToInt32(line);
                            }
                            else
                            {
                                question += count + "| " + line + "\n";
                            }
                            count++;
                        }
                        Console.WriteLine(question);
                        questions.Add(new KeyValuePair<int, String>(answer, question));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Метод старта игры, инициализирует номер игрока и номер вопроса
        /// </summary>
        public void Start()
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
