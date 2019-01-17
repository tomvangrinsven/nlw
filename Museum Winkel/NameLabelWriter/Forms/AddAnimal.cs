using NameLabelWriter.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NameLabelWriter
{
    public partial class AddAnimal : Form
    {
        NameLabelWriter wrt = null;
        List<Animal> animalsToAdd;
        public AddAnimal(NameLabelWriter wrt)
        {
            this.wrt = wrt;
            animalsToAdd = new List<Animal>();
            InitializeComponent();
        }

        private void btnAddAnimalToList_Click(object sender, EventArgs e)
        {
            try
            {
                animalsToAdd.Add(new Animal(
                    txtAnimalName.Text,
                    txtAnimalCountryOfOrigin.Text
                    ));
            }
            catch (FormatException)
            {
                MessageBox.Show("Vul alle velden in");
            }
            lbAnimalsToAdd.Items.Clear();
            foreach (Animal animal in animalsToAdd)
            {
                lbAnimalsToAdd.Items.Add(animal);
            }           
        }

        private void btnRemoveAnimalFromList_Click(object sender, EventArgs e)
        {
            var selectedAnimal = lbAnimalsToAdd.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                animalsToAdd.RemoveAll(x => x.name == selectedAnimal.name && x.countryOfOrigin == selectedAnimal.countryOfOrigin);
                lbAnimalsToAdd.Items.Clear();
                foreach (Animal animal in animalsToAdd)
                {
                    lbAnimalsToAdd.Items.Add(animal);
                }
            }
            else
            {
                MessageBox.Show("Selecteer een dier");
            }
        }

        private void btnAddAnimalsToDatabase_Click(object sender, EventArgs e)
        {
            if (animalsToAdd.Count > 0)
            {
                try
                {
                    wrt.animalRepo.insertAnimals(animalsToAdd);
                    animalsToAdd.Clear();
                    lbAnimalsToAdd.Items.Clear();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Voeg dieren toe aan de lijst");
            }
            
        }
    }
}
