using System;
using System.Threading.Tasks;

namespace MyFramework.Logger
{
    public class Log
    {
        public async Task Error(Exception ex)
        {
            // do something nice
        }

        public async Task Info(string message)
        {
            // do something nice
        }
    }
}
