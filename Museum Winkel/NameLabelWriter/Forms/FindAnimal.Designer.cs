namespace NameLabelWriter
{
    partial class FindAnimal
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
            this.txtFindAnimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindAnimal = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.lbAnimalsToPrint = new System.Windows.Forms.ListBox();
            this.btnCreateExcelFile = new System.Windows.Forms.Button();
            this.btnDeleteAnimalFromList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFindAnimal
            // 
            this.txtFindAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindAnimal.Location = new System.Drawing.Point(12, 28);
            this.txtFindAnimal.Name = "txtFindAnimal";
            this.txtFindAnimal.Size = new System.Drawing.Size(801, 24);
            this.txtFindAnimal.TabIndex = 0;
            this.txtFindAnimal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindAnimal_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam van het dier:";
            // 
            // btnFindAnimal
            // 
            this.btnFindAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAnimal.Location = new System.Drawing.Point(672, 54);
            this.btnFindAnimal.Name = "btnFindAnimal";
            this.btnFindAnimal.Size = new System.Drawing.Size(141, 28);
            this.btnFindAnimal.TabIndex = 1;
            this.btnFindAnimal.Text = "Zoek dier";
            this.btnFindAnimal.UseVisualStyleBackColor = true;
            this.btnFindAnimal.Click += new System.EventHandler(this.btnFindAnimal_Click);
            // 
            // lbResults
            // 
            this.lbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 18;
            this.lbResults.Location = new System.Drawing.Point(12, 104);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(801, 166);
            this.lbResults.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultaten:";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(672, 276);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(141, 33);
            this.btnAddAnimal.TabIndex = 3;
            this.btnAddAnimal.Text = "Voeg toe";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // lbAnimalsToPrint
            // 
            this.lbAnimalsToPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimalsToPrint.FormattingEnabled = true;
            this.lbAnimalsToPrint.ItemHeight = 18;
            this.lbAnimalsToPrint.Location = new System.Drawing.Point(12, 331);
            this.lbAnimalsToPrint.Name = "lbAnimalsToPrint";
            this.lbAnimalsToPrint.Size = new System.Drawing.Size(801, 148);
            this.lbAnimalsToPrint.TabIndex = 4;
            // 
            // btnCreateExcelFile
            // 
            this.btnCreateExcelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExcelFile.Location = new System.Drawing.Point(672, 485);
            this.btnCreateExcelFile.Name = "btnCreateExcelFile";
            this.btnCreateExcelFile.Size = new System.Drawing.Size(141, 30);
            this.btnCreateExcelFile.TabIndex = 5;
            this.btnCreateExcelFile.Text = "Maak excel bestand";
            this.btnCreateExcelFile.UseVisualStyleBackColor = true;
            this.btnCreateExcelFile.Click += new System.EventHandler(this.btnCreateExcelFile_Click);
            // 
            // btnDeleteAnimalFromList
            // 
            this.btnDeleteAnimalFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAnimalFromList.Location = new System.Drawing.Point(12, 485);
            this.btnDeleteAnimalFromList.Name = "btnDeleteAnimalFromList";
            this.btnDeleteAnimalFromList.Size = new System.Drawing.Size(171, 30);
            this.btnDeleteAnimalFromList.TabIndex = 6;
            this.btnDeleteAnimalFromList.Text = "Verwijder dier van lijst";
            this.btnDeleteAnimalFromList.UseVisualStyleBackColor = true;
            this.btnDeleteAnimalFromList.Click += new System.EventHandler(this.btnDeleteAnimalFromList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dieren om te printen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aantal naamkaartjes: ";
            // 
            // FindAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 642);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteAnimalFromList);
            this.Controls.Add(this.btnCreateExcelFile);
            this.Controls.Add(this.lbAnimalsToPrint);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnFindAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindAnimal);
            this.Name = "FindAnimal";
            this.Text = "FindAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFindAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindAnimal;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ListBox lbAnimalsToPrint;
        private System.Windows.Forms.Button btnCreateExcelFile;
        private System.Windows.Forms.Button btnDeleteAnimalFromList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}