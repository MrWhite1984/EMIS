using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Managment_IS.Classes.Other
{
    class ConnectionStringHandler
    {
        public static string HandleStringForWrite(string connStr)
        {
            if (connStr != "")
            {
                var chunks = connStr.Split(new[] { @"\" }, StringSplitOptions.RemoveEmptyEntries);
                connStr = chunks[0] + @"\" + chunks[1];
                return connStr;
            }
            else
                return "";
        }

        public static string HandleStringForGet(string connStr)
        {
            if (connStr != "")
            {
                var chunks = connStr.Split(new[] { @"\" }, StringSplitOptions.RemoveEmptyEntries);
                connStr = chunks[0] + @"\" + chunks[1];
                return connStr;
            }
            else
                return "";
        }
    }
}
