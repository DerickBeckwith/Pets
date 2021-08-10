using Pets.Interfaces;

namespace Pets.Models
{
    public class Pet : IPet
    {
        private readonly int _id;

        private readonly string _name;

        private readonly string _species;

        private readonly string _sex;

        private readonly int _age;

        private readonly string _breed;

        public int Id => _id;

        public string Name => _name;

        public string Species => _species;

        public string Sex => _sex;

        public int Age => _age;

        public string Breed => _breed;

        public Pet()
        {
            _id = 0;
            _name = string.Empty;
            _species = string.Empty;
            _sex = string.Empty;
            _age = 0;
            _breed = string.Empty;
        }

        public Pet(int id, string name, string species, string sex, int age, string breed)
        {
            _id = id;
            _name = string.IsNullOrWhiteSpace(name) ? string.Empty : name;
            _species = string.IsNullOrWhiteSpace(species) ? string.Empty : species;
            _sex = string.IsNullOrWhiteSpace(sex) ? string.Empty : sex;
            _age = age;
            _breed = string.IsNullOrWhiteSpace(breed) ? string.Empty : breed;
        }
    }
}
