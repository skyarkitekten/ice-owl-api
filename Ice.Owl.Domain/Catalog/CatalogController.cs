using Microsoft.AspNetCore.Mvc;
using Ice.Owl.Domain.Catalog;
using Ice.Owl.Data;

namespace Ice.Owl.Api.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase {

        private readonly StoreContext _db;

        public CatalogController(StoreContect db)
        {
            _db = db;
        }


        [HttpGet]
        public IActionResult GetItems() {
            

           return Ok(_db.Items);
        }

        [HttpGet("{id:int}")]
        public IActionResult Getitem(int id){
            var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
            item.ID = id;

            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(Item item){
            return Created("/catalog/42", item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating){

            var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
            item.ID = id;
            item.AddRating(rating);

            return Ok(item);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Item item){
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id){
            return NoContent();
        }

    }
    
}