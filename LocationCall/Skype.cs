using System;
using System.Collections.Generic;
using System.Text;

namespace LocationCall
{
    class Skype:ICaller
    {
        public int Call(int time)
        {
            return time * 5;
        }
    }
}
