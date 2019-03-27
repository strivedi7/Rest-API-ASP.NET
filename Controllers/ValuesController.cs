using PersonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PersonAPI.Controllers
{
    public class ValuesController : ApiController
    {
        List<Person> people = new List<Person>();
 

        
        
        public ValuesController()
        {
            people.Add(new Person { firstName = "saurabh", lastName = "Trivedi", id = 1 });
            people.Add(new Person { firstName = "Arzoo", lastName = "Patel", id = 2 });
        }

        [Route("api/values/firstNames")]
        [HttpGet]
        public List<string> GetFirstNames (){
            List<string> result = new List<string>();
            foreach (var p in people)
            {
                result.Add(p.firstName);
            }
            return result;
        }

        [Route("api/values/firstNames/{id}")]
        [HttpGet]
        public string GetFirstNames(int id)
        {
          
            return people.Where(x => x.id == id).FirstOrDefault().firstName;
        }
        // GET api/values
        public List<Person> Get()
        {
            return people;
        }

        // GET api/values/5
        public Person Get(int id)
        {
            return people.Where(x => x.id == id).FirstOrDefault();
        }

        // POST api/values
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            people.Remove(people.Where(x => x.id == id).FirstOrDefault());
        }
    }
}
