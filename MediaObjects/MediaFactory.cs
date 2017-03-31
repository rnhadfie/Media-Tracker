using Interface;
using Interface.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaObjects
{
    public class MediaFactory
    {
        public IMediaItem CreateBook(string type, int id, string title, string author, 
                                     List<Interface.Enums.Languages> langauge, List<Interface.WrittenGenres> genres)
        {
            if (type.Equals("Novel"))
               return new Novel(id, title, langauge, author,  genres);
            else if (type.Equals("Graphic Novel"))
                return new GraphicNovel(id, title, langauge, author, "",genres);
            else
                return null;
        }

        public IVideoMedia CreateVideo(string type, int id, string title, string director, List<Interface.Enums.Languages> langauge,
                                       List<VideoGenres> genres, List<string> actors, Ratings rating)
        {
            if (type.Equals("TV"))
                return new TvShow(id, title, langauge, genres, director, actors, rating, 0, 0);
            else if (type.Equals("Movie"))
                return new Movie(id, title, langauge, genres, director, actors, rating);
            else
                return null;
        }

        public IMusic CreateAlbum(int id, string title, string artist, List<MusicGenres> genres, 
                                  List<string> songs, List<Interface.Enums.Languages> language)
        {
            return new Music(id, title, artist, language, genres,  songs);
        }
    }
}