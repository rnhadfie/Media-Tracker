using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface.Enums;

namespace MediaObjects
{
    public class Novel : IBook
    {
        private int _Id;
        private string _Title;
        private ItemStatus _status;
        private List<Languages> _Language;
        private string _Author;
        private List<WrittenGenres> _Genres;

        public Novel()
        {
            
        }

        public Novel(int id, string title, List<Languages> language, string author,
                     List<WrittenGenres> genres)
        {
            _Id = id;
            _Title = title;
            _Language = language;
            _status = ItemStatus.None;
            _Author = author;
            _Genres = genres;
        }

        public string Author
        {
            get
            {
                return _Author;
            }

            set
            {
                _Author = value;
            }
        }

        
        public List<WrittenGenres> Genres
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