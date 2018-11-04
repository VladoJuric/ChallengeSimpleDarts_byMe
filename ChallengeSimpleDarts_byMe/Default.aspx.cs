using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts_byMe
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int gameType = (int) (ViewState["gameType"]);

            Game game = new Game("Ante","Ivan", gameType);
            resultLabel.Text = game.Play().ToString();
        }

        protected void game301Button_Click(object sender, EventArgs e)
        {
            ViewState["gameType"] = 301;
        }

        protected void game501Button_Click(object sender, EventArgs e)
        {
            ViewState["gameType"] = 501;
        }

        protected void game701Button_Click(object sender, EventArgs e)
        {
            ViewState["gameType"] = 701;
        }

        protected void game1001Button_Click(object sender, EventArgs e)
        {
            ViewState["gameType"] = 1001;
        }
    }
}