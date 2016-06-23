using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace AeraHack2.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            var cp = ClaimsPrincipal.Current;
            List<string> claims = new List<string>();
            foreach (var c in cp.Claims)
            {
                claims.Add(string.Format("{0} - {1}", c.Subject, c.Value));
            }
            //return new string[] { "value1", "value2", "value3" };
            return claims.ToArray<string>();
        }

        // GET api/values/5
        public string Get(int id)
        {
            string result = string.Empty;
            switch (id)
            {
                case 1:
                    result = "Nice going!";
                    break;
                case 2:
                    result = "Hey now";
                    break;
                case 3:
                    result = "You lose";
                    break;
                case 4:
                    result = "Way to go, Roscoe";
                    break;
                default:
                    result = "Winner, winner chicken dinner";
                    break;
            }
            return result;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
