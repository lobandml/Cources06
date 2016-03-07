using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources06
{
    enum Post
    {
        Junior=200,
        Middle=220,
        Senior=210
    }

   static class Accauntant
    {
        
            static public bool AskForBonus(Post post, int hours)
            {
                bool result = (hours > (int)post) ? true : false;
                return result;
            }
        
    }
}
