using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01399603_Assignment2.Controllers
{
    public class J1CalorieCountingController : ApiController
    {
        /// <summary>
        /// Calculating calories by checking for passed parameter and adding calories to variable
        /// </summary>
        /// <returns>string of total colories of the chosen meal</returns>
        /// <example>
        /// GET api/J1CalorieCounting/4/4/4/4 -> "Your total calorie count is 0"
        /// </example>
        /// <example>
        /// GET api/J1CalorieCounting/1/2/3/4 -> "Your total calorie count is 691"
        /// </example>

        [HttpGet]
        [Route("api/J1CalorieCounting/{burger:int}/{drink:int}/{side:int}/{desert:int}")]
        public string Get(int burger, int drink, int side, int desert)
        {
            int calories = 0;
            string message = "";

            // Calculating for burgers
            if (burger == 1)
            {
                calories += 461;
            }
            if (burger == 2)
            {
                calories += 431;
            }
            if (burger == 3)
            {
                calories += 420;
            }


            // Calculating for drinks
            if (drink == 1)
            {
                calories += 130;
            }
            if (drink == 2)
            {
                calories += 160;
            }
            if (drink == 3)
            {
                calories += 118;
            }

            // Calculating for sides
            if (side == 1)
            {
                calories += 100;
            }
            if (side == 2)
            {
                calories += 57;
            }
            if (side == 3)
            {
                calories += 70;
            }

            // Calculating for desert
            if (desert == 1)
            {
                calories += 167;
            }
            if (desert == 2)
            {
                calories += 266;
            }
            if (desert == 3)
            {
                calories += 75;
            }

            // Returning string showing total calories
            message = "Your total colories of the meal is: " + calories;
            return message;
        }
    }
}
