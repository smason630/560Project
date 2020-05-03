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
            this.uxName.Location = new System.Drawing.Point(73, 62);
            this.uxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(132, 22);
            this.uxName.TabIndex = 0;
            // 
            // uxYear
            // 
            this.uxYear.Location = new System.Drawing.Point(73, 233);
            this.uxYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxYear.Name = "uxYear";
            this.uxYear.Size = new System.Drawing.Size(132, 22);
            this.uxYear.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(88, 41);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 17);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Game Name";
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.Location = new System.Drawing.Point(312, 41);
            this.labelConsole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(100, 17);
            this.labelConsole.TabIndex = 7;
            this.labelConsole.Text = "Console Name";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(551, 41);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(89, 17);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre Name";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(88, 213);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(94, 17);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Release Year";
            // 
            // uxSubmit
            // 
            this.uxSubmit.Location = new System.Drawing.Point(83, 295);
            this.uxSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(100, 28);
            this.uxSubmit.TabIndex = 12;
            this.uxSubmit.Text = "Submit";
            this.uxSubmit.UseVisualStyleBackColor = true;
            this.uxSubmit.Click += new System.EventHandler(this.OnSubmitClick);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(111, 124);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(57, 17);
            this.labelCountry.TabIndex = 14;
            this.labelCountry.Text = "Country";
            // 
            // labelPub
            // 
            this.labelPub.AutoSize = true;
            this.labelPub.Location = new System.Drawing.Point(312, 124);
            this.labelPub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPub.Name = "labelPub";
            this.labelPub.Size = new System.Drawing.Size(108, 17);
            this.labelPub.TabIndex = 10;
            this.labelPub.Text = "Publisher Name";
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.Location = new System.Drawing.Point(551, 124);
            this.labelDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(114, 17);
            this.labelDev.TabIndex = 11;
            this.labelDev.Text = "Developer Name";
            // 
            // uxGenre
            // 
            this.uxGenre.FormattingEnabled = true;
            this.uxGenre.Location = new System.Drawing.Point(520, 59);
            this.uxGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxGenre.Name = "uxGenre";
            this.uxGenre.Size = new System.Drawing.Size(160, 24);
            this.uxGenre.TabIndex = 15;
            // 
            // uxConsole
            // 
            this.uxConsole.FormattingEnabled = true;
            this.uxConsole.Location = new System.Drawing.Point(285, 59);
            this.uxConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxConsole.Name = "uxConsole";
            this.uxConsole.Size = new System.Drawing.Size(160, 24);
            this.uxConsole.TabIndex = 16;
            // 
            // uxCountry
            // 
            this.uxCountry.FormattingEnabled = true;
            this.uxCountry.Location = new System.Drawing.Point(59, 144);
            this.uxCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxCountry.Name = "uxCountry";
            this.uxCountry.Size = new System.Drawing.Size(160, 24);
            this.uxCountry.TabIndex = 17;
            // 
            // uxPublisher
            // 
            this.uxPublisher.FormattingEnabled = true;
            this.uxPublisher.Location = new System.Drawing.Point(285, 144);
            this.uxPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxPublisher.Name = "uxPublisher";
            this.uxPublisher.Size = new System.Drawing.Size(160, 24);
            this.uxPublisher.TabIndex = 18;
            // 
            // uxDeveloper
            // 
            this.uxDeveloper.FormattingEnabled = true;
            this.uxDeveloper.Location = new System.Drawing.Point(520, 144);
            this.uxDeveloper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxDeveloper.Name = "uxDeveloper";
            this.uxDeveloper.Size = new System.Drawing.Size(160, 24);
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
            this.uxRating.Location = new System.Drawing.Point(285, 231);
            this.uxRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxRating.Name = "uxRating";
            this.uxRating.Size = new System.Drawing.Size(77, 24);
            this.uxRating.TabIndex = 20;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(297, 213);
            this.labelRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(49, 17);
            this.labelRating.TabIndex = 21;
            this.labelRating.Text = "Rating";
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 363);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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