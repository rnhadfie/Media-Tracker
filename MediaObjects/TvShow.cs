using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;
using Interface.Enums;

namespace MediaObjects
{
    public class TvShow:ITvShow
    {
        private int _Id;
        private List<Languages> _Language;
        private string _Director;
        private List<Interface.VideoGenres> _Genres;
        private Interface.Enums.Ratings _Rating;
        private List<string> _Actors;
        private Interface.ItemStatus _status;
        private string _Title;
        private int _NumberOfSeasons;
        private int _NumberOfEpisodes;

        public TvShow()
        {

        }

        public TvShow(int id, string title, List<Languages> language, List<VideoGenres> genres,
                     string director, List<string> Actors, Ratings rating,
                     int numberOfSeasons, int numberOfEpisodes)
        {
            _Id = id;
            _Title = title;
            _Director = director;
            _Language = language;
            _Rating = rating;
            _Genres = genres;
            _status = ItemStatus.None;
            _Actors = Actors;
            _NumberOfEpisodes = numberOfEpisodes;
            _NumberOfSeasons = numberOfSeasons;


        }

        public List<string> Actors
        {
            get
            {
                return _Actors;
            }

            set
            {
                _Actors = value;
            }
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
                _Genres = value;
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
                _Id = value;
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
                _Language = value;
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
                _Rating = value;
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
                _status = value;
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
                _Title = value;
            }
        }

        public int TotalNumberOfEpisodes
        {
            get
            {
                return _NumberOfEpisodes;
            }

            set
            {
                _NumberOfEpisodes=value;
            }
        }

        public int TotalNumberOfSeasons
        {
            get
            {
                return _NumberOfSeasons;
            }

            set
            {
               _NumberOfSeasons=value;
            }
        }

        
    }
}