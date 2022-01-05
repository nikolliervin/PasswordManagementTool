using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Management_Tool
{
    internal class GenerateSecurityPin
    {
        public int PinGenerator()
        {
            var min = 00000;
            var max = 99999;

            var random=new Random();
            return random.Next(min, max);   
        }
    }
}
