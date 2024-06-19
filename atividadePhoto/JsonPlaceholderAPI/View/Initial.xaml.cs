using JsonPlaceholderAPI.ViewModel;
using Microsoft.Maui.Controls;
namespace JsonPlaceholderAPI.View;

public partial class Initial : ContentPage
{
	public Initial()
	{
        InitializeComponent();
        BindingContext = new PhotosViewModel();
    }
}