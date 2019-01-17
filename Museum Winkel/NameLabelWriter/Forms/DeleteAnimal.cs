using NameLabelWriter.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NameLabelWriter
{
    public partial class DeleteAnimal : Form
    {
        NameLabelWriter wrt = null;
        List<Animal> foundAnimals = null;
        List<Animal> allAnimals = null;
        public DeleteAnimal(NameLabelWriter wrt)
        {
            this.wrt = wrt;
            foundAnimals = new List<Animal>();
            allAnimals = new List<Animal>();
            InitializeComponent();
            lbAllAnimals.Items.Clear();
            foreach (Animal animal in wrt.animalRepo.getAllAnimals())
            {
                allAnimals.Add(animal);
                lbAllAnimals.Items.Add(animal);
            }      
        }

        private void btnFindAnimal_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();
            try
            {
                foreach (Animal animal in wrt.animalRepo.getAnimalsByName(txtFindAnimal.Text))
                {
                    foundAnimals.Add(animal);
                    lbResults.Items.Add(animal);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vul een naam van een dier in");
            }
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            var selectedAnimal = lbResults.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                wrt.animalRepo.deleteAnimal(selectedAnimal.id);
                foundAnimals.RemoveAll(x => x.id == selectedAnimal.id);
                lbResults.Items.Clear();
                PopulateLists();
            }
            else
            {
                MessageBox.Show("Selecteer een dier in de resultaten van je zoekopdracht");
            }
        }

        private void btnDeleteSelectedAnimal_Click(object sender, EventArgs e)
        {
            var selectedAnimal = lbAllAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                wrt.animalRepo.deleteAnimal(selectedAnimal.id);
                if (foundAnimals.Count > 0)
                {
                    try
                    {
                        foundAnimals.RemoveAll(x => x.id == selectedAnimal.id);
                        lbResults.Items.Clear();
                        foreach (Animal animal in foundAnimals)
                        {
                            lbResults.Items.Add(animal);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                allAnimals.RemoveAll(x => x.id == selectedAnimal.id);
                lbResults.Items.Clear();
                PopulateLists();
            }
            else
            {
                MessageBox.Show("Selecteer een dier in de resultaten van je zoekopdracht");
            }
        }

        private void PopulateLists()
        {
            foreach (Animal animal in foundAnimals)
            {
                lbResults.Items.Add(animal);
            }
            lbAllAnimals.Items.Clear();
            foreach (Animal animal in wrt.animalRepo.getAllAnimals())
            {
                allAnimals.Add(animal);
                lbAllAnimals.Items.Add(animal);
            }
        }

        private void txtFindAnimal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFindAnimal_Click(this, new EventArgs());
            }
        }
    }
}
