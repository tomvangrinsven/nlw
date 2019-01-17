using NameLabelWriter.Domain;
using System;
using System.Collections.Generic;

namespace NameLabelWriter.Database.Interfaces
{
    public interface IAnimalContext
    {
        List<Animal> getAnimalsByName(string Name);
        List<Animal> getAllAnimals();
        Boolean insertAnimals(List<Animal> animals);
        Boolean updateAnimal(Animal animal);
        Boolean deleteAnimal(int id);
    }
}
