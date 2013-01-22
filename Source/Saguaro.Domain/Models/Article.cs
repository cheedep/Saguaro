using System;
using System.Collections.Generic;

namespace Saguaro.Domain.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateEdited { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public int? SeriesId { get; set; }
        public virtual Series Series { get; set; }
    }
}
