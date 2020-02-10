using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Movie_Library
{
    [Serializable]
    public class Movie
    {
        // Title
        private string title;
        private string displayedTitle;

        [XmlEnum("Genre")]
        private Genre genre;

        [XmlEnum("DiscType")]
        private DiscType discType;

        // ID
        private int id;
        private string idAsString;

        DateTime movieLength;

        int movieYear;

        [XmlEnum("Rating")]
        MovieRating rating;

        DateTime releaseDate;

        string movieDescription;

        List<string> directors;

        List<string> writers;

        List<string> actors;

        public Movie()
        {
            if (title == null || title == "")
            {
                title = "New Movie";
            }

            movieLength = new DateTime();
            releaseDate = new DateTime();
            directors = new List<string>();
            writers = new List<string>();
            actors = new List<string>();

            //if (movieDescription == null || movieDescription == "")
            //{
            //    movieDescription = "Movie Description";
            //}

            genre = (Genre)0;
            discType = (DiscType)0;
            rating = (MovieRating)0;
        }

        [XmlElement("Title")]
        public string Title { get { return title; } set { title = value; } }

        public string DisplayedTitle { get { return displayedTitle; } set { displayedTitle = value; } }
        
        public Genre MovieGenre { get { return genre; } set { genre = value; } }

        public DiscType TypeOfDisc { get { return discType; } set { discType = value; } }

        public string IDAsString { get { return idAsString; } set { idAsString = value; } }

        [XmlElement("Length")]
        public DateTime MovieLength { get { return movieLength; } set { movieLength = value; } }

        [XmlElement("Year")]
        public int MovieYear { get { return movieYear; } set { movieYear = value; } }

        public MovieRating Rating { get { return rating; } set { rating = value; } }

        [XmlElement("ReleaseDate")]
        public DateTime ReleaseDate { get { return releaseDate; } set { releaseDate = value; } }

        [XmlElement("MovieDescription")]
        public string MovieDescription { get { return movieDescription; } set { movieDescription = value; } }

        [XmlArray(ElementName = "DirectorsList")]
        public List<string> Directors { get { return directors; } set { directors = value; } }

        [XmlArray(ElementName = "WritersList")]
        public List<string> Writers { get { return writers; } set { writers = value; } }

        [XmlArray(ElementName = "ActorsList")]
        public List<string> Actors { get { return actors; } set { actors = value; } }

        [XmlAttribute("ID")]
        public int ID { get { return id; } set { id = value; } }

    }

}
