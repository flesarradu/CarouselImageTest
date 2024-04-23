using CommunityToolkit.Mvvm.ComponentModel;

namespace CarouselImagesTest.ViewModel
{
    /// <summary>
    /// CarouselImageItemViewModel.
    /// </summary>
    public partial class CarouselImageItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _imagePath;
    }
}
