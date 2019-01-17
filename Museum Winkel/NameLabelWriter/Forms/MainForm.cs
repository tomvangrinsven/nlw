using System;
using System.Windows.Forms;

namespace NameLabelWriter
{
    public partial class MainForm : Form
    {
        private NameLabelWriter wrt;
        public MainForm()
        {
            wrt = new NameLabelWriter();
            InitializeComponent();
        }

        public void UpdateEmbeddedForm(Form form)
        {
            pnlWindow.Controls.Clear();

            form.Dock = DockStyle.Fill;
            form.AutoSize = true;
            form.FormBorderStyle = FormBorderStyle.None;

            form.TopLevel = false;
            pnlWindow.Controls.Add(form);
            form.Show();

            form.Closed += new EventHandler(CloseForm);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFindAnimal_Click(object sender, EventArgs e)
        {
            UpdateEmbeddedForm(new FindAnimal(this.wrt));
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            UpdateEmbeddedForm(new AddAnimal(this.wrt));
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            UpdateEmbeddedForm(new UpdateAnimal(this.wrt));
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            UpdateEmbeddedForm(new DeleteAnimal(this.wrt));
        }
    }
}
