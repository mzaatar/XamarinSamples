using Xamarin.Forms;

namespace Greetings
{
    public class MetricalBoxViewPage : ContentPage
    {
        public MetricalBoxViewPage()
        {
            Content = new BoxView
            {
                Color = Color.Accent,
                WidthRequest = 64,
                HeightRequest = 160,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }
    }
}
