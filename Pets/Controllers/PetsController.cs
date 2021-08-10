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

                var dog = new Pet(++_idCount, "Fido", "Dog", "Male", 24, "Labrador");
                var cat = new Pet(++_idCount, "Skraggles", "Cat", "Female", 11, "Calico");

                _pets = new List<IPet> { dog, cat };
            }
        }

        /// <summary>
        /// Get all pets.
        /// GET: api/Pets
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<IPet>> GetPets()
        {
            return _pets;
        }

        /// <summary>
        /// Get the pet with the given id.
        /// GET: api/Pets/5
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<IPet> GetPet(int id)
        {
            IPet found = null;

            foreach (var pet in _pets)
            {
                if (pet.Id == id)
                {
                    found = pet;
                }
            }

            if (found is null)
            {
                return NotFound();
            }

            return new ActionResult<IPet>(found);
        }

        /// <summary>
        /// Creates a new pet.
        /// POST: api/Pets
        /// </summary>
        [HttpPost]
        public ActionResult<IPet> PostPet(Pet pet)
        {
            var newPet = new Pet(++_idCount, pet.Name, pet.Species, pet.Sex, pet.Age, pet.Breed);

            _pets.Add(newPet);

            return CreatedAtAction(nameof(GetPet), new { id = newPet.Id }, newPet);
        }
    }
}
