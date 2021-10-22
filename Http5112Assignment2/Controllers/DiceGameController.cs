using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Http5112Assignment2.Controllers
{
    public class DiceGameController : ApiController
    {
        [Route("api/J2/DiceGame/{num1}/{num2}")]
        public class J2Controller : ApiController
        {
            /// <summary>
            /// Collects two integers as the max number of sides on two "dice", then compares each value from die 1 with each value from die 2 to see how many 10-pairs there are between the dice 
            /// and returns a string with the results. 
            /// </summary>
            /// <param name="num1">4</param>
            /// <param name="num2">8</param>
            /// <returns>"There are 3 total ways to make 10."</returns>
            [HttpGet]
            public string DiceGame(int num1, int num2)
            {
                //Store 10-pairs in a new variable
                int tenPairs = 0;

                // Need variables to define the dice - arrays starting at 1?
                int[] die1 = Enumerable.Range(1, num1).ToArray(); 

                int[] die2 = Enumerable.Range(1, num2).ToArray();

                //Compare each item from die1 to each value from die2 to see if they
                //add up to 10.
                for (int i = 0; i < die1.Length; i++)
                {
                    for (int j = 0; j < die2.Length; j++)
                    {
                        if (die1[i] + die2[j] == 10)
                        {
                            tenPairs++;
                        }
                    }
                }

                //return a string with the message: "There are X total ways to get the sum 10."
                string resultMsgOne = "There is " + tenPairs + " way to make 10.";
                string resultMsg = "There are " + tenPairs + " total ways to make 10.";

                if (tenPairs == 1)
                {
                    return resultMsgOne;
                }
                else 
                {
                    return resultMsg;
                }
            } 
        }

    }
}
