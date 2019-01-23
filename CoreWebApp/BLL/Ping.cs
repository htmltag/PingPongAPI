using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.BLL
{
    public class Ping
    {
        private readonly List<string> _pingPong;

        public Ping() 
        {
            _pingPong = new List<string>()
            {
                "Ping Pong Ping",
                "Ping Pong Ping Pong",
                "Pong Pong"
            };
        }

        public string AnswerPing()
        {
            return "Pong";
        }

        public string GetPingPong(int id)
        {
            if (id > -1 && id < _pingPong.Count)
            {
                return _pingPong[id];
            }
            else
            {
                return "No Ping Pong Found";
            }
        }
    }
}
