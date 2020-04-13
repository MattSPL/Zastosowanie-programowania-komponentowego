using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZegarKomponentPrototyp
{
    public partial class Clock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String h = DateTime.Now.ToString("HH");
            String m = DateTime.Now.ToString("mm");
            String s = DateTime.Now.ToString("ss");
            int hours = Int32.Parse(h);
            int minutes = Int32.Parse(m);
            int seconds = Int32.Parse(s);

            int unityh = hours%10;
            int dozensh = hours-unityh;
            int unitym = minutes % 10;
            int dozensm = minutes - unitym;
            int unitys = seconds % 10;
            int dozenss = seconds - unitys;
            hour(dozensh, unityh);
            Image3.ImageUrl = "dots1.png";
            minute(dozensm, unitym);
            Image6.ImageUrl = "dots1.png";
            second(dozenss, unitys);
        }

        protected void hour(int dozens, int unity)
        {
            switch (dozens)
            {
                case 0:
                    Image1.ImageUrl = "0.png";
                    break;
                case 10:
                    Image1.ImageUrl = "1.png";
                    break;
                case 20:
                    Image1.ImageUrl = "2.png";
                    break;
                default:
                    Image1.ImageUrl = "0.png";
                    break;
            }
            switch (unity)
            {

                case 0:
                    Image2.ImageUrl = "0.png";
                    break;
                case 1:
                    Image2.ImageUrl = "1.png";
                    break;
                case 2:
                    Image2.ImageUrl = "2.png";
                    break;
                case 3:
                    Image2.ImageUrl = "3.png";
                    break;
                case 4:
                    Image2.ImageUrl = "4.png";
                    break;
                case 5:
                    Image2.ImageUrl = "5.png";
                    break;
                case 6:
                    Image2.ImageUrl = "6.png";
                    break;
                case 7:
                    Image2.ImageUrl = "7.png";
                    break;
                case 8:
                    Image2.ImageUrl = "8.png";
                    break;
                case 9:
                    Image2.ImageUrl = "9.png";
                    break;
                default:
                    Image2.ImageUrl = "0.png";
                    break;
            }
        }
        protected void minute(int dozens, int unity)
        {
            switch (dozens)
            {
                case 0:
                    Image4.ImageUrl = "0.png";
                    break;
                case 10:
                    Image4.ImageUrl = "1.png";
                    break;
                case 20:
                    Image4.ImageUrl = "2.png";
                    break;
                case 30:
                    Image4.ImageUrl = "3.png";
                    break;
                case 40:
                    Image4.ImageUrl = "4.png";
                    break;
                case 50:
                    Image4.ImageUrl = "5.png";
                    break;
                default:
                    Image4.ImageUrl = "0.png";
                    break;
            }
            switch (unity)
            {

                case 0:
                    Image5.ImageUrl = "0.png";
                    break;
                case 1:
                    Image5.ImageUrl = "1.png";
                    break;
                case 2:
                    Image5.ImageUrl = "2.png";
                    break;
                case 3:
                    Image5.ImageUrl = "3.png";
                    break;
                case 4:
                    Image5.ImageUrl = "4.png";
                    break;
                case 5:
                    Image5.ImageUrl = "5.png";
                    break;
                case 6:
                    Image5.ImageUrl = "6.png";
                    break;
                case 7:
                    Image5.ImageUrl = "7.png";
                    break;
                case 8:
                    Image5.ImageUrl = "8.png";
                    break;
                case 9:
                    Image5.ImageUrl = "9.png";
                    break;
                default:
                    Image5.ImageUrl = "0.png";
                    break;
            }
        }
        protected void second(int dozens, int unity)
        {
            switch (dozens)
            {
                case 0:
                    Image7.ImageUrl = "0.png";
                    break;
                case 10:
                    Image7.ImageUrl = "1.png";
                    break;
                case 20:
                    Image7.ImageUrl = "2.png";
                    break;
                case 30:
                    Image7.ImageUrl = "3.png";
                    break;
                case 40:
                    Image7.ImageUrl = "4.png";
                    break;
                case 50:
                    Image7.ImageUrl = "5.png";
                    break;
                default:
                    Image7.ImageUrl = "0.png";
                    break;
            }
            switch (unity)
            {

                case 0:
                    Image8.ImageUrl = "0.png";
                    break;
                case 1:
                    Image8.ImageUrl = "1.png";
                    break;
                case 2:
                    Image8.ImageUrl = "2.png";
                    break;
                case 3:
                    Image8.ImageUrl = "3.png";
                    break;
                case 4:
                    Image8.ImageUrl = "4.png";
                    break;
                case 5:
                    Image8.ImageUrl = "5.png";
                    break;
                case 6:
                    Image8.ImageUrl = "6.png";
                    break;
                case 7:
                    Image8.ImageUrl = "7.png";
                    break;
                case 8:
                    Image8.ImageUrl = "8.png";
                    break;
                case 9:
                    Image8.ImageUrl = "9.png";
                    break;
                default:
                    Image8.ImageUrl = "0.png";
                    break;
            }
        }
    }
}