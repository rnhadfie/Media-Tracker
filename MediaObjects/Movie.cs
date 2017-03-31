using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;
using Interface.Enums;

namespace MediaObjects
{
    public class Movie : IVideoMedia
    {
        private int _Id;
        private List<Languages> _Language;
        private string _Director;
        private List<Interface.VideoGenres> _Genres;
        private Interface.Enums.Ratings _Rating;
        private Interface.ItemStatus _status;
        private string _Title;


        public Movie()
        {
            
        }

        public Movie(int id, string title,List<Languages> language,List<VideoGenres> genres, 
                     string director, List<string> Actors, Ratings rating)
        {
            _Id = id;
            _Title = title;
            _Director = director;
            _Language = language;
            _Rating = rating;
            _Genres = genres;
            _status = ItemStatus.None;
        }

        public string Director
        {
            get
            {
                return _Director;
            }

            set
            {
                _Director = value;
            }
        }

        public List<VideoGenres> Genres
        {
            get
            {
                return _Genres;
            }

            set
            {
                _Genres=value;
            }
        }

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id=value;
            }
        }

        public List<Languages> Languages
        {
            get
            {
               return _Language;
            }

            set
            {
                _Language=value;
            }
        }

        public Ratings Rating
        {
            get
            {
               return _Rating;
            }

            set
            {
                _Rating=value;
            }
        }

        public ItemStatus status
        {
            get
            {
                return _status;
            }

            set
            {
                _status=value;
            }
        }

        public string Title
        {
            get
            {
                return _Title;
            }

            set
            {
                _Title=value;
            }
        }
    }
}