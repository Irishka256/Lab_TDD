﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        Game game = new Game();

        [TestMethod]
        public void TestGameLoadQuestions()
        {
            game.LoadQuestions();
            int realSize = (game.Questions != null ? game.Questions.Count : 0);
            int needMinimalSize = 10;

            if (realSize < needMinimalSize)
            {
                Assert.Fail("Вопросы не загружены. Загружено: {0}. Требуется: >= {1}", realSize, needMinimalSize);
            }
        }

         [TestMethod]
        public void TestGameStart()
        {
            game.Start();
            //После старта должен быть задан первый игрок и первый номер вопроса
            if (game.Player != 1)
            {
                Assert.Fail("Должен быть выбран первый игрок");
            }

            if (game.Question != 1)
            {
                Assert.Fail("Должен быть задан первый номер вопроса");
            }
        }

         [TestMethod]
         public void TestGameSelectQuestion()
         {
             game.LoadQuestions();
             game.Start();
             game.SelectQuestions();

             int realCount = (game.SelectedQuestions != null ? game.SelectedQuestions.Count : 0);
             int needCount = 10;

             Assert.AreEqual(needCount, realCount, "Количество отобранных вопросов некорректно");
         }

         [TestMethod]
         public void TestGameHashNextQuestion()
         {
             game.LoadQuestions();
             game.Start();
             game.SelectQuestions();

             for (int i = 0; i < Game.MAX_COUNT; i++)
             {
                 if (!game.HasNextQuestion())
                 {
                     Assert.Fail("Некорректное количество вопросов {0}", i);
                 }
                 game.Question++;
             }

         }

         [TestMethod]
         public void TestGameNextQuestion()
         {
             game.LoadQuestions();
             game.Start();
             game.SelectQuestions();

            while (game.HasNextQuestion()) {
                KeyValuePair<int, String> quest = game.NextQuestion();
                if (quest.Key == -1 && quest.Value == null)
                {
                    Assert.Fail("Метод вернул некорректный вопрос");
                }
            }
         }
        [TestMethod]
        public void TestGameCheckQuestion()
        {
            game.LoadQuestions();
            game.Start();
            game.SelectQuestions();

            while (game.HasNextQuestion())
            {
                KeyValuePair<int, String> quest = game.NextQuestion();
                game.CheckAnswer(quest.Key);
            }

            int needAnswers = 5;
            if (game.Player1 != needAnswers || game.Player2 != needAnswers)
            {
                Assert.Fail("Количество правильных ответов определено не правильно");
            }
        } 
    }
}
