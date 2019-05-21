using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home
{
    public partial class Groceries : System.Web.UI.Page
    {
        MovieFunctions movie = new MovieFunctions();

        protected void Page_Load(object sender, EventArgs e)
        {
            var task = movie.SearchByTitleAsync("");
            this.RegisterAsyncTask(new PageAsyncTask(async cancellationToken => {
                movie.SearchByTitleAsync("D");
                // do something with result.
            }));
            
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}