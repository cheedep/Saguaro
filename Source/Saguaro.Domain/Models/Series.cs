using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saguaro.Domain.Models
{
    public class Series
    {
        public int Id { get; set; }
        public int Title { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
