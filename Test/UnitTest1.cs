using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab;

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
    }
}
