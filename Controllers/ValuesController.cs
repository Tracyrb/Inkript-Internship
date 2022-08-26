using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        tracyscinemaEntities dt = new tracyscinemaEntities();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            tracyscinemaEntities E = new tracyscinemaEntities();

            List<Movie> m = E.Movies.ToList<Movie>();
            var jsonE = JsonConvert.SerializeObject(m);
            Console.WriteLine(jsonE);
            return jsonE;
        }

        // POST api/values
        public string Post([FromBody] Movie value)
        {
            dt.Movies.Add(value);
            dt.SaveChanges();
            return "success";

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        public string Delete(Movie id)
        {
            dt.Movies.Remove(id);
            return "success";

        }
    }
}
