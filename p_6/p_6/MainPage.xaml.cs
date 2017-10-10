using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace p_6
{
    public partial class MainPage : CarouselPage
    {
        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0,total1=0;

        private void btn1_Clicked_1(object sender, EventArgs e)
        {
            total1 = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9;
            lbl1.Text = "Likes Obtenidos:" + total1;
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            c9++;            
            btn9.Text = c9 + "";
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            c8++;
            btn8.Text = c8 + "";

        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            c7++;
            btn7.Text = c7 + "";
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            c6++;
            btn6.Text = c6 + "";
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            c5++;
            btn5.Text = c5 + "";

        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            c4++;
            btn4.Text = c4 + "";

        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            c3++;
            btn3.Text = c3 + "";

        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            c2++;
            btn2.Text = c2 + "";
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            c1++;
            btn1.Text = c1+"";

        }
    }
}
