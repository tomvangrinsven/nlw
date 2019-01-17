using NameLabelWriter.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NameLabelWriter
{
    public partial class UpdateAnimal : Form
    {
        NameLabelWriter wrt = null;
        List<Animal> foundAnimals = null;
        List<Animal> allAnimals = null;

        public UpdateAnimal(NameLabelWriter wrt)
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

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAnimal = lbResults.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                txtNewNameOfResultAnimal.Text = selectedAnimal.name;
                txtNewOriginOfResultAnimal.Text = selectedAnimal.countryOfOrigin;
            }
            else
            {
                MessageBox.Show("Selecteer een dier uit de resultaten");
            }
        }

        private void btnSaveSearchedAnimal_Click(object sender, EventArgs e)
        {
            var selectedAnimal = lbResults.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                selectedAnimal.name = txtNewNameOfResultAnimal.Text;
                selectedAnimal.countryOfOrigin = txtNewOriginOfResultAnimal.Text;
                wrt.animalRepo.updateAnimal(selectedAnimal);
                lbResults.Items.Clear();
                lbAllAnimals.Items.Clear();
                foreach (Animal animal in wrt.animalRepo.getAllAnimals())
                {
                    lbAllAnimals.Items.Add(animal);
                }
                txtNewNameOfResultAnimal.Text = "";
                txtNewOriginOfResultAnimal.Text = "";
            }
            else
            {
                MessageBox.Show("Selecteer een dier uit de resultaten");
            }
        }

        private void btnSaveSelectedAnimal_Click(object sender, EventArgs e)
        {
            var selectedAnimal = lbAllAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                selectedAnimal.name = txtNewNameOfSelectedAnimal.Text;
                selectedAnimal.countryOfOrigin = txtNewOriginOfSelectedAnimal.Text;
                wrt.animalRepo.updateAnimal(selectedAnimal);
                lbResults.Items.Clear();
                lbAllAnimals.Items.Clear();
                foreach (Animal animal in wrt.animalRepo.getAllAnimals())
                {
                    lbAllAnimals.Items.Add(animal);
                }
                txtNewNameOfSelectedAnimal.Text = "";
                txtNewOriginOfSelectedAnimal.Text = "";
            }
            else
            {
                MessageBox.Show("Selecteer een dier uit de resultaten");
            }
        }

        private void lbAllAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAnimal = lbAllAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                txtNewNameOfSelectedAnimal.Text = selectedAnimal.name;
                txtNewOriginOfSelectedAnimal.Text = selectedAnimal.countryOfOrigin;
            }
            else
            {
                MessageBox.Show("Selecteer een dier uit de lijst");
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
