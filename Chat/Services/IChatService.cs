using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Services
{
    public interface IChatService
    {
        bool SaveMessage(string user, string message);
    }
}
