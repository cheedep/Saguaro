using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Saguaro.Domain.Models;

namespace Saguaro.Domain.Concrete
{
    public class EfDbInitializer : DropCreateDatabaseIfModelChanges<EfDbContext>
    {
        protected override void Seed(EfDbContext context)
        {

            var articles = new List<Article>
                               {
                                    new Article() 
                                    { 
                                        Id = 1, 
                                        AuthorId = 1, 
                                        Title = "Article 1", 
                                        Description = "Description 1", 
                                        Text = "Text 1"
                                    },
                                    new Article() 
                                    { 
                                        Id = 2, 
                                        AuthorId = 1, 
                                        Title = "Article 2", 
                                        Description = "Description 2", 
                                        Text = "Text 2"
                                    }
                               };
            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();
        }

    }
}
