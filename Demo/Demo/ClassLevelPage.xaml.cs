using Syncfusion.SfCarousel.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassLevelPage : ContentPage
    {
        public ClassLevelPage()
        {
            InitializeComponent();
            //InitializeComponent();
            //SfCarousel carousel = new SfCarousel()
            //{
            //    ItemWidth = 170,
            //    ItemHeight = 250
            //};

            //ObservableCollection<SfCarouselItem> carouselItems = new ObservableCollection<SfCarouselItem>();
            //carouselItems.Add(new SfCarouselItem() { ImageName = "edu1.png", BackgroundColor = Color.Transparent });
            //carouselItems.Add(new SfCarouselItem() { ImageName = "edu1.png", BackgroundColor = Color.Transparent });
            //carouselItems.Add(new SfCarouselItem() { ImageName = "edu1.png", BackgroundColor = Color.Transparent });
            //carouselItems.Add(new SfCarouselItem() { ImageName = "edu1.png", BackgroundColor = Color.Transparent });
            //carouselItems.Add(new SfCarouselItem() { ImageName = "edu1.png", BackgroundColor = Color.Transparent });
            //carousel.ItemsSource = carouselItems;

            //this.Content = carousel;
        }

        async private void Level_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectSubjectPage());
        }

        private void Carousel_SelectionChanged(object sender, Syncfusion.SfCarousel.XForms.SelectionChangedEventArgs e)
        {
            int count = (sender as SfCarousel).SelectedIndex + 1;
            DisplayAlert("SelectionChanged", "Carousel item:" + count + " has Selected", "Ok");
        }
    }
}