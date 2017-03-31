using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface.Enums;

namespace MediaObjects
{
    public class GraphicNovel : IGraphicNovel
    {
        private int _Id;
        private string _Title;
        private ItemStatus _status;
        private List<Languages> _Language;
        private string _Author;
        private string _Artist; 
        private List<WrittenGenres> _Genres;


        public GraphicNovel()
        {

        }

        public GraphicNovel(int id, string title, List<Languages> language, string author, string artist,
                     List<WrittenGenres> genres)
        {
            _Id = id;
            _Title = title;
            _Language = language;
            _status = ItemStatus.None;
            _Author = author;
            _Genres = genres;
            _Artist = artist;  
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

        public string Artist
        {
            get
            {
                return _Artist;
            }

            set
            {
                _Artist = value;
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
    }
}