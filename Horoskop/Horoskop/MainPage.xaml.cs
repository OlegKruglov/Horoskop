using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Horoskop
{
    public partial class MainPage : ContentPage
    {
        DateTime _changeTime;
        public MainPage()
        {
            InitializeComponent();
        }

        private void dp_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _changeTime = dp.Date;
            if (_changeTime.Month.ToString() == "1")
            {
                img.Source = "capricorn.webp";
            }
            if (_changeTime.Month.ToString() == "2")
            {
                img.Source = "Aquarius.webp";
            }
            if (_changeTime.Month.ToString() == "3")
            {
                img.Source = "pisces.jpg";
            }
            if (_changeTime.Month.ToString() == "4")
            {
                img.Source = "Aries.jpg";
            }
            if (_changeTime.Month.ToString() == "5")
            {
                img.Source = "taurus.jpg";
            }
            if (_changeTime.Month.ToString() == "6")
            {
                img.Source = "gemini.jpg";
            }
            if (_changeTime.Month.ToString() == "7")
            {
                img.Source = "cancer.jpg";
            }
            if (_changeTime.Month.ToString() == "8")
            {
                img.Source = "leo.jpg";

                if (_changeTime.Month.ToString() == "9")
                {
                    img.Source = "Virgo.jpg";
                }
                if (_changeTime.Month.ToString() == "10")
                {
                    img.Source = "libra.jpg";
                }
                if (_changeTime.Month.ToString() == "11")
                {
                    img.Source = "scorpio.jpg";
                }
                if (_changeTime.Month.ToString() == "12")
                {
                    img.Source = "sagittarius.jpg";
                }
            }
        }
    }
}
