using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01399603_Assignment2.Controllers
{
    public class J2DiceController : ApiController
    {
        /// <summary>
        /// Calculating how many ways Diana can roll 2 dice to get value of 10.
        /// </summary>
        /// <returns>string of count</returns>
        /// <example>
        /// GET api/J2Dice/6/8 -> "There are 5 total ways to get the sum 10."
        /// </example>
        /// <example>
        /// GET api/J2Dice/12/4 -> "There are 4 total ways to get the sum 10."
        /// </example>

        [HttpGet]
        [Route("api/J2Dice/{m:int}/{n:int}")]

        public string Get(int m, int n)
        {
            int count = 0;
            string message = "";

            // Creating list to store different combinations
            List<MNClass> listOfCombination = new List<MNClass>();
            for (int i = m; i > 0; i--)
            {
                for (int j = n; j > 0; j--)
                {
                    MNClass mN = new MNClass();
                    mN.m = i;
                    mN.n = j;
                    listOfCombination.Add(mN);
                }

            }

            // Counting for possiblities where sum is 10 for given m and n
            foreach (var i in listOfCombination)
            {
                if (i.m + i.n == 10)
                {
                    count++;
                }
            }

            message = "There are " + count + " total ways to get the sum 10.";
            return message;
        }
    }
}
