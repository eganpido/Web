using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class Article 
    {
	    public int Id {get; set;}
        public String ArticleCode { get; set; }
        public String ManualArticleCode { get; set; }
        public String ArticleName { get; set; }
	}
}
