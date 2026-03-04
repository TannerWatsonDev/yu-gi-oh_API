using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yu_Gi_Oh_API.Data;
using Microsoft.EntityFrameworkCore;
using Yu_Gi_Oh_API.Models;

namespace Yu_Gi_Oh_API.Controllers
{
    // Set base URL for CardsController to "api/cards" and specify that it's an API controller
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Constructor that takes an AppDbContext and assigns it to a private field for use in the controller
        public CardsController(AppDbContext context)
        {
            _context = context;
        }

        // endpoint to get all cards from the database, responds to GET requests at "api/cards"
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Card>>> GetCards()
        {
            try
            {
                var cards = await _context.Cards.ToListAsync();
                return Ok(cards);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // endpoint to get a specific card by its ID, responds to GET requests at "api/cards/{id}"
        [HttpGet("{id}")]
        public async Task<ActionResult<Card>> GetCardById(int id)
        {
            try
            {
                var card = await _context.Cards.FindAsync(id);
                if (card == null)
                {
                    return NotFound();
                }
                return Ok(card);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
