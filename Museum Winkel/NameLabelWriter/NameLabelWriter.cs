using NameLabelWriter.Database.MSSQLContext;
using NameLabelWriter.Database.Repositories;
using NameLabelWriter.Domain;
using System.Collections.Generic;

namespace NameLabelWriter
{
    public class NameLabelWriter
    {
        public AnimalRepository animalRepo = new AnimalRepository(new AnimalMSSQLContext());
        public List<Animal> animalsToPrint = new List<Animal>();

        public NameLabelWriter()
        {

        }
    }
}
