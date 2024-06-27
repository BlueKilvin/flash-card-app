using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Data.Models
{
    public abstract class Delay
    {
        
    }

    public enum BaseDelays
    {
        VeryEasy = -2,
        Easy = -1,
        Normal = 0,
        Hard = 1,
    }
}
