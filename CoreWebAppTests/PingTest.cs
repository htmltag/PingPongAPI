using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreWebApp.BLL;

namespace CoreWebAppTests
{
    [TestClass]
    public class PingTest
    {
        [TestMethod]
        public void AnswerPingTest()
        {
            Ping ping = new Ping();
            string answer = ping.AnswerPing();

            Assert.AreEqual("Pong", answer);
        }

        [TestMethod]
        public void GetCorrectPingPongTest()
        {
            int id = 1;
            Ping ping = new Ping();

            string answer = ping.GetPingPong(id);

            Assert.AreEqual("Ping Pong Ping Pong", answer);
        }

        [TestMethod]
        public void GetInvalidPingPongTest()
        {
            int id = 5;
            Ping ping = new Ping();

            string answer = ping.GetPingPong(id);

            Assert.AreEqual("No Ping Pong Found", answer);
        }
    }
}
