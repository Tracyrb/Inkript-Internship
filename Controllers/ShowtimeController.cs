using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Http.Cors;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ShowtimeController : ApiController
    {
        ShowtimeEntities dt = new ShowtimeEntities();
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            ShowtimeEntities E = new ShowtimeEntities();

            List<Showtime> S = E.Showtimes.ToList<Showtime>();
            var jsonE = JsonConvert.SerializeObject(S);
            Console.WriteLine(jsonE);
            return jsonE;
        }

        // POST api/<controller>
        public string Post([FromBody] Showtime value)
        {
            dt.Showtimes.Add(value);
            dt.SaveChanges();
            return "success";
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}