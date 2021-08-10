using Pets.Interfaces;

namespace Pets.Models
{
    public class Pet : IPet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public Pet()
        {
            Id = 0;
            Name = string.Empty;
            Species = string.Empty;
            Sex = string.Empty;
            Age = 0;
            Breed = string.Empty;
        }

        public Pet(int id, string name, string species, string sex, int age, string breed)
        {
            Id = id;
            Name = string.IsNullOrWhiteSpace(name) ? string.Empty : name;
            Species = string.IsNullOrWhiteSpace(species) ? string.Empty : species;
            Sex = string.IsNullOrWhiteSpace(sex) ? string.Empty : sex;
            Age = age;
            Breed = string.IsNullOrWhiteSpace(breed) ? string.Empty : breed;
        }
    }
}
