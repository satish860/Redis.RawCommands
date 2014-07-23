using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis.RawCommands
{
    public interface IRedisClient
    {
        bool IsConnected();
    }
}
