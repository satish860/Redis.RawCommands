using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Redis.RawCommands.Test
{
    [TestClass]
    public class RedisConnectionTest
    {
        [TestMethod]
        public void Should_be_able_to_Connect_to_Redis_With_Default_Port()
        {
            IRedisClient client = new RedisClient();
            Assert.IsFalse(client.IsConnected());
        }

        [TestMethod]
        public void Should_Connect_to_the_Port_With_the_Socket_Connection()
        {

        }

        [TestMethod]
        public void Should_Throw_an_Exception_If_Not_Able_to_Connect()
        {

        }

      
    }
}
