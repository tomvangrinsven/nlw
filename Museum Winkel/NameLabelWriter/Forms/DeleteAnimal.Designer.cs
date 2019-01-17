namespace NameLabelWriter
{
    partial class DeleteAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindAnimal = new System.Windows.Forms.TextBox();
            this.btnFindAnimal = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteAnimal = new System.Windows.Forms.Button();
            this.lbAllAnimals = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedAnimal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoek een dier om te verwijderen:";
            // 
            // txtFindAnimal
            // 
            this.txtFindAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindAnimal.Location = new System.Drawing.Point(16, 30);
            this.txtFindAnimal.Name = "txtFindAnimal";
            this.txtFindAnimal.Size = new System.Drawing.Size(802, 24);
            this.txtFindAnimal.TabIndex = 0;
            this.txtFindAnimal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindAnimal_KeyDown);
            // 
            // btnFindAnimal
            // 
            this.btnFindAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAnimal.Location = new System.Drawing.Point(674, 57);
            this.btnFindAnimal.Name = "btnFindAnimal";
            this.btnFindAnimal.Size = new System.Drawing.Size(143, 23);
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
            this.lbResults.Location = new System.Drawing.Point(15, 86);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(802, 112);
            this.lbResults.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zoek tussen bekende dieren:";
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAnimal.Location = new System.Drawing.Point(674, 213);
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteAnimal.TabIndex = 3;
            this.btnDeleteAnimal.Text = "Verwijder geselecteerd dier";
            this.btnDeleteAnimal.UseVisualStyleBackColor = true;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.btnDeleteAnimal_Click);
            // 
            // lbAllAnimals
            // 
            this.lbAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllAnimals.FormattingEnabled = true;
            this.lbAllAnimals.ItemHeight = 18;
            this.lbAllAnimals.Location = new System.Drawing.Point(15, 269);
            this.lbAllAnimals.Name = "lbAllAnimals";
            this.lbAllAnimals.Size = new System.Drawing.Size(803, 184);
            this.lbAllAnimals.TabIndex = 4;
            // 
            // btnDeleteSelectedAnimal
            // 
            this.btnDeleteSelectedAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedAnimal.Location = new System.Drawing.Point(624, 468);
            this.btnDeleteSelectedAnimal.Name = "btnDeleteSelectedAnimal";
            this.btnDeleteSelectedAnimal.Size = new System.Drawing.Size(194, 29);
            this.btnDeleteSelectedAnimal.TabIndex = 5;
            this.btnDeleteSelectedAnimal.Text = "Verwijder geselecteerd dier";
            this.btnDeleteSelectedAnimal.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedAnimal.Click += new System.EventHandler(this.btnDeleteSelectedAnimal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultaten:";
            // 
            // DeleteAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteSelectedAnimal);
            this.Controls.Add(this.lbAllAnimals);
            this.Controls.Add(this.btnDeleteAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnFindAnimal);
            this.Controls.Add(this.txtFindAnimal);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAnimal";
            this.Text = "DeleteAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindAnimal;
        private System.Windows.Forms.Button btnFindAnimal;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteAnimal;
        private System.Windows.Forms.ListBox lbAllAnimals;
        private System.Windows.Forms.Button btnDeleteSelectedAnimal;
        private System.Windows.Forms.Label label3;
    }
}