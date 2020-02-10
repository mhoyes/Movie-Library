using System.Collections.Generic;
using System.Windows.Forms;

namespace Movie_Library
{
    partial class MovieForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.ComedyTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.MovieTabs = new System.Windows.Forms.TabControl();
            this.AllMovies = new System.Windows.Forms.TabPage();
            this.AllMovies_ListView = new System.Windows.Forms.ListView();
            this.ID_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ByGenre = new System.Windows.Forms.TabPage();
            this.AllGenresTab = new System.Windows.Forms.TabControl();
            this.ActionTab = new System.Windows.Forms.TabPage();
            this.Action_ListView = new System.Windows.Forms.ListView();
            this.ActionIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdventureTab = new System.Windows.Forms.TabPage();
            this.Adventure_ListView = new System.Windows.Forms.ListView();
            this.AdventureIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdventureTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnimationTab = new System.Windows.Forms.TabPage();
            this.Animation_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComedyTab = new System.Windows.Forms.TabPage();
            this.Comedy_ListView = new System.Windows.Forms.ListView();
            this.ComedyIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HorrorTab = new System.Windows.Forms.TabPage();
            this.Horror_ListView = new System.Windows.Forms.ListView();
            this.HorrorIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HorrorTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RomanceTab = new System.Windows.Forms.TabPage();
            this.Romance_ListView = new System.Windows.Forms.ListView();
            this.RomanceIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RomanceTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SciFi = new System.Windows.Forms.TabPage();
            this.SciFi_ListView = new System.Windows.Forms.ListView();
            this.SciFiIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SciFiTitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThrillerTab = new System.Windows.Forms.TabPage();
            this.Thriller_ListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Movie_LibraryLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randomMovieBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.randomGenreBox = new System.Windows.Forms.ComboBox();
            this.NewMovieGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.discTypeComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearDataStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MovieTabs.SuspendLayout();
            this.AllMovies.SuspendLayout();
            this.ByGenre.SuspendLayout();
            this.AllGenresTab.SuspendLayout();
            this.ActionTab.SuspendLayout();
            this.AdventureTab.SuspendLayout();
            this.AnimationTab.SuspendLayout();
            this.ComedyTab.SuspendLayout();
            this.HorrorTab.SuspendLayout();
            this.RomanceTab.SuspendLayout();
            this.SciFi.SuspendLayout();
            this.ThrillerTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.NewMovieGroup.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComedyTitleColumn
            // 
            this.ComedyTitleColumn.Text = "Title";
            this.ComedyTitleColumn.Width = 439;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMovieToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 48);
            // 
            // editMovieToolStripMenuItem
            // 
            this.editMovieToolStripMenuItem.Name = "editMovieToolStripMenuItem";
            this.editMovieToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.editMovieToolStripMenuItem.Text = "Edit Movie";
            this.editMovieToolStripMenuItem.Click += new System.EventHandler(this.editMovieToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.MovieTabs);
            this.panel1.Location = new System.Drawing.Point(209, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 559);
            this.panel1.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(519, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(48, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchButton_KeyDown);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(378, 18);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(140, 20);
            this.searchBox.TabIndex = 11;
            this.searchBox.Text = "Search for movie...";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // MovieTabs
            // 
            this.MovieTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieTabs.Controls.Add(this.AllMovies);
            this.MovieTabs.Controls.Add(this.ByGenre);
            this.MovieTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.MovieTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTabs.Location = new System.Drawing.Point(3, 20);
            this.MovieTabs.Multiline = true;
            this.MovieTabs.Name = "MovieTabs";
            this.MovieTabs.SelectedIndex = 0;
            this.MovieTabs.Size = new System.Drawing.Size(569, 539);
            this.MovieTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MovieTabs.TabIndex = 3;
            this.MovieTabs.SelectedIndexChanged += new System.EventHandler(this.MovieTabs_SelectedIndexChanged);
            this.MovieTabs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MovieTabs_KeyDown);
            // 
            // AllMovies
            // 
            this.AllMovies.Controls.Add(this.AllMovies_ListView);
            this.AllMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllMovies.Location = new System.Drawing.Point(4, 25);
            this.AllMovies.Name = "AllMovies";
            this.AllMovies.Padding = new System.Windows.Forms.Padding(3);
            this.AllMovies.Size = new System.Drawing.Size(561, 510);
            this.AllMovies.TabIndex = 0;
            this.AllMovies.Text = "All Movies";
            this.AllMovies.UseVisualStyleBackColor = true;
            // 
            // AllMovies_ListView
            // 
            this.AllMovies_ListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.AllMovies_ListView.BackColor = System.Drawing.SystemColors.Window;
            this.AllMovies_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Column,
            this.Title_Column,
            this.Genre_Column});
            this.AllMovies_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllMovies_ListView.FullRowSelect = true;
            this.AllMovies_ListView.GridLines = true;
            this.AllMovies_ListView.HideSelection = false;
            this.AllMovies_ListView.Location = new System.Drawing.Point(7, 7);
            this.AllMovies_ListView.Name = "AllMovies_ListView";
            this.AllMovies_ListView.ShowGroups = false;
            this.AllMovies_ListView.Size = new System.Drawing.Size(543, 500);
            this.AllMovies_ListView.TabIndex = 11;
            this.AllMovies_ListView.UseCompatibleStateImageBehavior = false;
            this.AllMovies_ListView.View = System.Windows.Forms.View.Details;
            this.AllMovies_ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.AllMovies_ListView_ColumnClick);
            this.AllMovies_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.AllMovies_ListView_ColumnWidthChanging);
            this.AllMovies_ListView.DoubleClick += new System.EventHandler(this.AllMovies_ListView_DoubleClick);
            this.AllMovies_ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllMovies_ListView_KeyDown);
            this.AllMovies_ListView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllMovies_ListView_KeyPress);
            this.AllMovies_ListView.Leave += new System.EventHandler(this.AllMovies_ListView_Leave);
            this.AllMovies_ListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AllMovies_ListView_MouseUp);
            // 
            // ID_Column
            // 
            this.ID_Column.Text = "ID";
            this.ID_Column.Width = 82;
            // 
            // Title_Column
            // 
            this.Title_Column.Text = "Title";
            this.Title_Column.Width = 334;
            // 
            // Genre_Column
            // 
            this.Genre_Column.Text = "Genre";
            this.Genre_Column.Width = 123;
            // 
            // ByGenre
            // 
            this.ByGenre.Controls.Add(this.AllGenresTab);
            this.ByGenre.Location = new System.Drawing.Point(4, 25);
            this.ByGenre.Name = "ByGenre";
            this.ByGenre.Padding = new System.Windows.Forms.Padding(3);
            this.ByGenre.Size = new System.Drawing.Size(561, 510);
            this.ByGenre.TabIndex = 1;
            this.ByGenre.Text = "By Genre";
            this.ByGenre.UseVisualStyleBackColor = true;
            // 
            // AllGenresTab
            // 
            this.AllGenresTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllGenresTab.Controls.Add(this.ActionTab);
            this.AllGenresTab.Controls.Add(this.AdventureTab);
            this.AllGenresTab.Controls.Add(this.AnimationTab);
            this.AllGenresTab.Controls.Add(this.ComedyTab);
            this.AllGenresTab.Controls.Add(this.HorrorTab);
            this.AllGenresTab.Controls.Add(this.RomanceTab);
            this.AllGenresTab.Controls.Add(this.SciFi);
            this.AllGenresTab.Controls.Add(this.ThrillerTab);
            this.AllGenresTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllGenresTab.Location = new System.Drawing.Point(3, 6);
            this.AllGenresTab.Name = "AllGenresTab";
            this.AllGenresTab.SelectedIndex = 0;
            this.AllGenresTab.Size = new System.Drawing.Size(551, 501);
            this.AllGenresTab.TabIndex = 0;
            this.AllGenresTab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllGenresTab_KeyDown);
            // 
            // ActionTab
            // 
            this.ActionTab.Controls.Add(this.Action_ListView);
            this.ActionTab.Location = new System.Drawing.Point(4, 25);
            this.ActionTab.Name = "ActionTab";
            this.ActionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActionTab.Size = new System.Drawing.Size(543, 472);
            this.ActionTab.TabIndex = 1;
            this.ActionTab.Text = "Action";
            this.ActionTab.UseVisualStyleBackColor = true;
            // 
            // Action_ListView
            // 
            this.Action_ListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Action_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActionIDColumn,
            this.ActionTitleColumn});
            this.Action_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Action_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Action_ListView.FullRowSelect = true;
            this.Action_ListView.GridLines = true;
            this.Action_ListView.HideSelection = false;
            this.Action_ListView.Location = new System.Drawing.Point(3, 6);
            this.Action_ListView.Name = "Action_ListView";
            this.Action_ListView.ShowGroups = false;
            this.Action_ListView.Size = new System.Drawing.Size(537, 463);
            this.Action_ListView.TabIndex = 12;
            this.Action_ListView.UseCompatibleStateImageBehavior = false;
            this.Action_ListView.View = System.Windows.Forms.View.Details;
            this.Action_ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Action_ListView_ColumnClick);
            this.Action_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Action_ListView_ColumnWidthChanging);
            this.Action_ListView.DoubleClick += new System.EventHandler(this.Action_ListView_DoubleClick);
            this.Action_ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Action_ListView_KeyDown);
            this.Action_ListView.Leave += new System.EventHandler(this.Action_ListView_Leave);
            this.Action_ListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Action_ListView_MouseUp);
            // 
            // ActionIDColumn
            // 
            this.ActionIDColumn.Text = "ID";
            this.ActionIDColumn.Width = 94;
            // 
            // ActionTitleColumn
            // 
            this.ActionTitleColumn.Text = "Title";
            this.ActionTitleColumn.Width = 439;
            // 
            // AdventureTab
            // 
            this.AdventureTab.Controls.Add(this.Adventure_ListView);
            this.AdventureTab.Location = new System.Drawing.Point(4, 25);
            this.AdventureTab.Name = "AdventureTab";
            this.AdventureTab.Size = new System.Drawing.Size(543, 472);
            this.AdventureTab.TabIndex = 2;
            this.AdventureTab.Text = "Adventure";
            this.AdventureTab.UseVisualStyleBackColor = true;
            // 
            // Adventure_ListView
            // 
            this.Adventure_ListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Adventure_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AdventureIDColumn,
            this.AdventureTitleColumn});
            this.Adventure_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adventure_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adventure_ListView.FullRowSelect = true;
            this.Adventure_ListView.GridLines = true;
            this.Adventure_ListView.HideSelection = false;
            this.Adventure_ListView.Location = new System.Drawing.Point(3, 6);
            this.Adventure_ListView.Name = "Adventure_ListView";
            this.Adventure_ListView.ShowGroups = false;
            this.Adventure_ListView.Size = new System.Drawing.Size(537, 463);
            this.Adventure_ListView.TabIndex = 13;
            this.Adventure_ListView.UseCompatibleStateImageBehavior = false;
            this.Adventure_ListView.View = System.Windows.Forms.View.Details;
            this.Adventure_ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Adventure_ListView_ColumnClick);
            this.Adventure_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Adventure_ListView_ColumnWidthChanging);
            this.Adventure_ListView.DoubleClick += new System.EventHandler(this.Adventure_ListView_DoubleClick);
            this.Adventure_ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Adventure_ListView_KeyDown);
            this.Adventure_ListView.Leave += new System.EventHandler(this.Adventure_ListView_Leave);
            this.Adventure_ListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Adventure_ListView_MouseUp);
            // 
            // AdventureIDColumn
            // 
            this.AdventureIDColumn.Text = "ID";
            this.AdventureIDColumn.Width = 94;
            // 
            // AdventureTitleColumn
            // 
            this.AdventureTitleColumn.Text = "Title";
            this.AdventureTitleColumn.Width = 439;
            // 
            // AnimationTab
            // 
            this.AnimationTab.Controls.Add(this.Animation_ListView);
            this.AnimationTab.Location = new System.Drawing.Point(4, 25);
            this.AnimationTab.Name = "AnimationTab";
            this.AnimationTab.Size = new System.Drawing.Size(543, 472);
            this.AnimationTab.TabIndex = 6;
            this.AnimationTab.Text = "Animation";
            this.AnimationTab.UseVisualStyleBackColor = true;
            // 
            // Animation_ListView
            // 
            this.Animation_ListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Animation_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Animation_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animation_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animation_ListView.FullRowSelect = true;
            this.Animation_ListView.GridLines = true;
            this.Animation_ListView.HideSelection = false;
            this.Animation_ListView.Location = new System.Drawing.Point(3, 6);
            this.Animation_ListView.Name = "Animation_ListView";
            this.Animation_ListView.ShowGroups = false;
            this.Animation_ListView.Size = new System.Drawing.Size(537, 463);
            this.Animation_ListView.TabIndex = 14;
            this.Animation_ListView.UseCompatibleStateImageBehavior = false;
            this.Animation_ListView.View = System.Windows.Forms.View.Details;
            this.Animation_ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Animation_ListView_ColumnClick);
            this.Animation_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Animation_ListView_ColumnWidthChanging);
            this.Animation_ListView.DoubleClick += new System.EventHandler(this.Animation_ListView_DoubleClick);
            this.Animation_ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Animation_ListView_KeyDown);
            this.Animation_ListView.Leave += new System.EventHandler(this.Animation_ListView_Leave);
            this.Animation_ListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Animation_ListView_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 439;
            // 
            // ComedyTab
            // 
            this.ComedyTab.Controls.Add(this.Comedy_ListView);
            this.ComedyTab.Location = new System.Drawing.Point(4, 25);
            this.ComedyTab.Name = "ComedyTab";
            this.ComedyTab.Padding = new System.Windows.Forms.Padding(3);
            this.ComedyTab.Size = new System.Drawing.Size(543, 472);
            this.ComedyTab.TabIndex = 0;
            this.ComedyTab.Text = "Comedy";
            this.ComedyTab.UseVisualStyleBackColor = true;
            // 
            // Comedy_ListView
            // 
            this.Comedy_ListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Comedy_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ComedyIDColumn,
            this.ComedyTitleColumn});
            this.Comedy_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Comedy_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comedy_ListView.FullRowSelect = true;
            this.Comedy_ListView.GridLines = true;
            this.Comedy_ListView.HideSelection = false;
            this.Comedy_ListView.Location = new System.Drawing.Point(3, 6);
            this.Comedy_ListView.Name = "Comedy_ListView";
            this.Comedy_ListView.ShowGroups = false;
            this.Comedy_ListView.Size = new System.Drawing.Size(537, 463);
            this.Comedy_ListView.TabIndex = 14;
            this.Comedy_ListView.UseCompatibleStateImageBehavior = false;
            this.Comedy_ListView.View = System.Windows.Forms.View.Details;
            this.Comedy_ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Comedy_ListView_ColumnClick);
            this.Comedy_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Comedy_ListView_ColumnWidthChanging);
            this.Comedy_ListView.DoubleClick += new System.EventHandler(this.Comedy_ListView_DoubleClick);
            this.Comedy_ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Comedy_ListView_KeyDown);
            this.Comedy_ListView.Leave += new System.EventHandler(this.Comedy_ListView_Leave);
            this.Comedy_ListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Comedy_ListView_MouseUp);
            // 
            // ComedyIDColumn
            // 
            this.ComedyIDColumn.Text = "ID";
            this.ComedyIDColumn.Width = 94;
            // 
            // HorrorTab
            // 
            this.HorrorTab.Controls.Add(this.Horror_ListView);
            this.HorrorTab.Location = new System.Drawing.Point(4, 25);
            this.HorrorTab.Name = "HorrorTab";
            this.HorrorTab.Size = new System.Drawing.Size(543, 472);
            this.HorrorTab.TabIndex = 3;
            this.HorrorTab.Text = "Horror";
            this.HorrorTab.UseVisualStyleBackColor = true;
            // 
            // Horror_ListView
            // 
            this.Horror_ListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Horror_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HorrorIDColumn,
            this.HorrorTitleColumn});
            this.Horror_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Horror_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horror_ListView.FullRowSelect = true;
            this.Horror_ListView.GridLines = true;
            this.Horror_ListView.HideSelection = false;
            this.Horror_ListView.Location = new System.Drawing.Point(3, 6);
            this.Horror_ListView.Name = "Horror_ListView";
            this.Horror_ListView.ShowGroups = false;
            this.Horror_ListView.Size = new System.Drawing.Size(537, 463);
            this.Horror_ListView.TabIndex = 23;
            this.Horror_ListView.UseCompatibleStateImageBehavior = false;
            this.Horror_ListView.View = System.Windows.Forms.View.Details;
            this.Horror_ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Horror_ListView_ColumnClick);
            this.Horror_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Horror_ListView_ColumnWidthChanging);
            this.Horror_ListView.DoubleClick += new System.EventHandler(this.Horror_ListView_DoubleClick);
            this.Horror_ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Horror_ListView_KeyDown);
            this.Horror_ListView.Leave += new System.EventHandler(this.Horror_ListView_Leave);
            this.Horror_ListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Horror_ListView_MouseUp);
            // 
            // HorrorIDColumn
            // 
            this.HorrorIDColumn.Text = "ID";
            this.HorrorIDColumn.Width = 94;
            // 
            // HorrorTitleColumn
            // 
            this.HorrorTitleColumn.Text = "Title";
            this.HorrorTitleColumn.Width = 439;
            // 
            // RomanceTab
            // 
            this.RomanceTab.Controls.Add(this.Romance_ListView);
            this.RomanceTab.Location = new System.Drawing.Point(4, 25);
            this.RomanceTab.Name = "RomanceTab";
            this.RomanceTab.Size = new System.Drawing.Size(543, 472);
            this.RomanceTab.TabIndex = 4;
            this.RomanceTab.Text = "Romance";
            this.RomanceTab.UseVisualStyleBackColor = true;
            // 
            // Romance_ListView
            // 
            this.Romance_ListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Romance_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RomanceIDColumn,
            this.RomanceTitleColumn});
            this.Romance_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Romance_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Romance_ListView.FullRowSelect = true;
            this.Romance_ListView.GridLines = true;
            this.Romance_ListView.HideSelection = false;
            this.Romance_ListView.Location = new System.Drawing.Point(3, 6);
            this.Romance_ListView.Name = "Romance_ListView";
            this.Romance_ListView.ShowGroups = false;
            this.Romance_ListView.Size = new System.Drawing.Size(537, 463);
            this.Romance_ListView.TabIndex = 23;
            this.Romance_ListView.UseCompatibleStateImageBehavior = false;
            this.Romance_ListView.View = System.Windows.Forms.View.Details;
            this.Romance_ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Romance_ListView_ColumnClick);
            this.Romance_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Romance_ListView_ColumnWidthChanging);
            this.Romance_ListView.DoubleClick += new System.EventHandler(this.Romance_ListView_DoubleClick);
            this.Romance_ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Romance_ListView_KeyDown);
            this.Romance_ListView.Leave += new System.EventHandler(this.Romance_ListView_Leave);
            this.Romance_ListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Romance_ListView_MouseUp);
            // 
            // RomanceIDColumn
            // 
            this.RomanceIDColumn.Text = "ID";
            this.RomanceIDColumn.Width = 94;
            // 
            // RomanceTitleColumn
            // 
            this.RomanceTitleColumn.Text = "Title";
            this.RomanceTitleColumn.Width = 439;
            // 
            // SciFi
            // 
            this.SciFi.Controls.Add(this.SciFi_ListView);
            this.SciFi.Location = new System.Drawing.Point(4, 25);
            this.SciFi.Name = "SciFi";
            this.SciFi.Size = new System.Drawing.Size(543, 472);
            this.SciFi.TabIndex = 5;
            this.SciFi.Text = "Sci-Fi";
            this.SciFi.UseVisualStyleBackColor = true;
            // 
            // SciFi_ListView
            // 
            this.SciFi_ListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.SciFi_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SciFiIDColumn,
            this.SciFiTitleColumn});
            this.SciFi_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SciFi_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SciFi_ListView.FullRowSelect = true;
            this.SciFi_ListView.GridLines = true;
            this.SciFi_ListView.HideSelection = false;
            this.SciFi_ListView.Location = new System.Drawing.Point(3, 6);
            this.SciFi_ListView.Name = "SciFi_ListView";
            this.SciFi_ListView.ShowGroups = false;
            this.SciFi_ListView.Size = new System.Drawing.Size(537, 463);
            this.SciFi_ListView.TabIndex = 23;
            this.SciFi_ListView.UseCompatibleStateImageBehavior = false;
            this.SciFi_ListView.View = System.Windows.Forms.View.Details;
            this.SciFi_ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SciFi_ListView_ColumnClick);
            this.SciFi_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.SciFi_ListView_ColumnWidthChanging);
            this.SciFi_ListView.DoubleClick += new System.EventHandler(this.SciFi_ListView_DoubleClick);
            this.SciFi_ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SciFi_ListView_KeyDown);
            this.SciFi_ListView.Leave += new System.EventHandler(this.SciFi_ListView_Leave);
            this.SciFi_ListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SciFi_ListView_MouseUp);
            // 
            // SciFiIDColumn
            // 
            this.SciFiIDColumn.Text = "ID";
            this.SciFiIDColumn.Width = 94;
            // 
            // SciFiTitleColumn
            // 
            this.SciFiTitleColumn.Text = "Title";
            this.SciFiTitleColumn.Width = 439;
            // 
            // ThrillerTab
            // 
            this.ThrillerTab.Controls.Add(this.Thriller_ListView);
            this.ThrillerTab.Location = new System.Drawing.Point(4, 25);
            this.ThrillerTab.Name = "ThrillerTab";
            this.ThrillerTab.Size = new System.Drawing.Size(543, 472);
            this.ThrillerTab.TabIndex = 7;
            this.ThrillerTab.Text = "Thriller";
            this.ThrillerTab.UseVisualStyleBackColor = true;
            // 
            // Thriller_ListView
            // 
            this.Thriller_ListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Thriller_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.Thriller_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thriller_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thriller_ListView.FullRowSelect = true;
            this.Thriller_ListView.GridLines = true;
            this.Thriller_ListView.HideSelection = false;
            this.Thriller_ListView.Location = new System.Drawing.Point(3, 6);
            this.Thriller_ListView.Name = "Thriller_ListView";
            this.Thriller_ListView.ShowGroups = false;
            this.Thriller_ListView.Size = new System.Drawing.Size(537, 463);
            this.Thriller_ListView.TabIndex = 14;
            this.Thriller_ListView.UseCompatibleStateImageBehavior = false;
            this.Thriller_ListView.View = System.Windows.Forms.View.Details;
            this.Thriller_ListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Thriller_ListView_ColumnClick);
            this.Thriller_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Thriller_ListView_ColumnWidthChanging);
            this.Thriller_ListView.DoubleClick += new System.EventHandler(this.Thriller_ListView_DoubleClick);
            this.Thriller_ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Thriller_ListView_KeyDown);
            this.Thriller_ListView.Leave += new System.EventHandler(this.Thriller_ListView_Leave);
            this.Thriller_ListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Thriller_ListView_MouseUp);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Title";
            this.columnHeader4.Width = 439;
            // 
            // Movie_LibraryLabel
            // 
            this.Movie_LibraryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Movie_LibraryLabel.AutoSize = true;
            this.Movie_LibraryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_LibraryLabel.Location = new System.Drawing.Point(420, 4);
            this.Movie_LibraryLabel.Name = "Movie_LibraryLabel";
            this.Movie_LibraryLabel.Size = new System.Drawing.Size(155, 26);
            this.Movie_LibraryLabel.TabIndex = 2;
            this.Movie_LibraryLabel.Text = "Movie Library";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.NewMovieGroup);
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 541);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.randomMovieBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.randomGenreBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // randomMovieBtn
            // 
            this.randomMovieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomMovieBtn.Location = new System.Drawing.Point(52, 122);
            this.randomMovieBtn.Name = "randomMovieBtn";
            this.randomMovieBtn.Size = new System.Drawing.Size(100, 36);
            this.randomMovieBtn.TabIndex = 7;
            this.randomMovieBtn.Text = "Pick a movie!";
            this.randomMovieBtn.UseVisualStyleBackColor = true;
            this.randomMovieBtn.Click += new System.EventHandler(this.randomMovieBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Movie Picker";
            // 
            // randomGenreBox
            // 
            this.randomGenreBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomGenreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.randomGenreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomGenreBox.FormattingEnabled = true;
            this.randomGenreBox.Items.AddRange(new object[] {
            "Random",
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Horror",
            "Romance",
            "SciFi",
            "Thriller"});
            this.randomGenreBox.Location = new System.Drawing.Point(5, 76);
            this.randomGenreBox.Name = "randomGenreBox";
            this.randomGenreBox.Size = new System.Drawing.Size(189, 24);
            this.randomGenreBox.TabIndex = 7;
            // 
            // NewMovieGroup
            // 
            this.NewMovieGroup.Controls.Add(this.label2);
            this.NewMovieGroup.Controls.Add(this.label1);
            this.NewMovieGroup.Controls.Add(this.GenreLabel);
            this.NewMovieGroup.Controls.Add(this.discTypeComboBox);
            this.NewMovieGroup.Controls.Add(this.genreComboBox);
            this.NewMovieGroup.Controls.Add(this.movieTitleTextBox);
            this.NewMovieGroup.Controls.Add(this.AddMovieBtn);
            this.NewMovieGroup.Controls.Add(this.movieTitleLabel);
            this.NewMovieGroup.Location = new System.Drawing.Point(3, -3);
            this.NewMovieGroup.Name = "NewMovieGroup";
            this.NewMovieGroup.Size = new System.Drawing.Size(201, 300);
            this.NewMovieGroup.TabIndex = 3;
            this.NewMovieGroup.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add a Movie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Disc Type";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(73, 128);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(53, 17);
            this.GenreLabel.TabIndex = 4;
            this.GenreLabel.Text = "Genre";
            // 
            // discTypeComboBox
            // 
            this.discTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discTypeComboBox.FormattingEnabled = true;
            this.discTypeComboBox.Items.AddRange(new object[] {
            "DVD",
            "BluRay",
            "BluRay & DVD"});
            this.discTypeComboBox.Location = new System.Drawing.Point(43, 211);
            this.discTypeComboBox.Name = "discTypeComboBox";
            this.discTypeComboBox.Size = new System.Drawing.Size(124, 24);
            this.discTypeComboBox.TabIndex = 5;
            this.discTypeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discTypeComboBox_KeyDown);
            this.discTypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discTypeComboBox_KeyPress);
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
            "SciFi",
            "Thriller"});
            this.genreComboBox.Location = new System.Drawing.Point(6, 148);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(189, 24);
            this.genreComboBox.TabIndex = 3;
            this.genreComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genreComboBox_KeyDown);
            this.genreComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genreComboBox_KeyPress);
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleTextBox.Location = new System.Drawing.Point(5, 82);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(190, 23);
            this.movieTitleTextBox.TabIndex = 2;
            this.movieTitleTextBox.Text = "Enter Movie Title";
            this.movieTitleTextBox.Click += new System.EventHandler(this.movieTitleTextBox_Click);
            this.movieTitleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.movieTitleTextBox_KeyDown);
            this.movieTitleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.movieTitleTextBox_KeyPress);
            this.movieTitleTextBox.Leave += new System.EventHandler(this.movieTitleTextBox_Leave);
            // 
            // AddMovieBtn
            // 
            this.AddMovieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMovieBtn.Location = new System.Drawing.Point(53, 258);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(100, 36);
            this.AddMovieBtn.TabIndex = 0;
            this.AddMovieBtn.Text = "Add Movie";
            this.AddMovieBtn.UseVisualStyleBackColor = true;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddMovieBtn_Click);
            this.AddMovieBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddMovieBtn_KeyDown);
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleLabel.Location = new System.Drawing.Point(55, 62);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(87, 17);
            this.movieTitleLabel.TabIndex = 1;
            this.movieTitleLabel.Text = "Movie Title";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStrip,
            this.AboutStrip,
            this.OptionsStrip});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileStrip
            // 
            this.FileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveStrip,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.FileStrip.Name = "FileStrip";
            this.FileStrip.Size = new System.Drawing.Size(37, 20);
            this.FileStrip.Text = "File";
            // 
            // SaveStrip
            // 
            this.SaveStrip.Name = "SaveStrip";
            this.SaveStrip.ShortcutKeyDisplayString = "(Ctrl + S)";
            this.SaveStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveStrip.Size = new System.Drawing.Size(152, 22);
            this.SaveStrip.Text = "Save";
            this.SaveStrip.Click += new System.EventHandler(this.SaveStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AboutStrip
            // 
            this.AboutStrip.Name = "AboutStrip";
            this.AboutStrip.Size = new System.Drawing.Size(52, 20);
            this.AboutStrip.Text = "About";
            this.AboutStrip.Click += new System.EventHandler(this.AboutStrip_Click);
            // 
            // OptionsStrip
            // 
            this.OptionsStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearDataStrip});
            this.OptionsStrip.Name = "OptionsStrip";
            this.OptionsStrip.Size = new System.Drawing.Size(61, 20);
            this.OptionsStrip.Text = "Options";
            // 
            // ClearDataStrip
            // 
            this.ClearDataStrip.Name = "ClearDataStrip";
            this.ClearDataStrip.Size = new System.Drawing.Size(128, 22);
            this.ClearDataStrip.Text = "Clear Data";
            this.ClearDataStrip.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.xml";
            this.saveFileDialog1.FilterIndex = 2;
            this.saveFileDialog1.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio 10.0\\Common7\\IDE";
            this.saveFileDialog1.Title = "Save Movie Library";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Movie_LibraryLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovieForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MovieForm_Shown);
            this.LocationChanged += new System.EventHandler(this.MovieForm_LocationChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MovieTabs.ResumeLayout(false);
            this.AllMovies.ResumeLayout(false);
            this.ByGenre.ResumeLayout(false);
            this.AllGenresTab.ResumeLayout(false);
            this.ActionTab.ResumeLayout(false);
            this.AdventureTab.ResumeLayout(false);
            this.AnimationTab.ResumeLayout(false);
            this.ComedyTab.ResumeLayout(false);
            this.HorrorTab.ResumeLayout(false);
            this.RomanceTab.ResumeLayout(false);
            this.SciFi.ResumeLayout(false);
            this.ThrillerTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.NewMovieGroup.ResumeLayout(false);
            this.NewMovieGroup.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Movie_LibraryLabel;
        private System.Windows.Forms.TabControl MovieTabs;
        private System.Windows.Forms.TabPage AllMovies;
        private System.Windows.Forms.TabPage ByGenre;
        private System.Windows.Forms.TabControl AllGenresTab;
        private System.Windows.Forms.TabPage ActionTab;
        private System.Windows.Forms.TabPage AdventureTab;
        private System.Windows.Forms.TabPage ComedyTab;
        private System.Windows.Forms.TabPage HorrorTab;
        private System.Windows.Forms.TabPage RomanceTab;
        private System.Windows.Forms.TabPage SciFi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox NewMovieGroup;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Button AddMovieBtn;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutStrip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem OptionsStrip;
        private ToolStripMenuItem ClearDataStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button searchButton;
        private TextBox searchBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editMovieToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ListView AllMovies_ListView;
        private ColumnHeader ID_Column;
        private ColumnHeader Title_Column;
        private ColumnHeader Genre_Column;
        private ListView Action_ListView;
        private ColumnHeader ActionIDColumn;
        private ColumnHeader ActionTitleColumn;
        private ListView Adventure_ListView;
        private ColumnHeader AdventureIDColumn;
        private ColumnHeader AdventureTitleColumn;
        private ListView Comedy_ListView;
        private ColumnHeader ComedyIDColumn;
        private ListView Horror_ListView;
        private ColumnHeader HorrorIDColumn;
        private ListView Romance_ListView;
        private ColumnHeader RomanceIDColumn;
        private ColumnHeader RomanceTitleColumn;
        private ListView SciFi_ListView;
        private ColumnHeader SciFiIDColumn;
        private ColumnHeader SciFiTitleColumn;
        public ColumnHeader HorrorTitleColumn;
        private TabPage AnimationTab;
        private TabPage ThrillerTab;
        private ListView Animation_ListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView Thriller_ListView;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox discTypeComboBox;
        private Label label1;
        private GroupBox groupBox1;
        private Button randomMovieBtn;
        private Label label4;
        private Label label3;
        private ComboBox randomGenreBox;
        private Label label2;
        private ColumnHeader ComedyTitleColumn;
    }
}

