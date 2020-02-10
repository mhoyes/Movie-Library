using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Movie_Library
{
    //[Serializable]
    public class Movies
    {
        #region Data Members
        private List<Movie> movieList;
        private string enterMovieTitleStr;
        private string searchMovieTitleStr; 
        #endregion

        #region Constructor
        public Movies()
        {
            movieList = new List<Movie>();
            enterMovieTitleStr = "Enter Movie Title";
            searchMovieTitleStr = "Search for movie...";
        } 
        #endregion

        #region Methods
        public string[] GetGenreList()
        {
            List<string> genres = new List<string>();

            for (int i = 1; i < 9; i++)
            {
                string genre = ((Genre)i).ToString();
                genres.Add(genre);
            }

            return genres.ToArray();
        }

        public void AddMovie(Movie movie)
        {
            movie.ID = GetMovieCountByGenre(movie.MovieGenre);//overallMovieCount++;
            movie.IDAsString = AssignID(movie);
            movieList.Add(movie);
        }

        public int GetMovieCountByGenre(Genre genre)
        {
            int total = 0;

            foreach (Movie m in movieList)
            {
                if (m.MovieGenre == genre)
                {
                    total++;
                }
            }

            return total;
        }

        public string AssignID(Movie movie)
        {
            string str = "";

            Genre genre = movie.MovieGenre;
            string genreStr = genre.ToString();

            for (int i = 0; i < 3; i++)
            {
                str += genreStr[i];
            }

            int count = 0;

            foreach (Movie mov in movieList)
            {
                if (mov.MovieGenre == genre)
                {
                    count++;
                }
            }

            if (count < 10) { str += "00"; }
            else if (count < 100) { str += "0"; }
            str += count.ToString();

            //movie.IDAsString = str;

            return str;
        }

        public string ReassignID(Movie movie)
        {
            string str = "";

            Genre genre = movie.MovieGenre;
            string genreStr = genre.ToString();

            for (int i = 0; i < 3; i++)
            {
                str += genreStr[i];
            }

            int count = movie.ID;

            //foreach (Movie mov in movieList)
            //{
            //    if (mov.MovieGenre == genre)
            //    {
            //        count++;
            //    }
            //}

            if (count < 10) { str += "00"; }
            else if (count < 100) { str += "0"; }
            str += count.ToString();

            //movie.IDAsString = str;

            return str;
        }

        public void RemoveMovie(Movie movie)
        {
            movieList.Remove(movie);
        }

        public int GetMovieCount()
        {
            return movieList.Count;
        }

        public void SortByGenre()
        {
            List<Movie> newList = new List<Movie>(movieList);

            movieList.Clear();

            int index = 1;

            while (index < 9)
            {
                foreach (Movie m in newList)
                {
                    if (m.MovieGenre == (Genre)index)
                    {
                        movieList.Add(m);
                    }
                }

                index++;
            }
        }

        public void SortByID()
        {
            List<Movie> newList = new List<Movie>(movieList);

            movieList.Clear();

            int moviesChecked = 0;
            int index = 0;

            while (moviesChecked < newList.Count)
            {
                foreach (Movie m in newList)
                {
                    if (m.ID == index)
                    {
                        movieList.Add(m);
                        moviesChecked++;
                    }
                }

                index++;
            }
        }

        public void SortByTitle()
        {
            List<string> movieTitles = new List<string>();

            List<Movie> tempMovieList = new List<Movie>();

            //movieList.Clear();

            foreach (Movie m in movieList)
            {
                movieTitles.Add(m.Title);
            }
            
            movieTitles.Sort();

            foreach (string title in movieTitles)
            {
                Movie movie = GetMovie(title);

                if (movie != null)
                {
                    tempMovieList.Add(movie);
                }
            }

            movieList.Clear();
            movieList = new List<Movie>(tempMovieList);
        }

        public bool FindMovie(string movieTitle)
        {
            foreach (Movie movie in movieList)
            {
                if (movie.Title.ToLower() == movieTitle.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasMoreThanOneMovieByTitle(string movieTitle)
        {
            int count = 0;

            foreach (Movie movie in movieList)
            {
                if (movie.Title.ToLower() == movieTitle.ToLower())
                {
                    count++;
                    //return true;
                }
            }

            return false;
        }
        
        public List<Movie> GetMoviesWithText(string searchText)
        {
            List<Movie> list = new List<Movie>();

            foreach (Movie movie in movieList)
            {
                if (movie.Title.ToLower().Contains(searchText.ToLower() ))
                {
                    list.Add(movie);
                }
            }

            return list;
        }

        public Movie GetMovie(string title)
        {
            foreach (Movie movie in movieList)
            {
                if (movie.Title.ToLower() == title.ToLower())
                {
                    return movie;
                }
            }

            return null;
        }

        public Movie GetMovie(int index)
        {
            if (index >= 0 && index < movieList.Count)
            {
                return movieList[index];
            }

            return null;
        }

        public Movie GetMovieByGenre(Genre genre, int index)
        {
            int count = 0;
            foreach (Movie movie in movieList)
            {
                if (movie.MovieGenre == genre)
                {
                    if (count == index)
                    {
                        return movie;
                    }
                    else
                    {
                        count++;
                    }

                }
            }

            return null;
        }

        public void DeleteMovie(string movieTitle)
        {
            Movie movie = GetMovie(movieTitle);

            movieList.Remove(movie);
        }

        #endregion

        #region Properties
        public string EnterMovieTitleStr { get { return enterMovieTitleStr; } }
        public string SearchMovieTitleStr { get { return searchMovieTitleStr; } }
        public List<Movie> MovieList { get { return movieList; } set { movieList = value; } } 
        #endregion


        public Movie GetRandomMovie(Genre genre)
        {
            Movie movie = null;
            Random rand = new Random();
            int randNum;

            if (genre == Genre.None)
            {
                // pick random out of all genres
                int count = GetMovieCount();

                randNum = rand.Next(0, count);

                movie = GetMovie(randNum);
            }
            else
            {
                // pick random out of all genres
                int count = GetMovieCountByGenre(genre);

                randNum = rand.Next(0, count);

                movie = GetMovieByGenre(genre, randNum);
            }

            return movie;
        }
    }

    public enum Genre
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Action")]
        Action,
        [XmlEnum(Name = "Adventure")]
        Adventure,
        [XmlEnum(Name = "Animation")]
        Animation,
        [XmlEnum(Name = "Comedy")]
        Comedy,
        [XmlEnum(Name = "Horror")]
        Horror,
        [XmlEnum(Name = "Romance")]
        Romance,
        [XmlEnum(Name = "SciFi")]
        SciFi,
        [XmlEnum(Name = "Thriller")]
        Thriller
    }

    public enum DiscType
    {
        [XmlEnum(Name = "DVD")]
        DVD,
        [XmlEnum(Name = "BluRay")]
        BluRay,
        [XmlEnum(Name = "BluRay_DVD")]
        BluRay_DVD,
    }

    public enum MovieRating
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "G")]
        G,
        [XmlEnum(Name = "PG")]
        PG,
        [XmlEnum(Name = "PG13")]
        PG13,
        [XmlEnum(Name = "R")]
        R,
        [XmlEnum(Name = "NC-17")]
        NC_17
    }

    public enum SaveStatus
    {
        Canceled,
        UnSaved,
        Saved,
        CantSave
    }

    public enum LoadStatus
    {
        Canceled,
        Loaded,
        CantLoad
    }
}
