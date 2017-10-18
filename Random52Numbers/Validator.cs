using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random52Numbers
{
    public class Validator
    {
        public int IntRangeValidator(int low, int high)
        {
            if (low < 1 || high < 1)
            {
                Console.WriteLine("invalid inputs");
                return 0;
            }
            if (low > high)
            {
                Console.WriteLine("low input cannot be higher than high input");
                return 0;
            }
            return 1;
        }
    }
}
