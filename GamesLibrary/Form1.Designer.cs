namespace GamesLibrary
{
    partial class Form1
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
            this.UX_RatingButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UX_ConsoleCheckBox = new System.Windows.Forms.CheckedListBox();
            this.UX_GenreDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UX_RatingButton
            // 
            this.UX_RatingButton.Location = new System.Drawing.Point(139, 24);
            this.UX_RatingButton.Name = "UX_RatingButton";
            this.UX_RatingButton.Size = new System.Drawing.Size(75, 23);
            this.UX_RatingButton.TabIndex = 1;
            this.UX_RatingButton.Text = "Rating";
            this.UX_RatingButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(339, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(779, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(618, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 368);
            this.dataGridView1.TabIndex = 7;
            // 
            // UX_ConsoleCheckBox
            // 
            this.UX_ConsoleCheckBox.FormattingEnabled = true;
            this.UX_ConsoleCheckBox.Location = new System.Drawing.Point(714, 76);
            this.UX_ConsoleCheckBox.Name = "UX_ConsoleCheckBox";
            this.UX_ConsoleCheckBox.Size = new System.Drawing.Size(120, 94);
            this.UX_ConsoleCheckBox.TabIndex = 8;
            this.UX_ConsoleCheckBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // UX_GenreDropDown
            // 
            this.UX_GenreDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UX_GenreDropDown.FormattingEnabled = true;
            this.UX_GenreDropDown.Location = new System.Drawing.Point(23, 25);
            this.UX_GenreDropDown.Name = "UX_GenreDropDown";
            this.UX_GenreDropDown.Size = new System.Drawing.Size(97, 21);
            this.UX_GenreDropDown.TabIndex = 9;
            this.UX_GenreDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 492);
            this.Controls.Add(this.UX_GenreDropDown);
            this.Controls.Add(this.UX_ConsoleCheckBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UX_RatingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UX_RatingButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox UX_ConsoleCheckBox;
        private System.Windows.Forms.ComboBox UX_GenreDropDown;
    }
}

