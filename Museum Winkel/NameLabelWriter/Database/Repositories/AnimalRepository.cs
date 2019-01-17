using NameLabelWriter.Database.Interfaces;
using System.Collections.Generic;
using NameLabelWriter.Domain;

namespace NameLabelWriter.Database.Repositories
{
    public class AnimalRepository
    {
        private IAnimalContext _context;

        public AnimalRepository(IAnimalContext context)
        {
            this._context = context;
        }

        public bool deleteAnimal(int id)
        {
            return _context.deleteAnimal(id);
        }

        public List<Animal> getAllAnimals()
        {
            return _context.getAllAnimals();
        }

        public List<Animal> getAnimalsByName(string Name)
        {
            return _context.getAnimalsByName(Name);
        }

        public bool insertAnimals(List<Animal> animals)
        {
            return _context.insertAnimals(animals);
        }

        public bool updateAnimal(Animal animal)
        {
            return _context.updateAnimal(animal);
        }
    }
}
