namespace Pets.Interfaces
{
    public interface IPet
    {
        /// <summary>
        /// The pet's unique identifier.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// The name of the pet.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The name of the pet's species.
        /// </summary>
        string Species { get; set; }

        /// <summary>
        /// Male or Female.
        /// </summary>
        string Sex { get; set; }

        /// <summary>
        /// Age in months.
        /// </summary>
        int Age { get; set; }

        /// <summary>
        /// The name of the pet's breed.
        /// </summary>
        string Breed { get; set; }
    }
}
