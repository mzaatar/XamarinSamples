using Xamarin.Forms;

namespace Greetings
{
    public class SizedBoxViewPage : ContentPage
    {
        public SizedBoxViewPage()
        {
            BackgroundColor = Color.Pink;
            Content = new BoxView
            {
                Color = Color.Navy,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 200,
                HeightRequest = 100
            };
        }
    }
}
