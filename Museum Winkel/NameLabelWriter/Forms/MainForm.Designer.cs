namespace NameLabelWriter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnFindAnimal = new System.Windows.Forms.Button();
            this.pnlWindow = new System.Windows.Forms.Panel();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnUpdateAnimal = new System.Windows.Forms.Button();
            this.btnDeleteAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindAnimal
            // 
            this.btnFindAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAnimal.Location = new System.Drawing.Point(13, 13);
            this.btnFindAnimal.Name = "btnFindAnimal";
            this.btnFindAnimal.Size = new System.Drawing.Size(120, 73);
            this.btnFindAnimal.TabIndex = 0;
            this.btnFindAnimal.Text = "Zoek dier";
            this.btnFindAnimal.UseVisualStyleBackColor = true;
            this.btnFindAnimal.Click += new System.EventHandler(this.btnFindAnimal_Click);
            // 
            // pnlWindow
            // 
            this.pnlWindow.Location = new System.Drawing.Point(140, 13);
            this.pnlWindow.Name = "pnlWindow";
            this.pnlWindow.Size = new System.Drawing.Size(939, 735);
            this.pnlWindow.TabIndex = 4;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(13, 92);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(120, 73);
            this.btnAddAnimal.TabIndex = 1;
            this.btnAddAnimal.Text = "Voeg dier toe";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnUpdateAnimal
            // 
            this.btnUpdateAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAnimal.Location = new System.Drawing.Point(13, 171);
            this.btnUpdateAnimal.Name = "btnUpdateAnimal";
            this.btnUpdateAnimal.Size = new System.Drawing.Size(120, 73);
            this.btnUpdateAnimal.TabIndex = 2;
            this.btnUpdateAnimal.Text = "Wijzig dier";
            this.btnUpdateAnimal.UseVisualStyleBackColor = true;
            this.btnUpdateAnimal.Click += new System.EventHandler(this.btnUpdateAnimal_Click);
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAnimal.Location = new System.Drawing.Point(13, 250);
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(120, 73);
            this.btnDeleteAnimal.TabIndex = 3;
            this.btnDeleteAnimal.Text = "Verwijder dier";
            this.btnDeleteAnimal.UseVisualStyleBackColor = true;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.btnDeleteAnimal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 760);
            this.Controls.Add(this.btnDeleteAnimal);
            this.Controls.Add(this.btnUpdateAnimal);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.pnlWindow);
            this.Controls.Add(this.btnFindAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Name Label Writer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindAnimal;
        private System.Windows.Forms.Panel pnlWindow;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnUpdateAnimal;
        private System.Windows.Forms.Button btnDeleteAnimal;
    }
}

