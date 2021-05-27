using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlingPlangPlong
{
    public class FactorPlingPlangPlong
    {
        public string Raindrops(int n)
        {
            //Check if value not null
            /*Check: 
             * if n is 0, output 'PlingPlangPlong'
             * if n has a factor of 3, output 'Pling'
             * if n has a factor of 5, output 'Plang'
             * if n has a factor of 7, output 'Plong'
             * if n does not have any of the above as a factor simply return numbers digits
             */
            
            string result = string.Empty; //Stores value for PlingPlangPlong
            bool isNotFactor = true;
            if (n % 3 == 0)
            {
                result += "Pling";
                isNotFactor = false;
            }
            if (n % 5 == 0)
            {
                result += "Plang";
                isNotFactor = false;
            }
            if (n % 7 == 0)
            {
                result += "Plong";
                isNotFactor = false;
            }
            if (isNotFactor)
            {
                result = n.ToString();
            }
            
            return result;
        }
    }
}
