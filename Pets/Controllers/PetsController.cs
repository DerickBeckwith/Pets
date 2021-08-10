using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pets.Interfaces;
using Pets.Models;

namespace Pets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private static int _idCount;

        private static List<IPet> _pets;

        public PetsController()
        {
            if (_pets is null)
            {
                _idCount = 0;

                var dog = new Pet(++_idCount, "Delilah", "Dog", "Female", 96, "Chocolate Lab");
                var cat = new Pet(++_idCount, "Skraggles", "Cat", "Male", 22, "Orange Tabby");

                _pets = new List<IPet> { dog, cat };
            }
        }

        /// <summary>
        /// Find all pets.
        /// GET: api/pets
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<IPet>> GetPets()
        {
            return _pets;
        }

        /// <summary>
        /// Get a pet by an id.
        /// GET: api/pets/5
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<IPet> GetPet(int id)
        {
            foreach (var pet in _pets)
            {
                if (pet.Id == id)
                {
                    return new ActionResult<IPet>(pet);
                }
            }

            return NotFound();
        }

        /// <summary>
        /// Create a pet.
        /// POST: api/pets
        /// </summary>
        [HttpPost]
        public ActionResult<IPet> PostPet(Pet pet)
        {
            var p = new Pet(++_idCount, pet.Name, pet.Species, pet.Sex, pet.Age, pet.Breed);

            _pets.Add(p);

            return CreatedAtAction(nameof(GetPet), new { id = p.Id }, p);
        }

        /// <summary>
        /// Update a pet by an Id.
        /// PUT: api/pets/5
        /// </summary>
        [HttpPut("{id}")]
        public IActionResult PutPet(long id, Pet pet)
        {
            if (id != pet.Id)
            {
                return BadRequest();
            }

            foreach (var p in _pets)
            {
                if (p.Id == id)
                {
                    // Update the pet in place.
                    p.Name = pet.Name;
                    p.Species = pet.Species;
                    p.Sex = pet.Sex;
                    p.Age = pet.Age;
                    p.Breed = pet.Breed;

                    return NoContent();
                }
            }

            return NotFound();
        }

        /// <summary>
        /// Delete a pet by an Id.
        /// DELETE: api/pets/5
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult DeletePet(long id)
        {
            foreach (var pet in _pets)
            {
                if (pet.Id == id)
                {
                    // Remove the pet from the list.
                    _pets.Remove(pet);

                    return NoContent();
                }
            }

            return NotFound();
        }
    }
}
