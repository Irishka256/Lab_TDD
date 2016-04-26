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

            if (realSize <= needMinimalSize)
            {
                Assert.Fail("Вопросы не загружены. Загружено: {0}. Требуется: >= {1}", realSize, needMinimalSize);
            }
        }
    }
}
