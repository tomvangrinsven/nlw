using System;

namespace NameLabelWriter.Domain
{
    public class Animal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string countryOfOrigin { get; set; }

        public Animal()
        {

        }

        public Animal(int id, string name, string countryOfOrigin)
        {
            this.id = id;
            this.name = name;
            this.countryOfOrigin = countryOfOrigin;
        }

        public Animal(string name, string countryOfOrigin)
        {
            this.name = name;
            this.countryOfOrigin = countryOfOrigin;
        }

        public override string ToString()
        {
            return String.Format("Naam: {0}, Herkomst: {1}", this.name, this.countryOfOrigin);
        }
    }
}
