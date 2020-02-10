using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Movie_Library
{
    public partial class MovieForm : Form
    {
        #region Data Members
        public Movies movies;
        public string[] allGenres;

        private SaveStatus saveStatus = SaveStatus.Canceled;
        private LoadStatus loadStatus = LoadStatus.Canceled;

        private string fileName = "LibraryFile.xml";

        private string formTitle;
        private bool closing;

        //private int AllMovies_IDColumnSize;
        //private int AllMovies_TitleColumnSize;
        private int AllMovies_GenreColumnSize;

        //private int Action_IDColumnSize;
        private int Action_TitleColumnSize;

        //private int Adventure_IDColumnSize;
        private int Adventure_TitleColumnSize;

        //private int Adventure_IDColumnSize;
        private int Animation_TitleColumnSize;

        //private int Comedy_IDColumnSize;
        private int Comedy_TitleColumnSize;

        //private int Horror_IDColumnSize;
        private int Horror_TitleColumnSize;

        //private int Romance_IDColumnSize;
        private int Romance_TitleColumnSize;

        //private int SciFi_IDColumnSize;
        private int SciFi_TitleColumnSize;

        //private int SciFi_IDColumnSize;
        private int Thriller_TitleColumnSize;

        //private string titleColumnText;

        // Create the MovieInfo with the specific movie
        private MovieInfo movieInfo;

        private int genreEnumSize = 0;
        private int discTypeEnumSize = 0;
        #endregion

        #region Constructor
        public MovieForm()
        {
            movies = new Movies();

            genreEnumSize = Enum.GetNames(typeof(Genre)).Count();
            discTypeEnumSize = Enum.GetNames(typeof(DiscType)).Count();

            allGenres = new string[genreEnumSize - 1];

            allGenres = movies.GetGenreList();

            InitializeComponent();

            genreComboBox.SelectedIndex = 0;
            discTypeComboBox.SelectedIndex = 0;
            randomGenreBox.SelectedIndex = 0;
            
            // Create the MovieInfo with the specific movie
            movieInfo = new MovieInfo(this);

            formTitle = this.Text;
        } 
        #endregion

        #region Methods
        private void ResetAddMovieProperties()
        {
            movieTitleTextBox.Text = movies.EnterMovieTitleStr;
            genreComboBox.SelectedIndex = 0;
            discTypeComboBox.SelectedIndex = 0;
            MovieTabs.SelectedIndex = 0;
        }

        private void ResetSearchMovieProperties()
        {
            searchBox.Text = movies.SearchMovieTitleStr;
            searchBox.SelectedText = "";
            //searchBox.SelectionStart = 0;
            //panel2.Focus();
        }

        public void ReinitializeMovies()
        {
            AllMovies_ListView.Items.Clear();
            Action_ListView.Items.Clear();
            Adventure_ListView.Items.Clear();
            Animation_ListView.Items.Clear();
            Comedy_ListView.Items.Clear();
            Horror_ListView.Items.Clear();
            Romance_ListView.Items.Clear();
            SciFi_ListView.Items.Clear();
            Thriller_ListView.Items.Clear();

            int actionIndex, adventureIndex, animationIndex, comedyIndex, horrorIndex, romanceIndex, scifiIndex, thrillerIndex;
            actionIndex = adventureIndex = animationIndex = comedyIndex = horrorIndex = romanceIndex = scifiIndex = thrillerIndex = 0;

            foreach (Movie m in movies.MovieList)
            {
                string displayTitle;
                switch (m.MovieGenre)
                {
                    case Genre.Action:
                        displayTitle = /*actionIndex + ": " + */m.Title;

                        /*
                        m.ID = actionIndex;
                        string actionID = m.IDAsString;
                        m.IDAsString = "";
                        for (int i = 0; i < 3; i++) { m.IDAsString += actionID[i]; }
                        m.IDAsString += m.ID.ToString();
                        */

                        m.ID = actionIndex;//movies.GetMovieCountByGenre(m.MovieGenre);
                        m.IDAsString = movies.ReassignID(m);

                        actionIndex++;

                        ListViewItem actionItemID = new ListViewItem(m.IDAsString);
                        ListViewItem.ListViewSubItem actionSubItem_Title = new ListViewItem.ListViewSubItem(actionItemID, m.Title);

                        actionItemID.SubItems.Add(actionSubItem_Title);
                        Action_ListView.Items.Add(actionItemID);

                        break;

                    case Genre.Adventure:
                        displayTitle = /*adventureIndex + ": " + */m.Title;

                        /*
                        m.ID = adventureIndex;
                        string adventureID = m.IDAsString;
                        m.IDAsString = "";
                        for (int i = 0; i < 3; i++) { m.IDAsString += adventureID[i]; }
                        m.IDAsString += m.ID.ToString();
                        */

                        m.ID = adventureIndex;//movies.GetMovieCountByGenre(m.MovieGenre);
                        m.IDAsString = movies.ReassignID(m);

                        adventureIndex++;

                        ListViewItem adventureItemID = new ListViewItem(m.IDAsString);
                        ListViewItem.ListViewSubItem adventureSubItem_Title = new ListViewItem.ListViewSubItem(adventureItemID, m.Title);

                        adventureItemID.SubItems.Add(adventureSubItem_Title);
                        Adventure_ListView.Items.Add(adventureItemID);

                        break;

                    case Genre.Animation:
                        displayTitle = /*animationIndex + ": " + */m.Title;

                        /*
                        m.ID = animationIndex;
                        string animationID = m.IDAsString;
                        m.IDAsString = "";
                        for (int i = 0; i < 3; i++) { m.IDAsString += animationID[i]; }
                        m.IDAsString += m.ID.ToString();
                        */

                        m.ID = animationIndex;//movies.GetMovieCountByGenre(m.MovieGenre);
                        m.IDAsString = movies.ReassignID(m);

                        animationIndex++;

                        ListViewItem animationItemID = new ListViewItem(m.IDAsString);
                        ListViewItem.ListViewSubItem animationSubItem_Title = new ListViewItem.ListViewSubItem(animationItemID, m.Title);

                        animationItemID.SubItems.Add(animationSubItem_Title);
                        Animation_ListView.Items.Add(animationItemID);

                        break;

                    case Genre.Comedy:
                        displayTitle = /*comedyIndex + ": " + */m.Title;
                        /*
                        m.ID = comedyIndex;
                        string comedyID = m.IDAsString;
                        m.IDAsString = "";
                        for (int i = 0; i < 3; i++) { m.IDAsString += comedyID[i]; }
                        m.IDAsString += m.ID.ToString();
                        */

                        m.ID = comedyIndex;//movies.GetMovieCountByGenre(m.MovieGenre);
                        m.IDAsString = movies.ReassignID(m);

                        comedyIndex++;

                        ListViewItem comedyItemID = new ListViewItem(m.IDAsString);
                        ListViewItem.ListViewSubItem comedySubItem_Title = new ListViewItem.ListViewSubItem(comedyItemID, m.Title);

                        comedyItemID.SubItems.Add(comedySubItem_Title);
                        Comedy_ListView.Items.Add(comedyItemID);

                        break;

                    case Genre.Horror:
                        displayTitle = /*horrorIndex + ": " + */m.Title;

                        /*
                        m.ID = horrorIndex;
                        string horrorID = m.IDAsString;
                        m.IDAsString = "";
                        for (int i = 0; i < 3; i++) { m.IDAsString += horrorID[i]; }
                        m.IDAsString += m.ID.ToString();
                        */

                        m.ID = horrorIndex;//movies.GetMovieCountByGenre(m.MovieGenre);
                        m.IDAsString = movies.ReassignID(m);

                        horrorIndex++;

                        ListViewItem horrorItemID = new ListViewItem(m.IDAsString);
                        ListViewItem.ListViewSubItem horrorSubItem_Title = new ListViewItem.ListViewSubItem(horrorItemID, m.Title);

                        horrorItemID.SubItems.Add(horrorSubItem_Title);
                        Horror_ListView.Items.Add(horrorItemID);

                        break;

                    case Genre.Romance:
                        displayTitle = /*romanceIndex + ": " + */m.Title;

                        /*
                        m.ID = romanceIndex;
                        string romanceID = m.IDAsString;
                        m.IDAsString = "";
                        for (int i = 0; i < 3; i++) { m.IDAsString += romanceID[i]; }
                        m.IDAsString += m.ID.ToString();
                        */

                        m.ID = romanceIndex;//movies.GetMovieCountByGenre(m.MovieGenre);
                        m.IDAsString = movies.ReassignID(m);

                        romanceIndex++;

                        ListViewItem romanceItemID = new ListViewItem(m.IDAsString);
                        ListViewItem.ListViewSubItem romanceSubItem_Title = new ListViewItem.ListViewSubItem(romanceItemID, m.Title);

                        romanceItemID.SubItems.Add(romanceSubItem_Title);
                        Romance_ListView.Items.Add(romanceItemID);

                        break;

                    case Genre.SciFi:
                        displayTitle = /*scifiIndex + ": " + */m.Title;

                        /*
                        m.ID = scifiIndex;
                        string scifiID = m.IDAsString;
                        m.IDAsString = "";
                        for (int i = 0; i < 3; i++) { m.IDAsString += scifiID[i]; }
                        m.IDAsString += m.ID.ToString();
                        */

                        m.ID = scifiIndex;//movies.GetMovieCountByGenre(m.MovieGenre);
                        m.IDAsString = movies.ReassignID(m);

                        scifiIndex++;

                        ListViewItem sciFiItemID = new ListViewItem(m.IDAsString);
                        ListViewItem.ListViewSubItem sciFiSubItem_Title = new ListViewItem.ListViewSubItem(sciFiItemID, m.Title);

                        sciFiItemID.SubItems.Add(sciFiSubItem_Title);
                        SciFi_ListView.Items.Add(sciFiItemID);

                        break;

                    case Genre.Thriller:
                        displayTitle = /*thrillerIndex + ": " + */m.Title;

                        /*
                        m.ID = thrillerIndex;
                        string thrillerID = m.IDAsString;
                        m.IDAsString = "";
                        for (int i = 0; i < 3; i++) { m.IDAsString += thrillerID[i]; }
                        m.IDAsString += m.ID.ToString();
                        */

                        m.ID = thrillerIndex;//movies.GetMovieCountByGenre(m.MovieGenre);
                        m.IDAsString = movies.ReassignID(m);

                        thrillerIndex++;

                        ListViewItem thrillerItemID = new ListViewItem(m.IDAsString);
                        ListViewItem.ListViewSubItem thrillerSubItem_Title = new ListViewItem.ListViewSubItem(thrillerItemID, m.Title);

                        thrillerItemID.SubItems.Add(thrillerSubItem_Title);
                        Thriller_ListView.Items.Add(thrillerItemID);

                        break;
                }

                ListViewItem itemID = new ListViewItem(m.IDAsString);
                ListViewItem.ListViewSubItem subItem_Title = new ListViewItem.ListViewSubItem(itemID, m.Title);
                ListViewItem.ListViewSubItem subItem_Genre = new ListViewItem.ListViewSubItem(itemID, m.MovieGenre.ToString());

                itemID.SubItems.Add(subItem_Title);
                itemID.SubItems.Add(subItem_Genre);

                AllMovies_ListView.Items.Add(itemID);
            }

        }

        private void ShowLoadStatus()
        {
            if (loadStatus == LoadStatus.Loaded)
            {
                MessageBox.Show("\tLibrary loaded!         ", "Library Load Status:");
            }
            else if (loadStatus == LoadStatus.CantLoad)
            {
                MessageBox.Show("\tNo movie library exists!         \n\n\t         Enter some!", "Library Load Status:");
            }
        }

        private void ShowSaveStatus()
        {
            if (saveStatus == SaveStatus.Saved)
            {
                MessageBox.Show("\tLibrary saved!         ", "Library Save Status:");
            }
            else if (saveStatus == SaveStatus.CantSave)
            {
                MessageBox.Show("Can't save! No movies to save.", "Library Save Status:");
            }
            else if (saveStatus == SaveStatus.Canceled)
            {
                MessageBox.Show("Save canceled. No new changes.", "Library Save Status:");
            }
        }

        private void ShowMovieExists()
        {
            MessageBox.Show("\tMovie already exists!\t", "Warning: Can't duplicate!");
        }

        private void Save()
        {
            string path = System.IO.Path.GetDirectoryName(Application.StartupPath);

            bool saved = false;

            if (movies.MovieList.Count > 0)
            {
                saved = Serialization.WriteToXML<List<Movie>>(path, fileName, movies.MovieList);

                if (saved)
                {
                    saveStatus = SaveStatus.Saved;
                    this.Text = formTitle;
                }
            }
            else
            {
                DeleteFile();
            }

        }

        private LoadStatus LoadFile()
        {
            //bool loaded = false;

            LoadStatus status = LoadStatus.Canceled;

            string path = System.IO.Path.GetDirectoryName(Application.StartupPath);

            try
            {
                movies.MovieList = Serialization.ReadFromXML<List<Movie>>(path, fileName);

                ReinitializeMovies();
                //loaded = true;
                status = LoadStatus.Loaded;
            }
            catch
            {
                //loaded = false;
                status = LoadStatus.CantLoad;
            }

            return status;
        }

        private void ExitApplication()
        {
            string exitMsg = "\tAre you sure you want to exit?\t";
            string exitCaption = "Confirmation:";

            DialogResult exitResult = MessageBox.Show(exitMsg, exitCaption, MessageBoxButtons.YesNo);

            if (exitResult == System.Windows.Forms.DialogResult.Yes)
            {
                closing = true;

                if (saveStatus == SaveStatus.UnSaved)
                {
                    string saveMsg = "\tWould you like to save before exiting?             ";
                    string saveCaption = "Warning: Unsaved changes";

                    DialogResult saveResult = MessageBox.Show(saveMsg, saveCaption, MessageBoxButtons.YesNo);

                    if (saveResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                        this.saveFileDialog1.FileName = "*.xml";
                        saveFileDialog1.InitialDirectory = Application.StartupPath;

                        if (saveStatus == SaveStatus.UnSaved)
                        {
                            Save();
                        }
                    }
                }

                Application.Exit();
            }
        }

        private void ChangeListBoxSelectedIndex(ListBox listBox, int selectedID)
        {
            listBox.SelectedIndex = selectedID;
        }

        private void SearchForMovie()
        {
            bool searchTooShort = false;

            // Select AllMovies Tab as focus
            MovieTabs.SelectedIndex = 0;

            // Make sure there are movies in the list
            if (movies.MovieList.Count > 0)
            {
                // assign the text to search for
                string searchText = searchBox.Text;

                List<Movie> moviesCount = movies.GetMoviesWithText(searchText);

                // FIRST SEARCH FOR MOVIE WITH ALL SEARCHTEXT
                bool movieFound = movies.FindMovie(searchText);

                if (moviesCount.Count != 1) { movieFound = false; }

                if (movieFound)
                {
                    // Get the movie with the search text
                    Movie m = movies.GetMovie(searchText);

                    // Look through all items in ListView
                    for (int i = 0; i < AllMovies_ListView.Items.Count; i++)
                    {
                        // assign the current items movie ID
                        string itemStr = AllMovies_ListView.Items[i].Text;

                        // if the current items movie ID = the found movie ID
                        if (itemStr == m.IDAsString)
                        {
                            // Assign Focus
                            AllMovies_ListView.Focus();

                            AllMovies_ListView.HideSelection = false;
                            AllMovies_ListView.Items[i].Selected = true;
                        }
                    }

                    ResetSearchMovieProperties();
                }
                else
                {
                    bool foundMovie = movies.FindMovie(searchText);

                    List<Movie> moviesWithText = movies.GetMoviesWithText(searchText);

                    if (moviesWithText.Count > 0)
                    {
                        if (searchText.Length <= 3)
                        {
                            moviesWithText.Clear();
                            searchTooShort = true;
                        }

                    }
                    else
                    {

                        int length = searchText.Length - 1;
                        int startIndex = 0;

                        while (startIndex < searchText.Length - 1)
                        {
                            string substr = searchText.Substring(startIndex, length);

                            if (substr.Length >= 3)
                            {
                                moviesWithText = movies.GetMoviesWithText(substr);
                            }

                            if (moviesWithText.Count == 0)
                            {
                                if ((length - 1) >= 3)
                                {
                                    length--;
                                }
                                else
                                {
                                    startIndex++;
                                    length = searchText.Length - startIndex;
                                }
                            }
                            else
                            {
                                startIndex = searchText.Length;
                            }
                        }                        
                    }

                    ResetSearchMovieProperties();

                    string msg = "";

                    if (foundMovie) { msg = "\"" + searchText + "\" was found, along with "; }
                    else
                    {
                        msg = "     \"" + searchText + "\" not found!";
                    }

                    if (moviesWithText.Count > 0)
                    {
                        string temp = "\t    ";
                        temp += msg;

                        msg = temp;

                        string movieCountText = (foundMovie == false)? moviesWithText.Count + " movie" : (moviesWithText.Count - 1) + " other movie";
                        string bestFitText = "best fit";

                        if (moviesWithText.Count > 1)
                        {
                            if (!foundMovie) { movieCountText += "s"; }
                            bestFitText += "s";
                        }

                        string msg2 = "";

                        if (foundMovie)
                        {
                            msg2 = movieCountText + "!";
                            MessageBox.Show(msg + msg2, "Search Successful!");
                        }
                        else
                        {
                            msg2 = "\n\n    Selecting " + movieCountText + " that " + bestFitText + " your search!";
                            MessageBox.Show(msg + msg2, "Search Failed!");
                        }
                    }
                    else
                    {
                        if (searchTooShort)
                        {
                            string text = searchText.ToLower();
                            if (text != "the" && text != "and")
                            {
                                msg = "       The search for \"" + searchText + "\" is too short for an accurate search!\n\n\t\t\tSorry!";
                            }
                            else
                            {
                                msg = "       The search for \"" + searchText + "\" is too generic. Please refine your search!";
                            }
                        }

                        MessageBox.Show(msg, "Search Failed!");
                    }

                    foreach (Movie movie in moviesWithText)
                    {
                        for (int i = 0; i < AllMovies_ListView.Items.Count; i++)
                        {
                            // assign the current items movie ID
                            string itemStr = AllMovies_ListView.Items[i].Text;

                            // if the current items movie ID = the found movie ID
                            if (itemStr == movie.IDAsString)
                            {
                                // Assign Focus
                                AllMovies_ListView.Focus();

                                AllMovies_ListView.HideSelection = false;
                                AllMovies_ListView.Items[i].Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
            // No movies
            else
            {
                ResetSearchMovieProperties();
                MessageBox.Show("\tNo movies in the library!\t", "Search Failed!");
            }
        }

        private void AddMovie()
        {
            if (movieTitleTextBox.Text != "" && movieTitleTextBox.Text != movies.EnterMovieTitleStr &&  
                genreComboBox.SelectedItem != null && genreComboBox.SelectedIndex != 0 &&
                discTypeComboBox.SelectedItem != null)
            {
                bool movieFound = movies.FindMovie(movieTitleTextBox.Text);

                if (!movieFound)
                {
                    Movie movie = new Movie();
                    movie.Title = movieTitleTextBox.Text;

                    string genreStr = genreComboBox.SelectedItem.ToString();

                    Genre g = Genre.Action;

                    for (int i = 1; i < 9; i++)
                    {
                        g = (Genre)i;

                        if (g.ToString() == genreStr) { break; }
                    }

                    movie.MovieGenre = g;

                    string discTypestr = discTypeComboBox.SelectedItem.ToString();

                    DiscType type = (DiscType)0;

                    for (int i = 0; i < discTypeEnumSize; i++)
                    {
                        type = (DiscType)i;

                        if (type.ToString() == discTypestr) { break; }
                    }

                    movie.TypeOfDisc = type;

                    movie.DisplayedTitle = /*(movies.GetMovieCount() + 1) + ": " + */movie.Title;
                    movies.AddMovie(movie);

                    // --------------------------------

                    ListViewItem itemID = new ListViewItem(movie.IDAsString);
                    ListViewItem.ListViewSubItem subItem_Title = new ListViewItem.ListViewSubItem(itemID, movie.Title);
                    ListViewItem.ListViewSubItem subItem_Genre = new ListViewItem.ListViewSubItem(itemID, movie.MovieGenre.ToString());

                    itemID.SubItems.Add(subItem_Title);
                    itemID.SubItems.Add(subItem_Genre);

                    AllMovies_ListView.Items.Add(itemID);

                    if (AllMovies_ListView.Items.Count > 27) { ResizeGenreColumn(false); }

                    int genreTabMaxMoviesWithoutScrollbar = 25;

                    if (Action_ListView.Items.Count >= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(false, Action_ListView, Action_TitleColumnSize); }
                    if (Adventure_ListView.Items.Count >= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(false, Adventure_ListView, Adventure_TitleColumnSize); }
                    if (Animation_ListView.Items.Count >= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(false, Animation_ListView, Animation_TitleColumnSize); }
                    if (Comedy_ListView.Items.Count >= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(false, Comedy_ListView, Comedy_TitleColumnSize); }
                    if (Horror_ListView.Items.Count >= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(false, Horror_ListView, Horror_TitleColumnSize); }
                    if (Romance_ListView.Items.Count >= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(false, Romance_ListView, Romance_TitleColumnSize); }
                    if (SciFi_ListView.Items.Count >= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(false, SciFi_ListView, SciFi_TitleColumnSize); }
                    if (Thriller_ListView.Items.Count >= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(false, Thriller_ListView, Thriller_TitleColumnSize); }

                    ReinitializeMovies();

                    SetAsUnsaved();

                    ClearDataStrip.Enabled = true;
                }
                else { ShowMovieExists(); }

                ResetAddMovieProperties();
            }
        }

        private void ShowContextMenuStripOnListBox(ListBox listBox, Point p)
        {
            //select the item under the mouse pointer
            listBox.SelectedIndex = listBox.IndexFromPoint(p);

            if (listBox.SelectedIndex != -1)
            {
                listBox.ContextMenuStrip = contextMenuStrip1;
                listBox.ContextMenuStrip.Show(listBox, p);
            }
            else
            {
                if (listBox.ContextMenuStrip != null)
                {
                    listBox.ContextMenuStrip.Hide();
                }
                listBox.ContextMenuStrip = null;
            }
        }

        private void ShowContextMenuStripOnListView(ListView listView, Point p)
        {
            //select the item under the mouse pointer
            //listView..SelectedIndex = listBox.IndexFromPoint(p);

            if (listView.SelectedItems.Count > 0)//.SelectedIndex != -1)
            {
                listView.ContextMenuStrip = contextMenuStrip1;
                listView.ContextMenuStrip.Show(listView, p);
            }
            else
            {
                if (listView.ContextMenuStrip != null)
                {
                    listView.ContextMenuStrip.Hide();
                }
                listView.ContextMenuStrip = null;
            }
        }

        private void CheckIfRightClickOnListView(ListView listView, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ShowContextMenuStripOnListView(listView, e.Location);
                listView.ContextMenuStrip = null;
            }
        }

        private void ShowMovieInfo()
        {
            string movieTitle = "";

            // All movies tab
            if (MovieTabs.SelectedIndex == 0)
            {
                /*
                // Make sure something is selected
                if (AllMoviesTitleBox.SelectedIndex != -1)
                {
                    movieTitle = AllMoviesTitleBox.SelectedItem.ToString();
                }
                */
                if (AllMovies_ListView.SelectedItems.Count > 0)
                {
                    if (AllMovies_ListView.SelectedItems.Count == 1)
                    {
                        movieTitle = AllMovies_ListView.SelectedItems[0].SubItems[1].Text;
                    }
                    else
                    {
                        movieTitle = "";
                        DialogResult result = MessageBox.Show("Sorry. Can't edit multiple movies. Only select one!", "Warning: Multile movies selected!");

                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            AllMovies_ListView.SelectedItems.Clear();
                        }
                    }
                }
            }
            else // Genres tab
            {
                ListView listView = null;

                switch (AllGenresTab.SelectedIndex)
                {
                    case 0: // Action
                        listView = Action_ListView;
                        break;
                    case 1: // Adventure
                        listView = Adventure_ListView;
                        break;
                    case 2: // Animation
                        listView = Animation_ListView;
                        break;
                    case 3: // Comedy
                        listView = Comedy_ListView;
                        break;
                    case 4: // Horror
                        listView = Horror_ListView;
                        break;
                    case 5: // Romance
                        listView = Romance_ListView;
                        break;
                    case 6: // SciFi
                        listView = SciFi_ListView;
                        break;
                    case 7: // Thriller
                        listView = Thriller_ListView;
                        break;
                }

                /*
                // If there was a listBox
                if (listBox != null)
                {
                    // Make sure something is selected
                    if (listBox.SelectedIndex != -1)
                    {
                        // Assign the movie title
                        movieTitle = listBox.SelectedItem.ToString();
                    }
                }
                */

                // If there was a listView
                if (listView != null)
                {
                    if (listView.SelectedItems.Count > 0)
                    {
                        if (listView.SelectedItems.Count == 1)
                        {
                            movieTitle = listView.SelectedItems[0].SubItems[1].Text;
                        }
                        else
                        {
                            movieTitle = "";
                            DialogResult result = MessageBox.Show("Sorry. Can't edit multiple movies. Only select one!", "Warning: Multile movies selected!");

                            if (result == System.Windows.Forms.DialogResult.OK || result == System.Windows.Forms.DialogResult.Cancel)
                            {
                                listView.SelectedItems.Clear();
                            }
                        }
                    }
                }
            }

            // Make sure there is a title
            if (movieTitle != "")
            {
                // Grab the movie
                Movie movie = movies.GetMovie(movieTitle);

                movieInfo.AssignMovie(movie);
                // Show the movie info
                movieInfo.ShowDialog();

            }
        }

        private void DeleteMovie()
        {
            string movieTitle = "";

            List<string> movieTitles = new List<string>();

            // All movies tab
            if (MovieTabs.SelectedIndex == 0)
            {
                if (AllMovies_ListView.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < AllMovies_ListView.SelectedItems.Count; i++)
                    {
                        movieTitles.Add(AllMovies_ListView.SelectedItems[i].SubItems[1].Text);
                    }
                }
            }
            else // Genres tab
            {
                ListView listView = GetGenreView();

                /*
                // If there was a listBox
                if (listBox != null)
                {
                    // Make sure something is selected
                    if (listBox.SelectedIndex != -1)
                    {
                        // Assign the movie title
                        movieTitle = listBox.SelectedItem.ToString();
                    }
                }
                */

                // If there was a listView
                if (listView != null)
                {
                    if (listView.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < listView.SelectedItems.Count; i++)
                        {
                            movieTitles.Add(listView.SelectedItems[i].SubItems[1].Text);
                        }
                    }
                }
            }

            // Make sure there is a title
            if (movieTitle != "")
            {
                // Grab the movie
                Movie movie = movies.GetMovie(movieTitle);

                if (movie != null)
                {
                    DialogResult result1 = MessageBox.Show("Are you sure you want to delete \"" + movie.Title + "\" ?", "Warning: Confirm Deletion!", MessageBoxButtons.YesNo);

                    if (result1 == System.Windows.Forms.DialogResult.Yes)
                    {
                        movies.RemoveMovie(movie);
                        ReinitializeMovies();

                        if (saveStatus != SaveStatus.UnSaved)
                        {
                            SetAsUnsaved();
                        }

                        //if (movies.GetMovieCount() > 0)
                        //{
                        //    SetAsUnsaved();
                        //}
                        //else
                        //{
                        //    DeleteFile();
                        //}

                        // To accommodate the scrollbar itself 
                        if (AllMovies_ListView.Items.Count <= 27) { ResizeGenreColumn(true); }
                    }
                }
            }

            if (movieTitles.Count > 0)
            {
                string multipleSelectionStr = "the selected movies";
                string singleSelectionStr = "\"" + movieTitles[0] + "\"";

                string str = "";

                if (movieTitles.Count > 1) { str = multipleSelectionStr; }
                else { str = singleSelectionStr; }

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + str + " ?", "Warning: Confirm Deletion!", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (string title in movieTitles)
                    {
                        // Grab the movie
                        Movie movie = movies.GetMovie(title);

                        if (movie != null)
                        {
                            movies.RemoveMovie(movie);
                        }
                    }

                    ReinitializeMovies();

                    if (saveStatus != SaveStatus.UnSaved)
                    {
                        SetAsUnsaved();
                    }

                    //if (movies.GetMovieCount() > 0)
                    //{
                    //    SetAsUnsaved();
                    //}
                    //else
                    //{
                    //    DeleteFile();
                    //}

                    if (AllMovies_ListView.Items.Count <= 27) { ResizeGenreColumn(true); }

                    int genreTabMaxMoviesWithoutScrollbar = 25;

                    if (Action_ListView.Items.Count <= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(true, Action_ListView, Action_TitleColumnSize); }
                    if (Adventure_ListView.Items.Count <= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(true, Adventure_ListView, Adventure_TitleColumnSize); }
                    if (Animation_ListView.Items.Count <= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(true, Animation_ListView, Animation_TitleColumnSize); }
                    if (Comedy_ListView.Items.Count <= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(true, Comedy_ListView, Comedy_TitleColumnSize); }
                    if (Horror_ListView.Items.Count <= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(true, Horror_ListView, Horror_TitleColumnSize); }
                    if (Romance_ListView.Items.Count <= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(true, Romance_ListView, Romance_TitleColumnSize); }
                    if (SciFi_ListView.Items.Count <= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(true, SciFi_ListView, SciFi_TitleColumnSize); }
                    if (Thriller_ListView.Items.Count <= genreTabMaxMoviesWithoutScrollbar) { ResizeTitleColumn(true, Thriller_ListView, Thriller_TitleColumnSize); }
                }
            }
        
        }

        public void SetAsUnsaved()
        {
            saveStatus = SaveStatus.UnSaved;
            this.Text = formTitle + "*";
            if (!SaveStrip.Enabled) { SaveStrip.Enabled = true; }
        }

        public void SetAsCanceled()
        {
            saveStatus = SaveStatus.Canceled;

            if (SaveStrip.Enabled) { SaveStrip.Enabled = false; }
        }

        private void ResizeGenreColumn(bool grow)
        {
            int additionalSize = 17;

            if (!grow)
            {
                additionalSize *= -1;
            }

            int newSize = AllMovies_GenreColumnSize;

            if (!grow)
            {
                newSize += additionalSize;
            }

            if (AllMovies_ListView.Columns[2].Width != AllMovies_GenreColumnSize || newSize < AllMovies_GenreColumnSize)
            {
                AllMovies_ListView.Columns[2].Width = newSize;
            }
        }

        private void ResizeTitleColumn(bool grow, ListView listView, int ColumnSize)
        {
            int additionalSize = 17;

            if (!grow)
            {
                additionalSize *= -1;
            }

            int newSize = ColumnSize;

            if (!grow)
            {
                newSize += additionalSize;
            }

            if (listView.Columns[1].Width != ColumnSize || newSize < ColumnSize)
            {
                listView.Columns[1].Width = newSize;
            }
        }

        private void CancelColumnWidthChange(ListView listView, ColumnWidthChangingEventArgs e)
        {
            //Keep the width not changed.
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;

            //Cancel the event.
            e.Cancel = true;
        }

        private void SortListView(ListView listView, int columnIndex)
        {
            switch (columnIndex)
            {
                case 0: // ID
                    movies.SortByID();
                    ReinitializeMovies();
                    SetAsUnsaved();
                    break;

                case 1: // Title
                    movies.SortByTitle();
                    ReinitializeMovies();
                    SetAsUnsaved();
                    break;

                case 2: // Genre
                    movies.SortByGenre();
                    ReinitializeMovies();
                    SetAsUnsaved();
                    break;
            }
        }
        
        private void ClearListViewSelectedItems(ListView listView)
        {
            listView.SelectedItems.Clear();
        }

        private void DeleteFile()
        {
            string path = Application.StartupPath + "\\" + fileName;
            File.Delete(path);
            movies.MovieList.Clear();
            ReinitializeMovies();

            if (SaveStrip.Enabled) { SaveStrip.Enabled = false; }

            saveStatus = SaveStatus.Canceled;

            ClearDataStrip.Enabled = false;
        }

        private bool IsEmptyTextBox(string txt)
        {
            string text = txt;

            char[] chars = text.ToCharArray();

            bool empty = true;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != ' ')
                {
                    empty = false;
                    break;
                }
            }

            if (text == "" || empty)
            {
                return empty;
            }

            return false;
        }

        private void SaveIfCtrl_S_Pressed(KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                if (saveStatus == SaveStatus.UnSaved)
                {
                    Save();
                    ShowSaveStatus();
                    SetAsCanceled();
                    genreComboBox.SelectedIndex = 0;
                    discTypeComboBox.SelectedIndex = 0;
                }
            }
        }

        private void DeleteSelectedIfDelete_Pressed(KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back))
            {
                DeleteMovie();
            }
        }

        private void randomMovieBtn_Click(object sender, EventArgs e)
        {
            Genre genre = (Genre)randomGenreBox.SelectedIndex;
            Movie movie = movies.GetRandomMovie(genre);

            if (genre == Genre.None)
            {
                // Select AllMovies Tab as focus
                MovieTabs.SelectedIndex = 0;

                // Look through all items in ListView
                for (int i = 0; i < AllMovies_ListView.Items.Count; i++)
                {
                    // assign the current items movie ID
                    string itemStr = AllMovies_ListView.Items[i].Text;

                    // if the current items movie ID = the found movie ID
                    if (itemStr == movie.IDAsString)
                    {
                        // Assign Focus
                        AllMovies_ListView.Focus();

                        AllMovies_ListView.HideSelection = false;
                        AllMovies_ListView.Items[i].Selected = true;
                    }
                }
            }
            else
            {

                AllMovies_ListView.HideSelection = true;

                // Look through all items in ListView
                for (int i = 0; i < AllMovies_ListView.Items.Count; i++)
                {
                    AllMovies_ListView.Items[i].Selected = false;
                }

                // Select AllGenresTab as focus
                // Select specific Genre tab as focus
                SelectMovieTabByGenre(genre);

                ListView view = GetGenreView();

                // Look through all items in ListView
                for (int i = 0; i < view.Items.Count; i++)
                {
                    // assign the current items movie ID
                    string itemStr = view.Items[i].Text;

                    // if the current items movie ID = the found movie ID
                    if (itemStr == movie.IDAsString)
                    {
                        // Assign Focus
                        view.Focus();

                        view.HideSelection = false;
                        view.Items[i].Selected = true;
                    }
                }
            }
        }

        private void SelectMovieTabByGenre(Genre genre)
        {
            switch (genre)
            {
                case Genre.None:
                    MovieTabs.SelectedIndex = 0;
                    break;

                case Genre.Action:
                case Genre.Adventure:
                case Genre.Animation:
                case Genre.Comedy:
                case Genre.Horror:
                case Genre.Romance:
                case Genre.SciFi:
                case Genre.Thriller:
                    MovieTabs.SelectedIndex = 1;
                    AllGenresTab.SelectedIndex = ((int)genre) - 1;
                    break;    
            }
        }

        private ListView GetGenreView()
        {
            ListView listView = null;

            switch (AllGenresTab.SelectedIndex)
            {
                case 0: // Action
                    listView = Action_ListView;
                    break;
                case 1: // Adventure
                    listView = Adventure_ListView;
                    break;
                case 2: // Animation
                    listView = Animation_ListView;
                    break;
                case 3: // Comedy
                    listView = Comedy_ListView;
                    break;
                case 4: // Horror
                    listView = Horror_ListView;
                    break;
                case 5: // Romance
                    listView = Romance_ListView;
                    break;
                case 6: // SciFi
                    listView = SciFi_ListView;
                    break;
                case 7: // Thriller
                    listView = Thriller_ListView;
                    break;
            }

            return listView;
        }

        #endregion

        #region Events

        #region Form Open/Close
        private void Form1_Load(object sender, EventArgs e)
        {
            loadStatus = LoadFile();

            if (movies.GetMovieCount() > 0)
            {
                saveStatus = SaveStatus.Canceled;

                SaveStrip.Enabled = false;
                ClearDataStrip.Enabled = true;
            }
            else
            {
                saveStatus = SaveStatus.CantSave;
                SaveStrip.Enabled = false;
                ClearDataStrip.Enabled = false;
            }

            AllMovies_GenreColumnSize = AllMovies_ListView.Columns[2].Width;

            Action_TitleColumnSize = Action_ListView.Columns[1].Width;

            Adventure_TitleColumnSize = Adventure_ListView.Columns[1].Width;

            Animation_TitleColumnSize = Animation_ListView.Columns[1].Width;

            Comedy_TitleColumnSize = Comedy_ListView.Columns[1].Width;

            Horror_TitleColumnSize = Horror_ListView.Columns[1].Width;

            Romance_TitleColumnSize = Romance_ListView.Columns[1].Width;

            SciFi_TitleColumnSize = SciFi_ListView.Columns[1].Width;

            Thriller_TitleColumnSize = Thriller_ListView.Columns[1].Width;

            int additionalSize = 17;
            int genreTabMaxMoviesWithoutScrollbar = 25;

            if (movies.GetMovieCount() > 27)
            {
                AllMovies_ListView.Columns[2].Width = AllMovies_GenreColumnSize - additionalSize;
            }

            if (movies.GetMovieCountByGenre(Genre.Action) > genreTabMaxMoviesWithoutScrollbar)
            {
                Action_ListView.Columns[1].Width = Action_TitleColumnSize - additionalSize;
            }

            if (movies.GetMovieCountByGenre(Genre.Adventure) > genreTabMaxMoviesWithoutScrollbar)
            {
                Adventure_ListView.Columns[1].Width = Adventure_TitleColumnSize - additionalSize;
            }

            if (movies.GetMovieCountByGenre(Genre.Animation) > genreTabMaxMoviesWithoutScrollbar)
            {
                Animation_ListView.Columns[1].Width = Animation_TitleColumnSize - additionalSize;
            }

            if (movies.GetMovieCountByGenre(Genre.Comedy) > genreTabMaxMoviesWithoutScrollbar)
            {
                Comedy_ListView.Columns[1].Width = Comedy_TitleColumnSize - additionalSize;
            }

            if (movies.GetMovieCountByGenre(Genre.Horror) > genreTabMaxMoviesWithoutScrollbar)
            {
                Horror_ListView.Columns[1].Width = Horror_TitleColumnSize - additionalSize;
            }

            if (movies.GetMovieCountByGenre(Genre.Romance) > genreTabMaxMoviesWithoutScrollbar)
            {
                Romance_ListView.Columns[1].Width = Romance_TitleColumnSize - additionalSize;
            }

            if (movies.GetMovieCountByGenre(Genre.SciFi) > genreTabMaxMoviesWithoutScrollbar)
            {
                SciFi_ListView.Columns[1].Width = SciFi_TitleColumnSize - additionalSize;
            }

            if (movies.GetMovieCountByGenre(Genre.Thriller) > genreTabMaxMoviesWithoutScrollbar)
            {
                Thriller_ListView.Columns[1].Width = Thriller_TitleColumnSize - additionalSize;
            }
        }

        private void MovieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing) { ExitApplication(); }

            if (!closing)
            {
                e.Cancel = true;
            }
        }

        private void MovieForm_Shown(object sender, EventArgs e)
        {
            ShowLoadStatus();
        } 
        #endregion

        #region Button Click
        private void AddMovieBtn_Click(object sender, EventArgs e)
        {
            AddMovie();
        } 

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!IsEmptyTextBox(this.searchBox.Text) && this.searchBox.Text != movies.SearchMovieTitleStr)
            {
                SearchForMovie();
            }
        }
        #endregion

        #region TextBox Click
        private void movieTitleTextBox_Click(object sender, EventArgs e)
        {
            if (movieTitleTextBox.Text == movies.EnterMovieTitleStr) { movieTitleTextBox.Text = ""; }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == movies.SearchMovieTitleStr) { searchBox.Text = ""; }
        }
        #endregion

        #region TextBox/ComboBox KeyPress
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)(Keys.Enter))
            {
                if (!IsEmptyTextBox(this.searchBox.Text))
                {
                    SearchForMovie();
                }
            }
        }

        private void movieTitleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)(Keys.Enter))
            {
                AddMovie();
            }
        }

        private void genreComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)(Keys.Enter))
            {
                AddMovie();
            }
        }


        private void discTypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)(Keys.Enter))
            {
                AddMovie();
            }
        }
        #endregion

        #region TextBox Leave
        private void movieTitleTextBox_Leave(object sender, EventArgs e)
        {
            if (IsEmptyTextBox(movieTitleTextBox.Text))
            {
                movieTitleTextBox.Text = movies.EnterMovieTitleStr;
            }
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (IsEmptyTextBox(searchBox.Text))
            {
                searchBox.Text = movies.SearchMovieTitleStr;
            }
        } 
        #endregion
        
        #region ToolStrip Events
        private void SaveStrip_Click(object sender, EventArgs e)
        {
            if (movies.MovieList.Count > 0)
            {
                this.saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                this.saveFileDialog1.FileName = "*.xml";
                saveFileDialog1.InitialDirectory = Application.StartupPath;

                if (saveStatus == SaveStatus.UnSaved)
                {
                    Save();
                }
            }

            ShowSaveStatus();

            if (saveStatus == SaveStatus.Saved)
            {
                saveStatus = SaveStatus.Canceled;
                SaveStrip.Enabled = false;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!closing) { ExitApplication(); }
        }

        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clearMsg = "Are you sure you want clear all data?";
            string clearCaption = "Warning: Destructive action!";

            DialogResult exitResult = MessageBox.Show(clearMsg, clearCaption, MessageBoxButtons.YesNo);

            if (exitResult == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteFile(); 
            }
        }

        private void AboutStrip_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void editMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMovie();
        } 
        #endregion
        
        #region ListView Column Width Changing
        private void AllMovies_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            CancelColumnWidthChange(AllMovies_ListView, e);
        }

        private void Action_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            CancelColumnWidthChange(Action_ListView, e);
        }

        private void Adventure_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            CancelColumnWidthChange(Adventure_ListView, e);
        }

        private void Animation_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            CancelColumnWidthChange(Animation_ListView, e);
        }

        private void Comedy_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            CancelColumnWidthChange(Comedy_ListView, e);
        }

        private void Horror_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            CancelColumnWidthChange(Horror_ListView, e);
        }

        private void Romance_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            CancelColumnWidthChange(Romance_ListView, e);
        }

        private void SciFi_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            CancelColumnWidthChange(SciFi_ListView, e);
        }

        private void Thriller_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            CancelColumnWidthChange(Thriller_ListView, e);
        }
        #endregion

        #region ListView MouseUp
        private void AllMovies_ListView_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfRightClickOnListView(AllMovies_ListView, e);
        }

        private void Action_ListView_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfRightClickOnListView(Action_ListView, e);
        }

        private void Adventure_ListView_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfRightClickOnListView(Adventure_ListView, e);
        }

        private void Animation_ListView_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfRightClickOnListView(Animation_ListView, e);
        }

        private void Comedy_ListView_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfRightClickOnListView(Comedy_ListView, e);
        }

        private void Horror_ListView_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfRightClickOnListView(Horror_ListView, e);
        }

        private void Romance_ListView_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfRightClickOnListView(Romance_ListView, e);
        }

        private void SciFi_ListView_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfRightClickOnListView(SciFi_ListView, e);
        }

        private void Thriller_ListView_MouseUp(object sender, MouseEventArgs e)
        {
            CheckIfRightClickOnListView(Thriller_ListView, e);
        }
        #endregion

        #region ListView Leave
        private void AllMovies_ListView_Leave(object sender, EventArgs e)
        {
            ClearListViewSelectedItems(AllMovies_ListView);
        }

        private void Action_ListView_Leave(object sender, EventArgs e)
        {
            ClearListViewSelectedItems(Action_ListView);
        }

        private void Adventure_ListView_Leave(object sender, EventArgs e)
        {
            ClearListViewSelectedItems(Adventure_ListView);
        }

        private void Animation_ListView_Leave(object sender, EventArgs e)
        {
            ClearListViewSelectedItems(Animation_ListView);
        }

        private void Comedy_ListView_Leave(object sender, EventArgs e)
        {
            ClearListViewSelectedItems(Comedy_ListView);
        }

        private void Horror_ListView_Leave(object sender, EventArgs e)
        {
            ClearListViewSelectedItems(Horror_ListView);
        }

        private void Romance_ListView_Leave(object sender, EventArgs e)
        {
            ClearListViewSelectedItems(Romance_ListView);
        }

        private void SciFi_ListView_Leave(object sender, EventArgs e)
        {
            ClearListViewSelectedItems(SciFi_ListView);
        }

        private void Thriller_ListView_Leave(object sender, EventArgs e)
        {
            ClearListViewSelectedItems(Thriller_ListView);
        }
        #endregion

        #region ListView ColumnClicks
        private void AllMovies_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(AllMovies_ListView, e.Column);
        }

        private void Action_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(Action_ListView, e.Column);
        }

        private void Adventure_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(Adventure_ListView, e.Column);
        }

        private void Animation_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(Animation_ListView, e.Column);
        }

        private void Comedy_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(Comedy_ListView, e.Column);
        }

        private void Horror_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(Horror_ListView, e.Column);
        }

        private void Romance_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(Romance_ListView, e.Column);
        }

        private void SciFi_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(SciFi_ListView, e.Column);
        }

        private void Thriller_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(Thriller_ListView, e.Column);
        }
        #endregion

        #region ListView DoubleClick
        private void AllMovies_ListView_DoubleClick(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }

        private void Action_ListView_DoubleClick(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }

        private void Adventure_ListView_DoubleClick(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }

        private void Animation_ListView_DoubleClick(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }

        private void Comedy_ListView_DoubleClick(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }

        private void Horror_ListView_DoubleClick(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }

        private void Romance_ListView_DoubleClick(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }

        private void SciFi_ListView_DoubleClick(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }

        private void Thriller_ListView_DoubleClick(object sender, EventArgs e)
        {
            // Display movie info
            ShowMovieInfo();
        }
        #endregion

        #region KeyDown_Ctrl_S_Save
        private void AllMovies_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);

            DeleteSelectedIfDelete_Pressed(e);
        }

        private void genreComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);
        }

        private void movieTitleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);
        }

        private void discTypeComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);
        }

        private void AddMovieBtn_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);
        }

        private void MovieTabs_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);
        }

        private void AllGenresTab_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);
        }

        private void Action_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);

            DeleteSelectedIfDelete_Pressed(e);
        }

        private void Adventure_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);

            DeleteSelectedIfDelete_Pressed(e);
        }

        private void Animation_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);

            DeleteSelectedIfDelete_Pressed(e);
        }

        private void Comedy_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);

            DeleteSelectedIfDelete_Pressed(e);
        }

        private void Horror_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);

            DeleteSelectedIfDelete_Pressed(e);
        }

        private void Romance_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);

            DeleteSelectedIfDelete_Pressed(e);
        }

        private void SciFi_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);

            DeleteSelectedIfDelete_Pressed(e);
        }

        private void Thriller_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);

            DeleteSelectedIfDelete_Pressed(e);
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);
        }

        private void searchButton_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfCtrl_S_Pressed(e);
        }
        #endregion

        private void MovieTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AllGenresTab.SelectedIndex = 0;
        }

        private void AllMovies_ListView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)(Keys.Delete) || e.KeyChar == (Char)(Keys.Back))
            {
                //DeleteMovie();
            }
        }

        private void MovieForm_LocationChanged(object sender, EventArgs e)
        {
            movieInfo.StartPosition = FormStartPosition.CenterParent;
        }

        #endregion

        

    }
}
