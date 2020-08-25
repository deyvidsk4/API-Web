using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPIServ.Models;
using WebAPIServ.Repositorio;

namespace WebAPIServ.Controllers
{
    [Route("api/[Controller]")]
    public class PollsController : Controller
    {

        private readonly IPollRepositorio _pollRepositorio;

        public PollsController(IPollRepositorio pollRepositorio)
        {
            _pollRepositorio = pollRepositorio;
        }

        [HttpGet]
        public IEnumerable<Poll> GetAll()
        {
            return _pollRepositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetPoll")]
        public IActionResult GetById(long id)
        {
            var poll = _pollRepositorio.Find(id);
            if (poll == null)
                return NotFound();

            return new ObjectResult(poll);

        }

        [HttpPost]

        public IActionResult Create([FromBody] Poll poll)

        {
            if (poll == null)
                return BadRequest();
            _pollRepositorio.Add(poll);

            return CreatedAtRoute("GetPoll", new { Id = poll.Poll_id }, poll);

        }
        [HttpPut("{id}")]

        public IActionResult Update(long id, [FromBody] Poll poll)
        {
            if (poll == null || poll.Poll_id != id)

                return BadRequest();
            var _poll = _pollRepositorio.Find(id);

            if (poll == null)

                return NotFound();
            _poll.Poll_description = poll.Poll_description;
            _poll.Votes_qty = poll.Votes_qty + 1 ;

            _pollRepositorio.Update(_poll);
            return new NoContentResult();
        }


        [HttpDelete("{id}")]

        public IActionResult Delete(long id)
        {
            var poll = _pollRepositorio.Find(id);

            if (poll == null)
                return NotFound();

            _pollRepositorio.Remove(id);
            return new NoContentResult();
        }






    }

}