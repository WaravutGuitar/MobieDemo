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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent(); 
        }
        async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectLevelPage()); 
        }

        void SingUp_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sing up", "Please contact HR for create new user กรุณาติดต่อฝ่ายบุคคลสำหรับการสร้างผู้ใช้งานใหม่", "OK");
        }
    }
}