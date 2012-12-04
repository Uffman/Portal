using System;

namespace Portal.Data
{
    public class Photo
    {
        public string PhotoId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string ThumbnailUrl { get; set; }

        public string AlbumId { get; set; }

        public string RawTags { get; set; }

        public DateTime DateCreated { get; set; }
        
    }
}
