using DevFreela.API.Controllers.Model;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {

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
