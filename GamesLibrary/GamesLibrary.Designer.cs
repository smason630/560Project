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
            this.UX_GenreDropDown = new System.Windows.Forms.ComboBox();
            this.UX_ConsoleDropDown = new System.Windows.Forms.ComboBox();
            this.UX_AddButton = new System.Windows.Forms.Button();
            this.uxTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxTable)).BeginInit();
            this.SuspendLayout();
            // 
            // UX_PublisherButton
            // 
            this.UX_PublisherButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UX_PublisherButton.Location = new System.Drawing.Point(455, 34);
            this.UX_PublisherButton.Margin = new System.Windows.Forms.Padding(4);
            this.UX_PublisherButton.Name = "UX_PublisherButton";
            this.UX_PublisherButton.Size = new System.Drawing.Size(100, 25);
            this.UX_PublisherButton.TabIndex = 2;
            this.UX_PublisherButton.Text = "Publisher";
            this.UX_PublisherButton.UseVisualStyleBackColor = true;
            this.UX_PublisherButton.Click += new System.EventHandler(this.UX_PublisherButton_Click);
            // 
            // UX_DeveloperButton
            // 
            this.UX_DeveloperButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UX_DeveloperButton.Location = new System.Drawing.Point(580, 34);
            this.UX_DeveloperButton.Margin = new System.Windows.Forms.Padding(4);
            this.UX_DeveloperButton.Name = "UX_DeveloperButton";
            this.UX_DeveloperButton.Size = new System.Drawing.Size(100, 25);
            this.UX_DeveloperButton.TabIndex = 3;
            this.UX_DeveloperButton.Text = "Developer";
            this.UX_DeveloperButton.UseVisualStyleBackColor = true;
            this.UX_DeveloperButton.Click += new System.EventHandler(this.UX_DeveloperButton_Click);
            // 
            // UX_GamesButton
            // 
            this.UX_GamesButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UX_GamesButton.Location = new System.Drawing.Point(16, 36);
            this.UX_GamesButton.Margin = new System.Windows.Forms.Padding(4);
            this.UX_GamesButton.Name = "UX_GamesButton";
            this.UX_GamesButton.Size = new System.Drawing.Size(100, 26);
            this.UX_GamesButton.TabIndex = 4;
            this.UX_GamesButton.Text = "Games List";
            this.UX_GamesButton.UseVisualStyleBackColor = true;
            this.UX_GamesButton.Click += new System.EventHandler(this.UX_GamesButton_Click);
            // 
            // UX_SearchBar
            // 
            this.UX_SearchBar.Location = new System.Drawing.Point(883, 34);
            this.UX_SearchBar.Margin = new System.Windows.Forms.Padding(4);
            this.UX_SearchBar.Name = "UX_SearchBar";
            this.UX_SearchBar.Size = new System.Drawing.Size(132, 22);
            this.UX_SearchBar.TabIndex = 5;
            // 
            // UX_SearchButton
            // 
            this.UX_SearchButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UX_SearchButton.Location = new System.Drawing.Point(1024, 33);
            this.UX_SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.UX_SearchButton.Name = "UX_SearchButton";
            this.UX_SearchButton.Size = new System.Drawing.Size(100, 25);
            this.UX_SearchButton.TabIndex = 6;
            this.UX_SearchButton.Text = "Search";
            this.UX_SearchButton.UseVisualStyleBackColor = true;
            this.UX_SearchButton.Click += new System.EventHandler(this.UX_SearchButton_Click);
            // 
            // UX_GenreDropDown
            // 
            this.UX_GenreDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UX_GenreDropDown.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.UX_GenreDropDown.Location = new System.Drawing.Point(144, 36);
            this.UX_GenreDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.UX_GenreDropDown.Name = "UX_GenreDropDown";
            this.UX_GenreDropDown.Size = new System.Drawing.Size(128, 24);
            this.UX_GenreDropDown.TabIndex = 9;
            this.UX_GenreDropDown.SelectedIndexChanged += new System.EventHandler(this.UX_GenreDropDown_SelectedIndexChanged);
            // 
            // UX_ConsoleDropDown
            // 
            this.UX_ConsoleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UX_ConsoleDropDown.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.UX_ConsoleDropDown.Location = new System.Drawing.Point(301, 34);
            this.UX_ConsoleDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.UX_ConsoleDropDown.Name = "UX_ConsoleDropDown";
            this.UX_ConsoleDropDown.Size = new System.Drawing.Size(128, 24);
            this.UX_ConsoleDropDown.TabIndex = 10;
            this.UX_ConsoleDropDown.SelectedIndexChanged += new System.EventHandler(this.UX_ConsoleDropDown_SelectedIndexChanged);
            // 
            // UX_AddButton
            // 
            this.UX_AddButton.Location = new System.Drawing.Point(1037, 562);
            this.UX_AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.UX_AddButton.Name = "UX_AddButton";
            this.UX_AddButton.Size = new System.Drawing.Size(153, 28);
            this.UX_AddButton.TabIndex = 11;
            this.UX_AddButton.Text = "Add Game";
            this.UX_AddButton.UseVisualStyleBackColor = true;
            this.UX_AddButton.Click += new System.EventHandler(this.UX_AddButton_Click);
            // 
            // uxTable
            // 
            this.uxTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.uxTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxTable.Location = new System.Drawing.Point(16, 81);
            this.uxTable.Margin = new System.Windows.Forms.Padding(4);
            this.uxTable.Name = "uxTable";
            this.uxTable.ReadOnly = true;
            this.uxTable.RowHeadersWidth = 51;
            this.uxTable.Size = new System.Drawing.Size(1013, 510);
            this.uxTable.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Console";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "See All";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "See All";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "See All";
            // 
            // GamesLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 606);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxTable);
            this.Controls.Add(this.UX_AddButton);
            this.Controls.Add(this.UX_ConsoleDropDown);
            this.Controls.Add(this.UX_GenreDropDown);
            this.Controls.Add(this.UX_SearchButton);
            this.Controls.Add(this.UX_SearchBar);
            this.Controls.Add(this.UX_GamesButton);
            this.Controls.Add(this.UX_DeveloperButton);
            this.Controls.Add(this.UX_PublisherButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GamesLibrary";
            this.Text = "Games Library";
            this.Load += new System.EventHandler(this.GamesLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UX_PublisherButton;
        private System.Windows.Forms.Button UX_DeveloperButton;
        private System.Windows.Forms.Button UX_GamesButton;
        private System.Windows.Forms.TextBox UX_SearchBar;
        private System.Windows.Forms.Button UX_SearchButton;
        private System.Windows.Forms.ComboBox UX_GenreDropDown;
        private System.Windows.Forms.ComboBox UX_ConsoleDropDown;
        private System.Windows.Forms.Button UX_AddButton;
        private System.Windows.Forms.DataGridView uxTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

