namespace GamesLibrary
{
    partial class GamesLibrary
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
            this.UX_PublisherButton = new System.Windows.Forms.Button();
            this.UX_DeveloperButton = new System.Windows.Forms.Button();
            this.UX_GamesButton = new System.Windows.Forms.Button();
            this.UX_SearchBar = new System.Windows.Forms.TextBox();
            this.UX_SearchButton = new System.Windows.Forms.Button();
            this.UX_Table = new System.Windows.Forms.DataGridView();
            this.UX_GenreDropDown = new System.Windows.Forms.ComboBox();
            this.UX_ConsoleDropDown = new System.Windows.Forms.ComboBox();
            this.UX_AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UX_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // UX_PublisherButton
            // 
            this.UX_PublisherButton.Location = new System.Drawing.Point(341, 28);
            this.UX_PublisherButton.Name = "UX_PublisherButton";
            this.UX_PublisherButton.Size = new System.Drawing.Size(75, 20);
            this.UX_PublisherButton.TabIndex = 2;
            this.UX_PublisherButton.Text = "Publisher";
            this.UX_PublisherButton.UseVisualStyleBackColor = true;
            this.UX_PublisherButton.Click += new System.EventHandler(this.UX_PublisherButton_Click);
            // 
            // UX_DeveloperButton
            // 
            this.UX_DeveloperButton.Location = new System.Drawing.Point(435, 28);
            this.UX_DeveloperButton.Name = "UX_DeveloperButton";
            this.UX_DeveloperButton.Size = new System.Drawing.Size(75, 20);
            this.UX_DeveloperButton.TabIndex = 3;
            this.UX_DeveloperButton.Text = "Developer";
            this.UX_DeveloperButton.UseVisualStyleBackColor = true;
            this.UX_DeveloperButton.Click += new System.EventHandler(this.UX_DeveloperButton_Click);
            // 
            // UX_GamesButton
            // 
            this.UX_GamesButton.Location = new System.Drawing.Point(12, 29);
            this.UX_GamesButton.Name = "UX_GamesButton";
            this.UX_GamesButton.Size = new System.Drawing.Size(75, 21);
            this.UX_GamesButton.TabIndex = 4;
            this.UX_GamesButton.Text = "Games List";
            this.UX_GamesButton.UseVisualStyleBackColor = true;
            // 
            // UX_SearchBar
            // 
            this.UX_SearchBar.Location = new System.Drawing.Point(662, 28);
            this.UX_SearchBar.Name = "UX_SearchBar";
            this.UX_SearchBar.Size = new System.Drawing.Size(100, 20);
            this.UX_SearchBar.TabIndex = 5;
            // 
            // UX_SearchButton
            // 
            this.UX_SearchButton.Location = new System.Drawing.Point(768, 27);
            this.UX_SearchButton.Name = "UX_SearchButton";
            this.UX_SearchButton.Size = new System.Drawing.Size(75, 20);
            this.UX_SearchButton.TabIndex = 6;
            this.UX_SearchButton.Text = "Search";
            this.UX_SearchButton.UseVisualStyleBackColor = true;
            this.UX_SearchButton.Click += new System.EventHandler(this.UX_SearchButton_Click);
            // 
            // UX_Table
            // 
            this.UX_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UX_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UX_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UX_Table.Location = new System.Drawing.Point(12, 76);
            this.UX_Table.Name = "UX_Table";
            this.UX_Table.ReadOnly = true;
            this.UX_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UX_Table.Size = new System.Drawing.Size(842, 368);
            this.UX_Table.TabIndex = 7;
            // 
            // UX_GenreDropDown
            // 
            this.UX_GenreDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UX_GenreDropDown.FormattingEnabled = true;
            this.UX_GenreDropDown.Items.AddRange(new object[] {
            "Sports",
            "Hack and slash",
            "Action",
            "Racing",
            "Third-person shooter",
            "Music",
            "Puzzle",
            "Adventure",
            "Simulator",
            "Platformer",
            "Real Time Strategy",
            "Action Role-Playing"});
            this.UX_GenreDropDown.Location = new System.Drawing.Point(108, 29);
            this.UX_GenreDropDown.Name = "UX_GenreDropDown";
            this.UX_GenreDropDown.Size = new System.Drawing.Size(97, 21);
            this.UX_GenreDropDown.TabIndex = 9;
            // 
            // UX_ConsoleDropDown
            // 
            this.UX_ConsoleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UX_ConsoleDropDown.FormattingEnabled = true;
            this.UX_ConsoleDropDown.Items.AddRange(new object[] {
            "Atari 2600",
            "Dreamcast",
            "Gameboy",
            "Gameboy Advance",
            "Gameboy Color",
            "Gamecube",
            "HTC Vive",
            "NES",
            "Nintendo 64",
            "Nintendo DS",
            "Nintendo Switch",
            "PC",
            "Playstation",
            "Playstation 2",
            "Playstation 3",
            "Playstation 4",
            "Sega Genesis",
            "Wii",
            "Wii U",
            "Xbox",
            "Xbox 360",
            "Xbox Series X"});
            this.UX_ConsoleDropDown.Location = new System.Drawing.Point(226, 28);
            this.UX_ConsoleDropDown.Name = "UX_ConsoleDropDown";
            this.UX_ConsoleDropDown.Size = new System.Drawing.Size(97, 21);
            this.UX_ConsoleDropDown.TabIndex = 10;
            // 
            // UX_AddButton
            // 
            this.UX_AddButton.Location = new System.Drawing.Point(779, 457);
            this.UX_AddButton.Name = "UX_AddButton";
            this.UX_AddButton.Size = new System.Drawing.Size(75, 23);
            this.UX_AddButton.TabIndex = 11;
            this.UX_AddButton.Text = "Add";
            this.UX_AddButton.UseVisualStyleBackColor = true;
            this.UX_AddButton.Click += new System.EventHandler(this.UX_AddButton_Click);
            // 
            // GamesLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(866, 492);
            this.Controls.Add(this.UX_AddButton);
            this.Controls.Add(this.UX_ConsoleDropDown);
            this.Controls.Add(this.UX_GenreDropDown);
            this.Controls.Add(this.UX_Table);
            this.Controls.Add(this.UX_SearchButton);
            this.Controls.Add(this.UX_SearchBar);
            this.Controls.Add(this.UX_GamesButton);
            this.Controls.Add(this.UX_DeveloperButton);
            this.Controls.Add(this.UX_PublisherButton);
            this.Name = "GamesLibrary";
            this.Text = "Games";
            this.Load += new System.EventHandler(this.GamesLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UX_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UX_PublisherButton;
        private System.Windows.Forms.Button UX_DeveloperButton;
        private System.Windows.Forms.Button UX_GamesButton;
        private System.Windows.Forms.TextBox UX_SearchBar;
        private System.Windows.Forms.Button UX_SearchButton;
        private System.Windows.Forms.DataGridView UX_Table;
        private System.Windows.Forms.ComboBox UX_GenreDropDown;
        private System.Windows.Forms.ComboBox UX_ConsoleDropDown;
        private System.Windows.Forms.Button UX_AddButton;
    }
}

