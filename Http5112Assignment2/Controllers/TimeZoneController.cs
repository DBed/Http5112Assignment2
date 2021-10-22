using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Http5112Assignment2.Controllers
{
    public class TimeZoneController : ApiController
    {
        [Route("api/J3/TimeZone/{OttawaTime}")]
        public class J3Controller : ApiController
        {
            /// <summary>
            /// Accepts an input from 1-2359 as the time in Ottawa, returns relative time in 6 other provinces. 
            /// </summary>
            /// <param name="ottawaTime"></param>
            /// <returns></returns>
            [HttpGet]
            public string TimeZone(int ottawaTime)
            {
                //Need variables for each timezone 
                int ottawa = ottawaTime;

                //receive ottawaTime

                int victoria = ottawa - 180;//- 3 hours
                int edmonton = ottawa - 120;//- 2 hours
                int winnipeg = ottawa - 60; //- 1 hour;
                int toronto = ottawa + 0;
                int halifax = ottawa + 60;  //+ 1 hour;
                int stJohns = ottawa + 90; //+ 1.5 hours;

                //Somehow need to set a roll-over on the numbers.  2359 + 60 needs to equal 59 instead of 2419
                // If you could limit the digit in the 10s column to 6, that would help. 
                // first two digits have to be less than 24
                // last two digits have to be less than 60

                //variables for timezone messages & line breaks
                string timeZones = ottawa + " in Ottawa" + 
                                   Environment.NewLine + 
                                   victoria + " in Victoria" +
                                   Environment.NewLine +
                                   edmonton + " in Edmonton" + 
                                   Environment.NewLine +
                                   winnipeg + " in Winnipeg" + 
                                   Environment.NewLine +
                                   toronto + " in Toronto" +
                                   Environment.NewLine + 
                                   halifax + " in Halifax" +
                                   Environment.NewLine +
                                   stJohns + " in St. Johns";

                return timeZones;
            }
        }
    }
}
