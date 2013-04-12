using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Helloworldmulticharp.Library;

namespace Helloworldmulticharp
{
    public partial class hwmulticsharp : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            Table tbl = new Table();
            tbl.ID = "table1";

            this.Controls.Add(tbl);

            for (int row = 0; row < 5; row++)
            {
                TableRow rw = new TableRow();
                TableCell cell = new TableCell();
                Label text = new Label();
                string s = "";

                s = Test.RemoveSpaces(s);

                text.Text = s;
                cell.Controls.Add(text);
                rw.Cells.Add(cell);
                tbl.Rows.Add(rw);

                tbl.Controls.Add(rw);
            }
        }
    }
}

