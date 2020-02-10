using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movie_Library
{
    public partial class MovieInfo : Form
    {
        #region Data Members
		private Movie movie;
        private MovieForm mainForm;

        bool hasUnsavedChanges = false;

        List<string> strList;

        string enterMovieDescriptionText;
        string enterDirectorsText;
        string enterWritersText;
        string enterActorsText;

        //string initialGenreText;
        Genre initialGenre;
        DiscType initialDiscType;

        int initialMovieYear;
        DateTime initialReleaseDate;
        MovieRating initialRating;


        #endregion

        #region Constructor
        public MovieInfo(MovieForm mainForm)
        {
            this.mainForm = mainForm;

            enterMovieDescriptionText = "Enter movie description here...";
            enterDirectorsText = "Enter directors here...";
            enterWritersText = "Enter writers here...";
            enterActorsText = "Enter actors here...";

            InitializeComponent();
        } 
        #endregion

        #region Methods
        public void AssignMovie(Movie movie)
        {
            ClearMovieAttributes();

            this.movie = movie;
            AssignMovieAttributes(this.movie);
        }

        private void AssignMovieAttributes(Movie movie)
        {
            this.movieTitleTextBox.Text = movie.Title;

            this.genreComboBox.SelectedIndex = (int)movie.MovieGenre;

            this.genreTextbox.Text = movie.MovieGenre.ToString();

            string type = "";
            switch (movie.TypeOfDisc)
            {
                case DiscType.DVD:
                    type = "DVD";
                    break;

                case DiscType.BluRay:
                    type = "Blu-Ray";
                    break;

                case DiscType.BluRay_DVD:
                    type = "Blu-Ray & DVD";
                    break;
            }

            this.discTypeTextBox.Text = type;
            
            this.ratingComboBox.SelectedIndex = (int)movie.Rating;

            if (movie.ReleaseDate.Year >= releaseDatePicker.MinDate.Year)
            {
                releaseDatePicker.Value = movie.ReleaseDate;
            }

            this.IDTextBox.Text = movie.IDAsString;

            if (movie.MovieYear < this.yearBox.Minimum)
            {
                movie.MovieYear = 2013;
            }

            this.yearBox.Value = (decimal)movie.MovieYear;

            this.movieLength_Minutes.Value = (decimal)movie.MovieLength.Minute;
            this.movieLength_Hours.Value = (decimal)movie.MovieLength.Hour;

            this.movieDescriptionTextBox.Select(0, 0);
            this.movieDescriptionTextBox.DeselectAll();

            if (this.movie.MovieDescription != "" && this.movie.MovieDescription != null)
            {
                this.movieDescriptionTextBox.Text = this.movie.MovieDescription;
            }

            if (movie.Directors.Count > 0)
            {
                this.directorsTextBox.Text = ConvertListToStr(movie.Directors);
            }

            if (movie.Writers.Count > 0)
            {
                this.writersTextBox.Text = ConvertListToStr(movie.Writers);
            }

            if (movie.Actors.Count > 0)
            {
                this.actorsTextBox.Text = ConvertListToStr(movie.Actors);
            }

            hasUnsavedChanges = false;

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            UpdateMovie();

            ///*
            if (hasUnsavedChanges)
            {
                //this.mainForm.movies.AssignID(this.movie);

                this.mainForm.SetAsUnsaved();
                this.mainForm.ReinitializeMovies();
            }
            //else
            //{
            //    this.mainForm.SetAsCanceled();
            //}
            //*/

            this.Close();
        }

        private void ClearMovieAttributes()
        {
            this.movieTitleTextBox.Text = "";
            //this.genreTextBox.Text = movie.MovieGenre.ToString();
            this.genreComboBox.SelectedIndex = 0;
            this.genreTextbox.Text = "";
            this.discTypeTextBox.Text = "";

            this.ratingComboBox.SelectedIndex = 0;

            releaseDatePicker.Value = DateTime.Now;

            this.IDTextBox.Text = "";

            this.yearBox.Value = (decimal)2013;

            hasUnsavedChanges = false;

            this.movieDescriptionTextBox.Text = enterMovieDescriptionText;
            this.directorsTextBox.Text = enterDirectorsText;
            this.writersTextBox.Text = enterWritersText;
            this.actorsTextBox.Text = enterActorsText;
        }

        private void UpdateMovie()
        {
            this.movie.MovieDescription = this.movieDescriptionTextBox.Text;
            this.movie.MovieYear = (int)this.yearBox.Value;
            this.movie.IDAsString = this.IDTextBox.Text;

            this.movie.MovieGenre = (Genre)this.genreComboBox.SelectedIndex;

            string [] genreList = mainForm.movies.GetGenreList();

            int count = genreList.Count<string>();

            for (int i = 1; i <= count; i++)
            {
                if (genreList[i-1] == this.genreTextbox.Text)
                {
                    this.movie.MovieGenre = (Genre)i;
                    break;
                }
            }

            this.movie.Rating = (MovieRating)this.ratingComboBox.SelectedIndex;
            this.movie.ReleaseDate = releaseDatePicker.Value;

            DateTime length = new DateTime();

            double hours = (double)movieLength_Hours.Value;
            double minutes = (double)movieLength_Minutes.Value;

            length = length.AddHours(hours);
            length = length.AddMinutes(minutes);

            this.movie.MovieLength = length;

            this.movie.Directors = ConvertStrToList(this.directorsTextBox.Text);

            this.movie.Writers = ConvertStrToList(this.writersTextBox.Text);

            this.movie.Actors = ConvertStrToList(this.actorsTextBox.Text);

            //this.movie.MovieDescription = this.movieDescriptionTextBox.Text;

            //this.movie.MovieDescription = this.movieDescriptionTextBox.Text;
            //this.movie.MovieDescription = this.movieDescriptionTextBox.Text;
            //this.movie.MovieDescription = this.movieDescriptionTextBox.Text;
            //this.movie.MovieDescription = this.movieDescriptionTextBox.Text;
            //this.movie.MovieDescription = this.movieDescriptionTextBox.Text;
            //this.movie.MovieDescription = this.movieDescriptionTextBox.Text;
        }

        private List<string> ConvertStrToList(string str)
        {
            strList = new List<string>();
            
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '\r' && str[i] != '\n')
                {
                    newStr += str[i];
                }

                if (str[i] == '\r' || str[i] == '\n' || (i == str.Length - 1))
                {
                    if (newStr != "")
                    {
                        strList.Add(newStr);
                        newStr = "";
                    }
                }
            }

            return strList;
        }

        private string ConvertListToStr(List<string> list)
        {
            string newStr = "";

            int index = 0;
            foreach (string str in list)
            {
                index++;
                newStr += str;

                if (index < list.Count)
                {
                    newStr += "\r\n";
                }

            }

            return newStr;
        }

        private bool IsEmptyTextBox(string txt)
        {
            string text = txt;

            char[] chars = text.ToCharArray();

            bool empty = true;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != ' ' && chars[i] != '\r' && chars[i] != '\n')
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
        #endregion

        #region Events
        private void MovieInfo_Load(object sender, EventArgs e)
        {
            //if (!hasUnsavedChanges)
            //{
            this.yearBox.Maximum = DateTime.Now.Year;
            //hasUnsavedChanges = false;

            //initialGenreText = this.genreTextBox.Text;
            initialGenre = (Genre)this.genreComboBox.SelectedIndex;

            initialMovieYear = (int)this.yearBox.Value;

            initialReleaseDate = this.releaseDatePicker.Value;

            initialRating = (MovieRating)this.ratingComboBox.SelectedIndex;

            hasUnsavedChanges = false;
            //}
        }

        private void yearBox_ValueChanged(object sender, EventArgs e)
        {
            /*
            if ((int)this.yearBox.Value != initialMovieYear && initialMovieYear != 0)
            {
                if (!hasUnsavedChanges)
                {
                    hasUnsavedChanges = true;
                }
            }
            //else
            //{
            //    if (hasUnsavedChanges)
            //    {
            //        hasUnsavedChanges = false;
            //    }
            //}
            */
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void ratedTextBox_TextChanged(object sender, EventArgs e)
        {
            /*
            if ((int)this.yearBox.Value != initialMovieYear)
            {
                if (!hasUnsavedChanges)
                {
                    hasUnsavedChanges = true;
                }
            }
            else
            {
                if (hasUnsavedChanges)
                {
                    hasUnsavedChanges = false;
                }
            }
            */
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void releaseDateTextBox_TextChanged(object sender, EventArgs e)
        {
            /*
            if ((int)this.yearBox.Value != initialMovieYear)
            {
                if (!hasUnsavedChanges)
                {
                    hasUnsavedChanges = true;
                }
            }
            else
            {
                if (hasUnsavedChanges)
                {
                    hasUnsavedChanges = false;
                }
            }
            */
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void movieLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            /*
            if ((int)this.yearBox.Value != initialMovieYear)
            {
                if (!hasUnsavedChanges)
                {
                    hasUnsavedChanges = true;
                }
            }
            else
            {
                if (hasUnsavedChanges)
                {
                    hasUnsavedChanges = false;
                }
            }
            */
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void directorsTextBox_TextChanged(object sender, EventArgs e)
        {
            //List<string> list = new List<string>(ConvertStrToList(directorsTextBox.Text));

            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void writersTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void actorsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void movieDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void releaseDatePicker_ValueChanged(object sender, EventArgs e)
        {
            /*
            if (this.releaseDatePicker.Value != initialReleaseDate && initialReleaseDate.Year >= releaseDatePicker.MinDate.Year)
            {
                if (!hasUnsavedChanges)
                {
                    hasUnsavedChanges = true;
                }
            }
            
            //else
            //{
            //    if (hasUnsavedChanges)
            //    {
            //        hasUnsavedChanges = false;
            //    }
            //}
            */
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void ratingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (this.ratingComboBox.SelectedIndex != (int)initialRating && this.ratingComboBox.SelectedIndex != 0 && initialRating != MovieRating.None)
            {
                if (!hasUnsavedChanges)
                {
                    hasUnsavedChanges = true;
                }
            }
            //else
            //{
              //  if (hasUnsavedChanges)
                //{
                  //  hasUnsavedChanges = false;
                //}
            //}
            */
            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void movieLength_Hours_ValueChanged(object sender, EventArgs e)
        {
            if (movieLength_Hours.Value == movieLength_Hours.Maximum)
            {
                movieLength_Minutes.Value = 0;
            }

            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        }

        private void movieLenght_Minutes_ValueChanged(object sender, EventArgs e)
        {
            if (movieLength_Hours.Value <= 0 && movieLength_Minutes.Value <= 0)
            {
                movieLength_Hours.Value = 0;
                movieLength_Minutes.Value = 0;
            }
            else if (movieLength_Hours.Value < movieLength_Hours.Maximum && movieLength_Minutes.Value > 59)
            {
                movieLength_Hours.Value++;
                movieLength_Minutes.Value = 0;
            }
            else if (movieLength_Hours.Value > 0 && movieLength_Minutes.Value < 0)
            {
                movieLength_Hours.Value--;
                movieLength_Minutes.Value = 59;
            }
            else if (movieLength_Hours.Value == movieLength_Hours.Maximum && movieLength_Minutes.Value > 0)
            {
                movieLength_Minutes.Value = 0;
            }

            if (!hasUnsavedChanges)
            {
                hasUnsavedChanges = true;
            }
        } 
        #endregion

        private void directorsTextBox_Click(object sender, EventArgs e)
        {
            if (this.directorsTextBox.Text == enterDirectorsText)
            {
                this.directorsTextBox.Text = "";
            }
        }

        private void writersTextBox_Click(object sender, EventArgs e)
        {
            if (this.writersTextBox.Text == enterWritersText)
            {
                this.writersTextBox.Text = "";
            }
        }

        private void actorsTextBox_Click(object sender, EventArgs e)
        {
            if (this.actorsTextBox.Text == enterActorsText)
            {
                this.actorsTextBox.Text = "";
            }
        }

        private void movieDescriptionTextBox_Click(object sender, EventArgs e)
        {
            if (this.movieDescriptionTextBox.Text == enterMovieDescriptionText)
            {
                this.movieDescriptionTextBox.Text = "";
            }
        }

        private void directorsTextBox_Leave(object sender, EventArgs e)
        {
            if (IsEmptyTextBox(directorsTextBox.Text))
            {
                directorsTextBox.Text = enterDirectorsText;

                if (hasUnsavedChanges)
                {
                    hasUnsavedChanges = false;
                }
            }

            this.AcceptButton = this.button_Close;
        }

        private void writersTextBox_Leave(object sender, EventArgs e)
        {
            if (IsEmptyTextBox(writersTextBox.Text))
            {
                writersTextBox.Text = enterWritersText;

                if (hasUnsavedChanges)
                {
                    hasUnsavedChanges = false;
                }
            }

            this.AcceptButton = this.button_Close;
        }

        private void actorsTextBox_Leave(object sender, EventArgs e)
        {
            if (IsEmptyTextBox(actorsTextBox.Text))
            {
                actorsTextBox.Text = enterActorsText;

                if (hasUnsavedChanges)
                {
                    hasUnsavedChanges = false;
                }
            }

            this.AcceptButton = this.button_Close;
        }

        private void movieDescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (IsEmptyTextBox(movieDescriptionTextBox.Text))
            {
                movieDescriptionTextBox.Text = enterMovieDescriptionText;

                if (hasUnsavedChanges)
                {
                    hasUnsavedChanges = false;
                }
            }

            this.AcceptButton = this.button_Close;
        }

        private void directorsTextBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void writersTextBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void actorsTextBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void movieDescriptionTextBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void tableLayoutPanel_Click(object sender, EventArgs e)
        {
            tableLayoutPanel.Focus();
        }

        private void MovieInfo_Click(object sender, EventArgs e)
        {
            tableLayoutPanel.Focus();
        }
    }
}
