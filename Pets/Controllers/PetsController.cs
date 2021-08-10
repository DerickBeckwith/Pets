using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pets.Interfaces;
using Pets.Models;

namespace Pets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<IPet> Get()
        {
            var dog = new Pet(0, "Fido", "Dog", "Male", 24, "Labrador");
            var cat = new Pet(1, "Skraggles", "Cat", "Female", 11, "Calico");

            return new List<IPet> { dog, cat };
        }
    }
}
