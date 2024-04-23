using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CarouselImagesTest.ViewModel
{
    public partial class MauiAppViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<CarouselImageItemViewModel> _images;

        public MauiAppViewModel()
        {
            Images =
            [
                new CarouselImageItemViewModel { ImagePath = "https://images.pexels.com/photos/1403653/pexels-photo-1403653.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                new CarouselImageItemViewModel {ImagePath = "https://images.pexels.com/photos/268481/pexels-photo-268481.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"},
                new CarouselImageItemViewModel {ImagePath = "https://images.pexels.com/photos/2306831/pexels-photo-2306831.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"},
            ];
        }
    }
}
