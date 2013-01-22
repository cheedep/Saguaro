using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saguaro.Domain.Abstract;

namespace Saguaro.Domain.Concrete
{
    public class EfArticleRepository : IArticleRepository
    {
        private EfDbContext context = new EfDbContext();

        public IQueryable<Models.Article> Articles
        {
            get { return context.Articles; }
        }
    }
}
