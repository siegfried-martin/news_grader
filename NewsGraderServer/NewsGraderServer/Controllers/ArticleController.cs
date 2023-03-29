using System.Net.Mime;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsGraderServer.DTO;
using NewsGraderServer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewsGraderServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    public class ArticleController : BaseController
    {
        public ArticleController(IMapper mapper, ILogger<ArticleController> logger) : 
            base(mapper, logger)
        {
        }
        
        // GET: api/<ArticleController>
        [HttpGet]
        [ProducesResponseType(typeof(ArticleDto), StatusCodes.Status200OK)]
        public Task<OkObjectResult> Get()
        {
            var article = new ArticleEntity
            {
                Id = Guid.NewGuid(),
                ArticleSource = new Uri("https://www.npr.org/2023/03/28/1166654383/mammoth-meatball-extinct-cultivated-meat"),
                DataSource = "NPR",
                Contents = "AMSTERDAM — Throw another mammoth on the barbie?"
            };
            var dxs = Mapper.Map<ArticleDto>(article);
            return Task.FromResult(Ok(dxs));
        }

        // GET api/<ArticleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArticleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArticleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArticleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
