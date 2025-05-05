using DevFreela.API.Controllers.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly FreelanceTotalCostConfig _config;
        public ProjectsController(IOptions<FreelanceTotalCostConfig> options)
        {
            _config = options.Value;
        }

        [HttpGet]
        public IActionResult Get(string search)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(CreatProjetcInputModel model)
        {
            if (model.TotalCost < _config.Minimum || model.TotalCost > _config.Maximum)
            {
                return BadRequest("Numero fora dos limites.");
            }
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id,UpdateProjectInputModel model)
        {
            return NoContent(); 
        }

        [HttpPut("{id}/start")]
        public ActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/complete")]
        public ActionResult Complete(int id)
        {
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreateProjetCommentInputModel model)
        {
            return Ok();
        }
    }
}
