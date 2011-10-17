using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEFriendlyMVC.Web.Models
{
    public class SectionRepo {

        public string[] GetAll() { 

            return new string[] { 
                "Product", 
                "Article" 
            };
        }

    }
}