namespace Pets.Interfaces
{
    public interface IPet
    {
        /// <summary>
        /// The pet's unique identifier.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// The name of the pet.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The name of the pet's species.
        /// </summary>
        string Species { get; }

        /// <summary>
        /// Male or Female.
        /// </summary>
        string Sex { get; }

        /// <summary>
        /// Age in months.
        /// </summary>
        int Age { get; }

        /// <summary>
        /// The name of the pet's breed.
        /// </summary>
        string Breed { get; }
    }
}
