using System;
using System.Collections.Generic;
using SportStore.Models.Repository;
using SportStore.Models;
using System.Linq;

namespace SportStore.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        public Repository repo = new Repository();
        private int pageSize = 7;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected IEnumerable<Product> GetProducts()
        {
            return repo.Products
                .OrderBy(p => p.ProductID)
                .Skip((CurrentPage - 1) * pageSize)
                .Take(pageSize);
        }

        protected int CurrentPage
        {
            get
            {
                int page;
                page = int.TryParse(Request.QueryString["page"], out page) ? page : 1;
                return page > MaxPage ? MaxPage : page;
            }
        }

        protected int MaxPage
        {
            get
            {
                return (int)Math.Ceiling((decimal)repo.Products.Count() / pageSize);
            }
        }
    }

}
