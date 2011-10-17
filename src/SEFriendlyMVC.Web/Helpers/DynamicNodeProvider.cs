using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider.Extensibility;
using SEFriendlyMVC.Web.Models;

namespace SEFriendlyMVC.Web.Helpers {

    public class DynamicNodeProvider : DynamicNodeProviderBase {

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection() {

            // Build value 
            var returnValue = new List<DynamicNode>();
            var repo = new SectionRepo();

            // Create a node for each sectionType
            foreach (var item in repo.GetAll()) {

                DynamicNode node = new DynamicNode();
                node.Title = item;
                node.ParentKey = "Home_Index";
                node.RouteValues.Add("type", item.ToLower());
                node.Key = string.Format("{0}_{1}", "section_", item.ToLower());

                returnValue.Add(node);
            }

            // Return 
            return returnValue;
        }
    }
}