using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Http5112Assignment2.Controllers
{
    public class CalorieCountController : ApiController
    {
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public class J1Controller : ApiController
        {
            /// <summary>
            ///     Controller will accept four values, each from 1-4, add the calorie values assosciated with each input and return the sum. 
            /// </summary>
            /// <param name="burger">1</param>
            /// <param name="drink">4</param>
            /// <param name="side">3</param>
            /// <param name="dessert">2</param>
            /// <returns>"Your total calorie count is 797</returns>
            [HttpGet]
            public string Menu(int burger, int drink, int side, int dessert)
            {
                //function for burger input conversion
                if (burger == 1)
                {
                    burger = 461;
                }
                else if (burger == 2)
                {
                    burger = 431;
                }
                else if (burger == 3)
                {
                    burger = 420;
                }
                else if (burger == 4)
                {
                    burger = 0;
                }
                //function for drink input conversion
                if (drink == 1)
                {
                    drink = 130;
                }
                else if (drink == 2)
                {
                    drink = 160;
                }
                else if (drink == 3)
                {
                    drink = 118;
                }
                else if (drink == 4)
                {
                    drink = 0;
                }
                //function for side input conversion
                if (side == 1)
                {
                    side = 100;
                }
                else if (side == 2)
                {
                    side = 57;
                }
                else if (side == 3)
                {
                    side = 70;
                }
                else if (side == 4)
                {
                    side = 0;
                }
                //function for dessert input conversion
                if (dessert == 1)
                {
                    dessert = 167;
                }
                else if (dessert == 2)
                {
                    dessert = 266;
                }
                else if (dessert == 3)
                {
                    dessert = 75;
                }
                else if (dessert == 4 || dessert == 0)
                {
                    dessert = 0;
                }

                // variables to store calorie total and output results
                int CalorieTotal = burger + drink + side + dessert;

                string TotalMsg = "Your total calorie count is " + CalorieTotal + ".";

                return TotalMsg;
            }
        }
    }
}
