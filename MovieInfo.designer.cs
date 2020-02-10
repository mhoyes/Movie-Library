namespace Movie_Library
{
    partial class MovieInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.Panel();
            this.discTypeTextBox = new System.Windows.Forms.TextBox();
            this.discTypeLabel = new System.Windows.Forms.Label();
            this.genreTextbox = new System.Windows.Forms.TextBox();
            this.movieLength_MinutesLabel = new System.Windows.Forms.Label();
            this.movieLength_HoursLabel = new System.Windows.Forms.Label();
            this.movieLength_Minutes = new System.Windows.Forms.NumericUpDown();
            this.movieLength_Hours = new System.Windows.Forms.NumericUpDown();
            this.releaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.NumericUpDown();
            this.actorsLabel = new System.Windows.Forms.Label();
            this.actorsTextBox = new System.Windows.Forms.TextBox();
            this.writersLabel = new System.Windows.Forms.Label();
            this.writersTextBox = new System.Windows.Forms.TextBox();
            this.directorsLabel = new System.Windows.Forms.Label();
            this.directorsTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.movieLengthLabel = new System.Windows.Forms.Label();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.movieDescriptionLabel = new System.Windows.Forms.Label();
            this.movieDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieLength_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieLength_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Controls.Add(this.discTypeTextBox);
            this.tableLayoutPanel.Controls.Add(this.discTypeLabel);
            this.tableLayoutPanel.Controls.Add(this.genreTextbox);
            this.tableLayoutPanel.Controls.Add(this.movieLength_MinutesLabel);
            this.tableLayoutPanel.Controls.Add(this.movieLength_HoursLabel);
            this.tableLayoutPanel.Controls.Add(this.movieLength_Minutes);
            this.tableLayoutPanel.Controls.Add(this.movieLength_Hours);
            this.tableLayoutPanel.Controls.Add(this.releaseDatePicker);
            this.tableLayoutPanel.Controls.Add(this.ratingComboBox);
            this.tableLayoutPanel.Controls.Add(this.genreComboBox);
            this.tableLayoutPanel.Controls.Add(this.yearBox);
            this.tableLayoutPanel.Controls.Add(this.actorsLabel);
            this.tableLayoutPanel.Controls.Add(this.actorsTextBox);
            this.tableLayoutPanel.Controls.Add(this.writersLabel);
            this.tableLayoutPanel.Controls.Add(this.writersTextBox);
            this.tableLayoutPanel.Controls.Add(this.directorsLabel);
            this.tableLayoutPanel.Controls.Add(this.directorsTextBox);
            this.tableLayoutPanel.Controls.Add(this.IDLabel);
            this.tableLayoutPanel.Controls.Add(this.IDTextBox);
            this.tableLayoutPanel.Controls.Add(this.movieLengthLabel);
            this.tableLayoutPanel.Controls.Add(this.releaseDateLabel);
            this.tableLayoutPanel.Controls.Add(this.genreLabel);
            this.tableLayoutPanel.Controls.Add(this.ratingLabel);
            this.tableLayoutPanel.Controls.Add(this.label1);
            this.tableLayoutPanel.Controls.Add(this.yearLabel);
            this.tableLayoutPanel.Controls.Add(this.movieTitleTextBox);
            this.tableLayoutPanel.Controls.Add(this.movieDescriptionLabel);
            this.tableLayoutPanel.Controls.Add(this.movieDescriptionTextBox);
            this.tableLayoutPanel.Controls.Add(this.pictureBox1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(4, 31);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Size = new System.Drawing.Size(579, 408);
            this.tableLayoutPanel.TabIndex = 1;
            this.tableLayoutPanel.Click += new System.EventHandler(this.tableLayoutPanel_Click);
            // 
            // discTypeTextBox
            // 
            this.discTypeTextBox.Location = new System.Drawing.Point(269, 71);
            this.discTypeTextBox.Name = "discTypeTextBox";
            this.discTypeTextBox.ReadOnly = true;
            this.discTypeTextBox.Size = new System.Drawing.Size(106, 20);
            this.discTypeTextBox.TabIndex = 37;
            // 
            // discTypeLabel
            // 
            this.discTypeLabel.AutoSize = true;
            this.discTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discTypeLabel.Location = new System.Drawing.Point(266, 55);
            this.discTypeLabel.Name = "discTypeLabel";
            this.discTypeLabel.Size = new System.Drawing.Size(64, 13);
            this.discTypeLabel.TabIndex = 36;
            this.discTypeLabel.Text = "Disc Type";
            // 
            // genreTextbox
            // 
            this.genreTextbox.Location = new System.Drawing.Point(152, 71);
            this.genreTextbox.Name = "genreTextbox";
            this.genreTextbox.ReadOnly = true;
            this.genreTextbox.Size = new System.Drawing.Size(106, 20);
            this.genreTextbox.TabIndex = 35;
            // 
            // movieLength_MinutesLabel
            // 
            this.movieLength_MinutesLabel.AutoSize = true;
            this.movieLength_MinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLength_MinutesLabel.Location = new System.Drawing.Point(436, 150);
            this.movieLength_MinutesLabel.Name = "movieLength_MinutesLabel";
            this.movieLength_MinutesLabel.Size = new System.Drawing.Size(44, 13);
            this.movieLength_MinutesLabel.TabIndex = 34;
            this.movieLength_MinutesLabel.Text = "Minutes";
            // 
            // movieLength_HoursLabel
            // 
            this.movieLength_HoursLabel.AutoSize = true;
            this.movieLength_HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLength_HoursLabel.Location = new System.Drawing.Point(394, 150);
            this.movieLength_HoursLabel.Name = "movieLength_HoursLabel";
            this.movieLength_HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.movieLength_HoursLabel.TabIndex = 33;
            this.movieLength_HoursLabel.Text = "Hours";
            // 
            // movieLength_Minutes
            // 
            this.movieLength_Minutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movieLength_Minutes.Location = new System.Drawing.Point(436, 127);
            this.movieLength_Minutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.movieLength_Minutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.movieLength_Minutes.Name = "movieLength_Minutes";
            this.movieLength_Minutes.Size = new System.Drawing.Size(46, 20);
            this.movieLength_Minutes.TabIndex = 32;
            this.movieLength_Minutes.ValueChanged += new System.EventHandler(this.movieLenght_Minutes_ValueChanged);
            // 
            // movieLength_Hours
            // 
            this.movieLength_Hours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movieLength_Hours.Location = new System.Drawing.Point(397, 127);
            this.movieLength_Hours.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.movieLength_Hours.Name = "movieLength_Hours";
            this.movieLength_Hours.Size = new System.Drawing.Size(31, 20);
            this.movieLength_Hours.TabIndex = 31;
            this.movieLength_Hours.ValueChanged += new System.EventHandler(this.movieLength_Hours_ValueChanged);
            // 
            // releaseDatePicker
            // 
            this.releaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.releaseDatePicker.Location = new System.Drawing.Point(269, 127);
            this.releaseDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.releaseDatePicker.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.releaseDatePicker.Name = "releaseDatePicker";
            this.releaseDatePicker.Size = new System.Drawing.Size(102, 20);
            this.releaseDatePicker.TabIndex = 30;
            this.releaseDatePicker.ValueChanged += new System.EventHandler(this.releaseDatePicker_ValueChanged);
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ratingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "None",
            "G",
            "PG",
            "PG13",
            "R",
            "NC-17"});
            this.ratingComboBox.Location = new System.Drawing.Point(396, 71);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(59, 24);
            this.ratingComboBox.TabIndex = 29;
            this.ratingComboBox.SelectedIndexChanged += new System.EventHandler(this.ratingComboBox_SelectedIndexChanged);
            // 
            // genreComboBox
            // 
            this.genreComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "None",
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Horror",
            "Romance",
            "Sci-Fi",
            "Thriller"});
            this.genreComboBox.Location = new System.Drawing.Point(153, 92);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(101, 24);
            this.genreComboBox.TabIndex = 28;
            this.genreComboBox.Visible = false;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // yearBox
            // 
            this.yearBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearBox.Location = new System.Drawing.Point(501, 71);
            this.yearBox.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.yearBox.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(52, 20);
            this.yearBox.TabIndex = 27;
            this.yearBox.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.yearBox.ValueChanged += new System.EventHandler(this.yearBox_ValueChanged);
            // 
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorsLabel.Location = new System.Drawing.Point(392, 198);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(43, 13);
            this.actorsLabel.TabIndex = 26;
            this.actorsLabel.Text = "Actors";
            // 
            // actorsTextBox
            // 
            this.actorsTextBox.Location = new System.Drawing.Point(394, 214);
            this.actorsTextBox.Multiline = true;
            this.actorsTextBox.Name = "actorsTextBox";
            this.actorsTextBox.Size = new System.Drawing.Size(173, 64);
            this.actorsTextBox.TabIndex = 25;
            this.actorsTextBox.Text = "Enter actors here...";
            this.actorsTextBox.Click += new System.EventHandler(this.actorsTextBox_Click);
            this.actorsTextBox.TextChanged += new System.EventHandler(this.actorsTextBox_TextChanged);
            this.actorsTextBox.Enter += new System.EventHandler(this.actorsTextBox_Enter);
            this.actorsTextBox.Leave += new System.EventHandler(this.actorsTextBox_Leave);
            // 
            // writersLabel
            // 
            this.writersLabel.AutoSize = true;
            this.writersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writersLabel.Location = new System.Drawing.Point(199, 198);
            this.writersLabel.Name = "writersLabel";
            this.writersLabel.Size = new System.Drawing.Size(55, 13);
            this.writersLabel.TabIndex = 24;
            this.writersLabel.Text = "Writer(s)";
            // 
            // writersTextBox
            // 
            this.writersTextBox.Location = new System.Drawing.Point(200, 214);
            this.writersTextBox.Multiline = true;
            this.writersTextBox.Name = "writersTextBox";
            this.writersTextBox.Size = new System.Drawing.Size(173, 64);
            this.writersTextBox.TabIndex = 23;
            this.writersTextBox.Text = "Enter writers here...";
            this.writersTextBox.Click += new System.EventHandler(this.writersTextBox_Click);
            this.writersTextBox.TextChanged += new System.EventHandler(this.writersTextBox_TextChanged);
            this.writersTextBox.Enter += new System.EventHandler(this.writersTextBox_Enter);
            this.writersTextBox.Leave += new System.EventHandler(this.writersTextBox_Leave);
            // 
            // directorsLabel
            // 
            this.directorsLabel.AutoSize = true;
            this.directorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorsLabel.Location = new System.Drawing.Point(-1, 198);
            this.directorsLabel.Name = "directorsLabel";
            this.directorsLabel.Size = new System.Drawing.Size(66, 13);
            this.directorsLabel.TabIndex = 22;
            this.directorsLabel.Text = "Director(s)";
            // 
            // directorsTextBox
            // 
            this.directorsTextBox.Location = new System.Drawing.Point(3, 214);
            this.directorsTextBox.Multiline = true;
            this.directorsTextBox.Name = "directorsTextBox";
            this.directorsTextBox.Size = new System.Drawing.Size(173, 64);
            this.directorsTextBox.TabIndex = 21;
            this.directorsTextBox.Text = "Enter directors here...";
            this.directorsTextBox.Click += new System.EventHandler(this.directorsTextBox_Click);
            this.directorsTextBox.TextChanged += new System.EventHandler(this.directorsTextBox_TextChanged);
            this.directorsTextBox.Enter += new System.EventHandler(this.directorsTextBox_Enter);
            this.directorsTextBox.Leave += new System.EventHandler(this.directorsTextBox_Leave);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(500, 5);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(20, 13);
            this.IDLabel.TabIndex = 20;
            this.IDLabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(501, 21);
            this.IDTextBox.MaxLength = 25;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(66, 20);
            this.IDTextBox.TabIndex = 19;
            // 
            // movieLengthLabel
            // 
            this.movieLengthLabel.AutoSize = true;
            this.movieLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLengthLabel.Location = new System.Drawing.Point(394, 111);
            this.movieLengthLabel.Name = "movieLengthLabel";
            this.movieLengthLabel.Size = new System.Drawing.Size(84, 13);
            this.movieLengthLabel.TabIndex = 18;
            this.movieLengthLabel.Text = "Movie Length";
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDateLabel.Location = new System.Drawing.Point(267, 111);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(84, 13);
            this.releaseDateLabel.TabIndex = 16;
            this.releaseDateLabel.Text = "Release Date";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(151, 55);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(41, 13);
            this.genreLabel.TabIndex = 14;
            this.genreLabel.Text = "Genre";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(394, 55);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(44, 13);
            this.ratingLabel.TabIndex = 12;
            this.ratingLabel.Text = "Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Movie Title";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(499, 55);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(33, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Year";
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Location = new System.Drawing.Point(153, 21);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.ReadOnly = true;
            this.movieTitleTextBox.Size = new System.Drawing.Size(329, 20);
            this.movieTitleTextBox.TabIndex = 7;
            // 
            // movieDescriptionLabel
            // 
            this.movieDescriptionLabel.AutoSize = true;
            this.movieDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDescriptionLabel.Location = new System.Drawing.Point(224, 285);
            this.movieDescriptionLabel.Name = "movieDescriptionLabel";
            this.movieDescriptionLabel.Size = new System.Drawing.Size(151, 20);
            this.movieDescriptionLabel.TabIndex = 6;
            this.movieDescriptionLabel.Text = "Movie Description";
            // 
            // movieDescriptionTextBox
            // 
            this.movieDescriptionTextBox.Location = new System.Drawing.Point(3, 308);
            this.movieDescriptionTextBox.Multiline = true;
            this.movieDescriptionTextBox.Name = "movieDescriptionTextBox";
            this.movieDescriptionTextBox.Size = new System.Drawing.Size(564, 97);
            this.movieDescriptionTextBox.TabIndex = 5;
            this.movieDescriptionTextBox.Text = "Enter movie description here...";
            this.movieDescriptionTextBox.Click += new System.EventHandler(this.movieDescriptionTextBox_Click);
            this.movieDescriptionTextBox.TextChanged += new System.EventHandler(this.movieDescriptionTextBox_TextChanged);
            this.movieDescriptionTextBox.Enter += new System.EventHandler(this.movieDescriptionTextBox_Enter);
            this.movieDescriptionTextBox.Leave += new System.EventHandler(this.movieDescriptionTextBox_Leave);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(236, 7);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(152, 20);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Movie Information";
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Close.Location = new System.Drawing.Point(249, 445);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(92, 28);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // MovieInfo
            // 
            this.AcceptButton = this.button_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 475);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MovieInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Info";
            this.Load += new System.EventHandler(this.MovieInfo_Load);
            this.Click += new System.EventHandler(this.MovieInfo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieLength_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieLength_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel tableLayoutPanel;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label movieDescriptionLabel;
        private System.Windows.Forms.TextBox movieDescriptionTextBox;
        private System.Windows.Forms.Label actorsLabel;
        private System.Windows.Forms.TextBox actorsTextBox;
        private System.Windows.Forms.Label writersLabel;
        private System.Windows.Forms.TextBox writersTextBox;
        private System.Windows.Forms.Label directorsLabel;
        private System.Windows.Forms.TextBox directorsTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label movieLengthLabel;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.NumericUpDown yearBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.DateTimePicker releaseDatePicker;
        private System.Windows.Forms.Label movieLength_MinutesLabel;
        private System.Windows.Forms.Label movieLength_HoursLabel;
        private System.Windows.Forms.NumericUpDown movieLength_Minutes;
        private System.Windows.Forms.NumericUpDown movieLength_Hours;
        private System.Windows.Forms.TextBox genreTextbox;
        private System.Windows.Forms.TextBox discTypeTextBox;
        private System.Windows.Forms.Label discTypeLabel;
    }
}