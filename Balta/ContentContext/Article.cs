using System.Collections.Generic;
using Balta.NotificationContext;

namespace Balta.ContentContext {
    public class Article : Content {

        
        public Article(string title, string url)
            : base(title, url) //Passando para a classe pai
        {
            
        }
    }
}