using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConcludePage : ContentPage
    {
        TimeSpan TotalTime; int totalScore;
        public ConcludePage(TimeSpan time, double score)
        {
            InitializeComponent();
            string text = "";
            if (time.Hours > 0)
            {
                text += time.Hours.ToString() + " ชั่วโมง ";
            }
            if (time.Minutes > 0)
            {
                text += time.Minutes.ToString() + " นาที ";
            }
            if (time.Seconds > 0)
            {
                text += time.Seconds.ToString() + " วินาที ";
            }
            txtTimer.Text = "เวลาที่ใช้ในการทำ : " + text;
            txtScore.Text = "ข้อที่ถูกต้อง : " + score.ToString() + " ข้อ จาก 2 ข้อ";
            txtPercent.Text = "ผลการประเมินที่ได้ : " + ((score / 2)*100).ToString() + "%";
            if (((score / 2) * 100) > 50)
            {
                p1.IsVisible = true;
            }
            else
            {
                p2.IsVisible = true;
            }
        }

        async private void Start_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectLevelPage());

        }
    }
}