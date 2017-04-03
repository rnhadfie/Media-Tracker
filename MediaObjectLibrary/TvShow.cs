using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaObjectsInterface;

namespace MediaObjectLibrary
{
    class TvShow : ITvShow
    {
        private string _Id, _title, _Rating, _Released, _Runtime, _Plot, _Years;
        private string[] _Genre, _Actors, _Language, _Director, _Writers;
        private int _Seasons;
        private MediaStatus status = MediaStatus.NA;


        public TvShow()
        { }
        public TvShow(string id, string title)
        {
            _Id = id;
            _title = title;
        }
        public TvShow(string id, string title, string rating, string released, string plot)
        {
            _Id = id;
            _title = title;
            _Rating = rating;
            _Released = released;
            _Plot = plot;
        }
        public TvShow(string id, string title, string rating, string released, string plot, string runtime)
        {
            _Id = id;
            _title = title;
            _Rating = rating;
            _Released = released;
            _Plot = plot;
            _Runtime = runtime;
        }
        public TvShow(string id, string title, string rating, string released, string plot, string runtime, int season, string years)
        {
            _Id = id;
            _title = title;
            _Rating = rating;
            _Released = released;
            _Plot = plot;
            _Runtime = runtime;
            _Seasons = season;
            _Years = years;
        }
        public TvShow(string id, string title, string rating, string released, string plot, string runtime,
                     string[] genre, string[] actors, string[] language, string[] director, string[] writers,
                        int season, string year)
        {
            _Id = id;
            _title = title;
            _Rating = rating;
            _Released = released;
            _Plot = plot;
            _Runtime = runtime;
            _Genre = genre;
            _Actors = actors;
            _Language = language;
            _Director = director;
            _Writers = writers;
            _Seasons = season;
            _Years = year;
        }
        public string[] Actors
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

        public string[] Director
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

        public string[] Genre
        {
            get
            {
                return _Genre;
            }

            set
            {
                _Genre = value;
            }
        }

        public string[] Langauge
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

        public string Plot
        {
            get
            {
                return _Plot;
            }

            set
            {
                _Plot = value;
            }
        }

        public string Rating
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

        public string Runtime
        {
            get
            {
                return _Runtime;
            }

            set
            {
                _Runtime = value;
            }
        }

        public int Seasons
        {
            get
            {
                return _Seasons;
            }

            set
            {
                _Seasons=value;
            }
        }

        public string[] Writers
        {
            get
            {
                return _Writers;
            }

            set
            {
                _Writers = value;
            }
        }

        public string Years
        {
            get
            {
               return _Years;
            }

            set
            {
                _Years=value;
            }
        }

        public string ID
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

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string YearReleased
        {
            get
            {
                return _Released;
            }

            set
            {
                _Released = value;
            }
        }
        public MediaStatus Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
