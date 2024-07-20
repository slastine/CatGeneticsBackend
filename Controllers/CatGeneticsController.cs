using Microsoft.AspNetCore.Mvc;
using CatGenetics;
namespace CatGeneticsBackend.Controllers
{
    public class Response
    {
        public Genotype genotype { get; set; }
        public string phenotype { get; set; }

        public Response(Genotype g)
        {
            this.genotype = g;
            this.phenotype = CatGenerator.PhenotypeFromGenotype(g, "Kitten");
        }
    }
    [ApiController]
    public class CatGeneticsController : ControllerBase
    {
        [HttpPost]
        [Route("/postCats")]
        public IActionResult PostCats([FromForm]IFormCollection form)
        {
            if (form.Count == 0) return BadRequest();
            CatGeneticsProgram.Init();
            Genotype g = CatGeneticsProgram.KittenFromStrings(form["father-1"], form["father-2"], form["mother-1"], form["mother-2"]);
            Response r = new Response(g);
            return Ok(r);
        }

        [HttpGet]
        [HttpHead]
        [Route("/healthCheck")] 
        public IActionResult HealthCheck()
        {
            return Ok("Success");
        }

    }
}
