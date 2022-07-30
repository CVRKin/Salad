using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;

namespace salad
{
    public class Logger
    {
        internal static MelonLogger.Instance _Log = new MelonLogger.Instance(typeof(Logger).Namespace, ConsoleColor.Magenta);

        public static void Log(object obj)
        {
            _Log.Msg(obj);
        }

        public static void LogError(object obj)
        {
            _Log.Error(obj);
        }
    }
}
