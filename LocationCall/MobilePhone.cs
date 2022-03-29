using System;
using System.Collections.Generic;
using System.Text;

namespace LocationCall
{
    class MobilePhone:ICaller
    {
        public int Call(int time)
        {
            return time * 10;
        }
    }
}
