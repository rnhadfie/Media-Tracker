using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MediaObjectLibrary.Books
{
    public class Header {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public List<BookItems> items { get; set; }
        public List<BookItems> Books { get; set; }
    
    }
   public class BookItems
    {
        public string kind { get; set; }
        public string id { get; set; }
        public string eTag { get; set; }
        public string selfLink { get; set; }
       
        public BookInfo volumeInfo { get; set; }
        public SalesInfo saleInfo { get; set; }
        public AccessInfo accessInfo { get; set; }
        public SearchInfo searchInfo { get; set; }

        public string Status { get; set; }
    }

    public class BookInfo
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public List<string> authors { get; set; }
        public string publisher { get; set; }
        public string description { get; set; }

        public string publishedDate { get; set; }
       
        
        public int pageCount { get; set; }
        public string printType {get; set;}
        public List<string> categories { get; set; }
        public string maturityRating { get; set; }
        public ImageFile imageLinks { get; set; }
        public string language {get; set;}
    }

    public class ImageFile
    {
        public string smallThumbnail { get; set; }
        public string thumbnail { get; set; }
    }

    public class IndustryIdentifies
    {
        public string type { get; set;}
        public string identifies { get; set; }
    }

    public class SalesInfo
    {
        public string country { get; set; }
        
        public string saleability { get; set; }
        public bool isEbook { get; set; }
    }

    public class AccessInfo
    {
        public string country { get; set; }
        public string viewability { get; set; }

        public bool embeddable {get;set;}
        public bool publicDomain { get;set;}
        public string textToSpeechPermission { get;set;}

        public EPUB epub { get; set; }
        public PDF pdf { get; set; }

        public string webReaderLink { get; set; }

        public string accessViewStatus { get; set; }

        public bool quoteSharingAllowed { get; set; }
    }
    public class EPUB
    {public bool isAvailable {get;set;} }
    public class PDF
    { public bool isAvailable { get; set; } }
    public class SearchInfo {
        public string textSnippet { get; set; }
    }


}
