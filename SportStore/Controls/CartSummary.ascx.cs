﻿using System;
using System.Linq;
using System.Web.Routing;
using SportStore.Models;
using SportStore.Pages.Helpers;

namespace SportStore.Controls
{
    public partial class CartSummary : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Cart myCart = SessionHelper.GetCart(Session);
            csQuantity.InnerText = myCart.Lines.Sum(x => x.Quantity).ToString();
            csTotal.InnerText = myCart.ComputeTotalValue().ToString("c");
            csLink.HRef = RouteTable.Routes.GetVirtualPath(null, "cart", null).VirtualPath;
        }
    }
}