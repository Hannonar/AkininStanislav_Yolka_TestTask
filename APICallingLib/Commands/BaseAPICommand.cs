using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICallingLib
{
    public abstract class BaseAPICommand
    {
        public static string BaseURL;

        public abstract string GetURL();
    }
}
