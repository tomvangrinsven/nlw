namespace NameLabelWriter
{
    partial class AddAnimal
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
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnimalCountryOfOrigin = new System.Windows.Forms.TextBox();
            this.btnAddAnimalsToDatabase = new System.Windows.Forms.Button();
            this.lbAnimalsToAdd = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAnimalToList = new System.Windows.Forms.Button();
            this.btnRemoveAnimalFromList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalName.Location = new System.Drawing.Point(12, 29);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(801, 24);
            this.txtAnimalName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Land van herkomst:";
            // 
            // txtAnimalCountryOfOrigin
            // 
            this.txtAnimalCountryOfOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalCountryOfOrigin.Location = new System.Drawing.Point(12, 75);
            this.txtAnimalCountryOfOrigin.Name = "txtAnimalCountryOfOrigin";
            this.txtAnimalCountryOfOrigin.Size = new System.Drawing.Size(801, 24);
            this.txtAnimalCountryOfOrigin.TabIndex = 1;
            // 
            // btnAddAnimalsToDatabase
            // 
            this.btnAddAnimalsToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimalsToDatabase.Location = new System.Drawing.Point(604, 341);
            this.btnAddAnimalsToDatabase.Name = "btnAddAnimalsToDatabase";
            this.btnAddAnimalsToDatabase.Size = new System.Drawing.Size(209, 37);
            this.btnAddAnimalsToDatabase.TabIndex = 4;
            this.btnAddAnimalsToDatabase.Text = "Voeg dier toe aan database";
            this.btnAddAnimalsToDatabase.UseVisualStyleBackColor = true;
            this.btnAddAnimalsToDatabase.Click += new System.EventHandler(this.btnAddAnimalsToDatabase_Click);
            // 
            // lbAnimalsToAdd
            // 
            this.lbAnimalsToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimalsToAdd.FormattingEnabled = true;
            this.lbAnimalsToAdd.ItemHeight = 18;
            this.lbAnimalsToAdd.Location = new System.Drawing.Point(12, 160);
            this.lbAnimalsToAdd.Name = "lbAnimalsToAdd";
            this.lbAnimalsToAdd.Size = new System.Drawing.Size(801, 166);
            this.lbAnimalsToAdd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dieren om toe te voegen:";
            // 
            // btnAddAnimalToList
            // 
            this.btnAddAnimalToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimalToList.Location = new System.Drawing.Point(661, 105);
            this.btnAddAnimalToList.Name = "btnAddAnimalToList";
            this.btnAddAnimalToList.Size = new System.Drawing.Size(152, 37);
            this.btnAddAnimalToList.TabIndex = 2;
            this.btnAddAnimalToList.Text = "Voeg dier toe aan lijst";
            this.btnAddAnimalToList.UseVisualStyleBackColor = true;
            this.btnAddAnimalToList.Click += new System.EventHandler(this.btnAddAnimalToList_Click);
            // 
            // btnRemoveAnimalFromList
            // 
            this.btnRemoveAnimalFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAnimalFromList.Location = new System.Drawing.Point(12, 341);
            this.btnRemoveAnimalFromList.Name = "btnRemoveAnimalFromList";
            this.btnRemoveAnimalFromList.Size = new System.Drawing.Size(155, 37);
            this.btnRemoveAnimalFromList.TabIndex = 5;
            this.btnRemoveAnimalFromList.Text = "Verwijder dier van lijst";
            this.btnRemoveAnimalFromList.UseVisualStyleBackColor = true;
            this.btnRemoveAnimalFromList.Click += new System.EventHandler(this.btnRemoveAnimalFromList_Click);
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 642);
            this.Controls.Add(this.btnRemoveAnimalFromList);
            this.Controls.Add(this.btnAddAnimalToList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAnimalsToAdd);
            this.Controls.Add(this.btnAddAnimalsToDatabase);
            this.Controls.Add(this.txtAnimalCountryOfOrigin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnimalName);
            this.Name = "AddAnimal";
            this.Text = "AddAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnimalCountryOfOrigin;
        private System.Windows.Forms.Button btnAddAnimalsToDatabase;
        private System.Windows.Forms.ListBox lbAnimalsToAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAnimalToList;
        private System.Windows.Forms.Button btnRemoveAnimalFromList;
    }
}