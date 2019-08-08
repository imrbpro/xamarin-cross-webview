using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace REstate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void p1Clicked(object sender, EventArgs e)
        {
            UrlBrowse.Source="http://www.google.com?id=1";
        }
        void p2Clicked(object sender, EventArgs e)
        {
            UrlBrowse.Source = "http://m.facebook.com";
        }
        void p3Clicked(object sender, EventArgs e)
        {
            UrlBrowse.Source = "http://www.twitter.com";
        }
        void p4Clicked(object sender, EventArgs e)
        {
            UrlBrowse.Source = "http://www.linkedin.com";
        }
    }
}
