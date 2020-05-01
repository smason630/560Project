namespace GamesLibrary
{
    partial class AddView
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
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxYear = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelConsole = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.uxSubmit = new System.Windows.Forms.Button();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelPub = new System.Windows.Forms.Label();
            this.labelDev = new System.Windows.Forms.Label();
            this.uxGenre = new System.Windows.Forms.ComboBox();
            this.uxConsole = new System.Windows.Forms.ComboBox();
            this.uxCountry = new System.Windows.Forms.ComboBox();
            this.uxPublisher = new System.Windows.Forms.ComboBox();
            this.uxDeveloper = new System.Windows.Forms.ComboBox();
            this.uxRating = new System.Windows.Forms.ComboBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(55, 50);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(100, 20);
            this.uxName.TabIndex = 0;
            // 
            // uxYear
            // 
            this.uxYear.Location = new System.Drawing.Point(55, 189);
            this.uxYear.Name = "uxYear";
            this.uxYear.Size = new System.Drawing.Size(100, 20);
            this.uxYear.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(66, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Game Name";
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.Location = new System.Drawing.Point(234, 33);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(76, 13);
            this.labelConsole.TabIndex = 7;
            this.labelConsole.Text = "Console Name";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(413, 33);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(67, 13);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre Name";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(66, 173);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(71, 13);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Release Year";
            // 
            // uxSubmit
            // 
            this.uxSubmit.Location = new System.Drawing.Point(62, 240);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(75, 23);
            this.uxSubmit.TabIndex = 12;
            this.uxSubmit.Text = "Submit";
            this.uxSubmit.UseVisualStyleBackColor = true;
            this.uxSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(83, 101);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 14;
            this.labelCountry.Text = "Country";
            // 
            // labelPub
            // 
            this.labelPub.AutoSize = true;
            this.labelPub.Location = new System.Drawing.Point(234, 101);
            this.labelPub.Name = "labelPub";
            this.labelPub.Size = new System.Drawing.Size(81, 13);
            this.labelPub.TabIndex = 10;
            this.labelPub.Text = "Publisher Name";
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.Location = new System.Drawing.Point(413, 101);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(87, 13);
            this.labelDev.TabIndex = 11;
            this.labelDev.Text = "Developer Name";
            // 
            // uxGenre
            // 
            this.uxGenre.FormattingEnabled = true;
            this.uxGenre.Location = new System.Drawing.Point(390, 48);
            this.uxGenre.Name = "uxGenre";
            this.uxGenre.Size = new System.Drawing.Size(121, 21);
            this.uxGenre.TabIndex = 15;
            // 
            // uxConsole
            // 
            this.uxConsole.FormattingEnabled = true;
            this.uxConsole.Location = new System.Drawing.Point(214, 48);
            this.uxConsole.Name = "uxConsole";
            this.uxConsole.Size = new System.Drawing.Size(121, 21);
            this.uxConsole.TabIndex = 16;
            // 
            // uxCountry
            // 
            this.uxCountry.FormattingEnabled = true;
            this.uxCountry.Location = new System.Drawing.Point(44, 117);
            this.uxCountry.Name = "uxCountry";
            this.uxCountry.Size = new System.Drawing.Size(121, 21);
            this.uxCountry.TabIndex = 17;
            // 
            // uxPublisher
            // 
            this.uxPublisher.FormattingEnabled = true;
            this.uxPublisher.Location = new System.Drawing.Point(214, 117);
            this.uxPublisher.Name = "uxPublisher";
            this.uxPublisher.Size = new System.Drawing.Size(121, 21);
            this.uxPublisher.TabIndex = 18;
            // 
            // uxDeveloper
            // 
            this.uxDeveloper.FormattingEnabled = true;
            this.uxDeveloper.Location = new System.Drawing.Point(390, 117);
            this.uxDeveloper.Name = "uxDeveloper";
            this.uxDeveloper.Size = new System.Drawing.Size(121, 21);
            this.uxDeveloper.TabIndex = 19;
            // 
            // uxRating
            // 
            this.uxRating.FormattingEnabled = true;
            this.uxRating.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.uxRating.Location = new System.Drawing.Point(214, 188);
            this.uxRating.Name = "uxRating";
            this.uxRating.Size = new System.Drawing.Size(59, 21);
            this.uxRating.TabIndex = 20;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(223, 173);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(38, 13);
            this.labelRating.TabIndex = 21;
            this.labelRating.Text = "Rating";
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 295);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.uxRating);
            this.Controls.Add(this.uxDeveloper);
            this.Controls.Add(this.uxPublisher);
            this.Controls.Add(this.uxCountry);
            this.Controls.Add(this.uxConsole);
            this.Controls.Add(this.uxGenre);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.uxSubmit);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.labelPub);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.uxYear);
            this.Controls.Add(this.uxName);
            this.Name = "AddView";
            this.Text = "Add Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.TextBox uxYear;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelConsole;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button uxSubmit;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelPub;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.ComboBox uxGenre;
        private System.Windows.Forms.ComboBox uxConsole;
        private System.Windows.Forms.ComboBox uxCountry;
        private System.Windows.Forms.ComboBox uxPublisher;
        private System.Windows.Forms.ComboBox uxDeveloper;
        private System.Windows.Forms.ComboBox uxRating;
        private System.Windows.Forms.Label labelRating;
    }
}