using System;
namespace Portal.Data
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ThumbnailUrl { get; set; }

        public bool HasPhotos { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
