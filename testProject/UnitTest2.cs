using ComputerClub;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void AuthTest()
        {
            var page = new Enter();
            string hashedPassword = Enter.GetHash("111111B"); // Получаем хеш пароля
            Assert.IsTrue(page.Auth("Boss", hashedPassword)); // Передаем хешированный пароль
            Assert.IsFalse(page.Auth("GG", hashedPassword));
        }
    }
}