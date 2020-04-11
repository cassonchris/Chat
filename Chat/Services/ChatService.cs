using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Services
{
    public class ChatService : IChatService
    {
        public bool SaveMessage(string user, string message)
        {
            Console.WriteLine(message);
            return true;
        }
    }
}
