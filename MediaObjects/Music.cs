using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface.Enums;

namespace MediaObjects
{
    public class Music : IMusic
    {
        private int _Id;
        private string _Title;
        private string _Artist;
        private List<Languages> _Language;
        private List<string> _Songs;
        private ItemStatus _status;
        private List<MusicGenres> _Genres;

        public Music()
        {
            
        }

        public Music(int id, string title, string artist, List<Languages> language,
                     List<MusicGenres> genres,  List<string> songs)
        {
            _Id = id;
            _Title = title;
            _Artist = artist;
            
            _Language = language;
            _Songs = songs;
            _Genres = genres;
            _status = ItemStatus.None;

        }

        public string Artist
        {
            get
            {
                return _Artist;
            }

            set
            {
                _Artist=value;
            }
        }

        public List<MusicGenres> Genres
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

        public List<string> Songs
        {
            get
            {
                return _Songs;
            }

            set
            {
                _Songs = value;
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
    }
}