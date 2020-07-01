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
    public partial class SetSubjectDetailPage : ContentPage
    {
        public SetSubjectDetailPage()
        {
            InitializeComponent();
        }

        async private void Set_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChooseQuizPage());
        }
    }
}