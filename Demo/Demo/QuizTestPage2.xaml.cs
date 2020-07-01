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
    public partial class QuizTestPage2 : ContentPage
    {
        TimeSpan TotalTime; double totalScore;
        public QuizTestPage2(TimeSpan time, double score)
        {
            InitializeComponent();
            totalScore = score;
            txtScore.Text = "คะแนน " + score.ToString();
            TotalTime = time;
            RunTimer(true);
        }

        async private void A_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("แจ้งเตือน", "ถูกต้อง", "ok");
            await Navigation.PushAsync(new ConcludePage(TotalTime, totalScore + 1));
        }

        async private void B_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("แจ้งเตือน", "คำตอบไม่ถูกต้อง", "ok");
            await Navigation.PushAsync(new ConcludePage(TotalTime, totalScore + 0));
        }

        async private void C_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("แจ้งเตือน", "คำตอบไม่ถูกต้อง", "ok");
            await Navigation.PushAsync(new ConcludePage(TotalTime, totalScore + 0));
        }

        async private void D_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("แจ้งเตือน", "คำตอบไม่ถูกต้อง", "ok");
            await Navigation.PushAsync(new ConcludePage(TotalTime, totalScore + 0));
        }
        async public void RunTimer(Boolean Value)
        {
            Boolean excuteTimer = Value;
            TimeSpan TimeElement = new TimeSpan();

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                if (Value)
                {
                    TotalTime = TotalTime + TimeElement.Add(new TimeSpan(0, 0, 1));
                    txtTime.Text = string.Format("{0:hh\\:mm\\:ss}", TotalTime);
                    // returning true will fire task again in 2 minutes.
                    return true;
                }
                // No longer need to recur. Stops firing task
                return false;
            });


        }
    }
}