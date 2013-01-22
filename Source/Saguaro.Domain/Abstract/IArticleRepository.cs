using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saguaro.Domain.Models;

namespace Saguaro.Domain.Abstract
{
    public interface IArticleRepository
    {
        IQueryable<Article> Articles { get; }
    }
}
