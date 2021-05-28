using System;

namespace PlingPlangPlongFactor
{
    public class Raindrops
    {
        public string PPPFactor(int n)
        {
            string result = null;
            if (n % 3 == 0)
            {
                result += "Pling";
            }
            if (n % 5 == 0)
            {
                result += "Plang";
            }
            if (n % 7 == 0)
            {
                result += "Plong";
            }

            return result != null ? result : n.ToString();
        }
    }
}
