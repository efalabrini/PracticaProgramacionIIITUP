using Microsoft.AspNetCore.Mvc;
using ExploreOOP.BusinessLayer.Entities;
using ExploreOOP.BusinessLayer.Services;

namespace ExploreOOPWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineOfCreditAccountController : ControllerBase
    {
        private readonly ILineOfCreditAccountService _lineOfCreditAccountService;

        public LineOfCreditAccountController(ILineOfCreditAccountService lineOfCreditAccountService)
        {
            _lineOfCreditAccountService = lineOfCreditAccountService;
        }

        [HttpGet]
        public IEnumerable<LineOfCreditAccount> GetAll()
        {
            return _lineOfCreditAccountService.GetAll();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return (IActionResult)_lineOfCreditAccountService.Get(id);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _lineOfCreditAccountService.Delete(id);
            if (id == null) 
            {
            return NotFound();
            }
            _lineOfCreditAccountService.Delete(id);
            return NoContent();
        }
    }
}
