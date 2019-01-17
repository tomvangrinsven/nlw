namespace NameLabelWriter
{
    partial class UpdateAnimal
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbAllAnimals = new System.Windows.Forms.ListBox();
            this.btnSaveSearchedAnimal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnFindAnimal = new System.Windows.Forms.Button();
            this.txtFindAnimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewNameOfResultAnimal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewOriginOfResultAnimal = new System.Windows.Forms.TextBox();
            this.btnSaveSelectedAnimal = new System.Windows.Forms.Button();
            this.txtNewOriginOfSelectedAnimal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewNameOfSelectedAnimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Resultaten:";
            // 
            // lbAllAnimals
            // 
            this.lbAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllAnimals.FormattingEnabled = true;
            this.lbAllAnimals.ItemHeight = 18;
            this.lbAllAnimals.Location = new System.Drawing.Point(12, 327);
            this.lbAllAnimals.Name = "lbAllAnimals";
            this.lbAllAnimals.Size = new System.Drawing.Size(803, 184);
            this.lbAllAnimals.TabIndex = 7;
            this.lbAllAnimals.SelectedIndexChanged += new System.EventHandler(this.lbAllAnimals_SelectedIndexChanged);
            // 
            // btnSaveSearchedAnimal
            // 
            this.btnSaveSearchedAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSearchedAnimal.Location = new System.Drawing.Point(670, 298);
            this.btnSaveSearchedAnimal.Name = "btnSaveSearchedAnimal";
            this.btnSaveSearchedAnimal.Size = new System.Drawing.Size(143, 23);
            this.btnSaveSearchedAnimal.TabIndex = 6;
            this.btnSaveSearchedAnimal.Text = "Sla dier op";
            this.btnSaveSearchedAnimal.UseVisualStyleBackColor = true;
            this.btnSaveSearchedAnimal.Click += new System.EventHandler(this.btnSaveSearchedAnimal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Zoek tussen bekende dieren:";
            // 
            // lbResults
            // 
            this.lbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 18;
            this.lbResults.Location = new System.Drawing.Point(11, 84);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(802, 112);
            this.lbResults.TabIndex = 3;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // btnFindAnimal
            // 
            this.btnFindAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAnimal.Location = new System.Drawing.Point(670, 55);
            this.btnFindAnimal.Name = "btnFindAnimal";
            this.btnFindAnimal.Size = new System.Drawing.Size(143, 23);
            this.btnFindAnimal.TabIndex = 2;
            this.btnFindAnimal.Text = "Zoek dier";
            this.btnFindAnimal.UseVisualStyleBackColor = true;
            this.btnFindAnimal.Click += new System.EventHandler(this.btnFindAnimal_Click);
            // 
            // txtFindAnimal
            // 
            this.txtFindAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindAnimal.Location = new System.Drawing.Point(12, 28);
            this.txtFindAnimal.Name = "txtFindAnimal";
            this.txtFindAnimal.Size = new System.Drawing.Size(802, 24);
            this.txtFindAnimal.TabIndex = 1;
            this.txtFindAnimal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindAnimal_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zoek een dier om aan te passen:";
            // 
            // txtNewNameOfResultAnimal
            // 
            this.txtNewNameOfResultAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewNameOfResultAnimal.Location = new System.Drawing.Point(11, 228);
            this.txtNewNameOfResultAnimal.Name = "txtNewNameOfResultAnimal";
            this.txtNewNameOfResultAnimal.Size = new System.Drawing.Size(803, 24);
            this.txtNewNameOfResultAnimal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nieuwe naam:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nieuwe herkomst:";
            // 
            // txtNewOriginOfResultAnimal
            // 
            this.txtNewOriginOfResultAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewOriginOfResultAnimal.Location = new System.Drawing.Point(11, 272);
            this.txtNewOriginOfResultAnimal.Name = "txtNewOriginOfResultAnimal";
            this.txtNewOriginOfResultAnimal.Size = new System.Drawing.Size(803, 24);
            this.txtNewOriginOfResultAnimal.TabIndex = 5;
            // 
            // btnSaveSelectedAnimal
            // 
            this.btnSaveSelectedAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSelectedAnimal.Location = new System.Drawing.Point(672, 616);
            this.btnSaveSelectedAnimal.Name = "btnSaveSelectedAnimal";
            this.btnSaveSelectedAnimal.Size = new System.Drawing.Size(143, 23);
            this.btnSaveSelectedAnimal.TabIndex = 10;
            this.btnSaveSelectedAnimal.Text = "Sla dier op";
            this.btnSaveSelectedAnimal.UseVisualStyleBackColor = true;
            this.btnSaveSelectedAnimal.Click += new System.EventHandler(this.btnSaveSelectedAnimal_Click);
            // 
            // txtNewOriginOfSelectedAnimal
            // 
            this.txtNewOriginOfSelectedAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewOriginOfSelectedAnimal.Location = new System.Drawing.Point(12, 590);
            this.txtNewOriginOfSelectedAnimal.Name = "txtNewOriginOfSelectedAnimal";
            this.txtNewOriginOfSelectedAnimal.Size = new System.Drawing.Size(803, 24);
            this.txtNewOriginOfSelectedAnimal.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nieuwe herkomst:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nieuwe naam:";
            // 
            // txtNewNameOfSelectedAnimal
            // 
            this.txtNewNameOfSelectedAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewNameOfSelectedAnimal.Location = new System.Drawing.Point(12, 546);
            this.txtNewNameOfSelectedAnimal.Name = "txtNewNameOfSelectedAnimal";
            this.txtNewNameOfSelectedAnimal.Size = new System.Drawing.Size(803, 24);
            this.txtNewNameOfSelectedAnimal.TabIndex = 8;
            // 
            // UpdateAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 642);
            this.Controls.Add(this.txtNewOriginOfSelectedAnimal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNewNameOfSelectedAnimal);
            this.Controls.Add(this.btnSaveSelectedAnimal);
            this.Controls.Add(this.txtNewOriginOfResultAnimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewNameOfResultAnimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAllAnimals);
            this.Controls.Add(this.btnSaveSearchedAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnFindAnimal);
            this.Controls.Add(this.txtFindAnimal);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAnimal";
            this.Text = "UpdateAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbAllAnimals;
        private System.Windows.Forms.Button btnSaveSearchedAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnFindAnimal;
        private System.Windows.Forms.TextBox txtFindAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewNameOfResultAnimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewOriginOfResultAnimal;
        private System.Windows.Forms.Button btnSaveSelectedAnimal;
        private System.Windows.Forms.TextBox txtNewOriginOfSelectedAnimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewNameOfSelectedAnimal;
    }
}