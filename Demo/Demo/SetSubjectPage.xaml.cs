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
    public partial class SetSubjectPage : ContentPage
    {
        public SetSubjectPage()
        {
            InitializeComponent();
        }

        async private void Set_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetSubjectDetailPage());
        }
    }
}