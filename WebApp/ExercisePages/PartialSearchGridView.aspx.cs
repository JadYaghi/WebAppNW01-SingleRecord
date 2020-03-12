using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using NWSystem.BLL;
using NWSystem.ENTITIES;

namespace WebApp.ExercisePages
{
    public partial class PartialSearchGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SearchProductsPartial_Click(object sender, EventArgs e)
        { }
        //{
        //    if (string.IsNullOrEmpty(PartialProductName.Text))
        //    {
        //        errormsgs.Add("Please enter a partial product name for the search");
        //        LoadMessageDisplay(errormsgs, "alert alert-info");
        //        ProductGridViewV2.DataSource = null;
        //        ProductGridViewV2.DataBind();
        //    }
        //    else
        //    {
        //        try
        //        {
        //            ProductController sysmgr = new ProductController();
        //            List<Product> info = sysmgr.Products_GetByPartialProductName(PartialProductName.Text);
        //            if (info.Count == 0)
        //            {
        //                errormsgs.Add("No data found for the partial product name search");
        //                LoadMessageDisplay(errormsgs, "alert alert-info");
        //            }
        //            else
        //            {
        //                info.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
        //                //load the multiple record control

        //                //GridView
        //                ProductGridViewV2.DataSource = info;
        //                ProductGridViewV2.DataBind();

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            errormsgs.Add(GetInnerException(ex).ToString());
        //            LoadMessageDisplay(errormsgs, "alert alert-danger");
        //        }
        //    }
        //}
    }
}