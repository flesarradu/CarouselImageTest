using CarouselImagesTest.ViewModel;

namespace CarouselImagesTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MauiAppViewModel();
        }
    }

}
