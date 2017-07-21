using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.ApiControllers
{
    public class ArticleController : ApiController
    {
        private Data.sample_dbDataContext db = new Data.sample_dbDataContext();

        [HttpGet]
        [Authorize]
        [Route("api/list/article")]
        public List<Entities.Article> listArticle()
        {
            var articles = from d in db.MstArticles.OrderBy(d => d.Article)
                           select new Entities.Article
                           {
                               Id = d.Id,
                               ArticleCode = d.ArticleCode,
                               ManualArticleCode = d.ManualArticleCode,
                               ArticleName = d.Article
                           };

            return articles.ToList();
        }

    }
}
