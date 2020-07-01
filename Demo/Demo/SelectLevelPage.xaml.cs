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
    public partial class SelectLevelPage : ContentPage
    {
        public SelectLevelPage()
        {
            InitializeComponent();
        }

        async private void Level_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClassLevelPage());
        }

        async private void Group_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetSubjectPage());
        }
    }
}