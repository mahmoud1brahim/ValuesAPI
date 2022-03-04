using Microsoft.AspNetCore.Mvc;

namespace ValuesAPI.Controllers;

[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Mahmoud Hefny", "Papa John's" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "Some value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }

    [HttpGet("Hind")]
    public string Hind()
    {
        Random rnd = new Random();
        var words = new List<string>
        {
            "Hind is awesome",
            "Hind will be the best surgent",
            "Good Luck with your studies",
            "YOU ARE THE BEST <3"
        };
        return words[rnd.Next(words.Count)];
    }
}