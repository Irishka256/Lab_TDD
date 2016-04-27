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
        public const int MAX_COUNT = 10;
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
        /// <summary>
        /// Список отобранных вопросов для игры <Ответ, Вопрос>
        /// </summary>
        private List<KeyValuePair<int, String>> selectedQuestions;
        /// <summary>
        /// Количество правильных ответов 1-ого игрока
        /// </summary>
        private int player1;
        /// <summary>
        /// Количество правильных ответов 2-ого игрока
        /// </summary>
        private int player2;

        private Random rand;

        public Game() {
            rand = new Random();
        }

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
                                question += count + "| " + line + "\r\n";
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
            player = 1;
            question = 1;
            player1 = 0;
            player2 = 0;
        }

        /// <summary>
        /// Метод отбора 10 случайных вопросов для игры
        /// </summary>
        public void SelectQuestions()
        {
            selectedQuestions = new List<KeyValuePair<int, String>>();
            if (questions.Count == MAX_COUNT)
            {
                for (int i = 0; i < MAX_COUNT; i++)
                {
                    selectedQuestions.Add(questions[i]);
                }
            }
            else
            {
                int questionsCount = questions.Count; 
                for (int i = 0; i < MAX_COUNT; i++)
                {
                    selectedQuestions.Add(questions[rand.Next(questionsCount)]);
                }
            }
        }

        /// <summary>
        /// Проверяет есть следующий вопрос или нет
        /// </summary>
        /// <returns>false - вопросов нет, игра окончена; true - вопросы есть, игра продолжается</returns>
        public bool HasNextQuestion()
        {
            return (question != (MAX_COUNT + 1));
        }

        /// <summary>
        /// Метод возвращает следующий вопрос
        /// </summary>
        /// <returns></returns>
        public KeyValuePair<int, String> NextQuestion()
        {
            KeyValuePair<int, String> q = selectedQuestions[question - 1];
            question++;
            return q;
        }
        /// <summary>
        /// Метод проверяет ответ игрока с эталонным и увеличивает счетчик правильных ответов текущего игрока
        /// </summary>
        /// <param name="answer"></param>
        public void CheckAnswer(int answer)
        {
            Console.WriteLine("<<<<<<<<<< {0} {1}", player1, player2);
            int needAnswer = selectedQuestions[question - 2].Key;
            if (answer == needAnswer)
            {
                if (1 == player)
                {
                    player1++;
                    player = 2;
                }
                else
                {
                    player2++;
                    player = 1;
                }

            }
            Console.WriteLine(">>>>>>>>>>>> {0} {1}", player1, player2);
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

        public List<KeyValuePair<int, String>> SelectedQuestions
        {
            get { return selectedQuestions; }
            set { selectedQuestions = value; }
        }

        public int Player1
        {
            get { return player1; }
            set { player1 = value; }
        }

        public int Player2
        {
            get { return player2; }
            set { player2 = value; }
        }
    }
}
