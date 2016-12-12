using Xamarin.Forms;

namespace Greetings
{
    public class FramedTextPage : ContentPage
    {
        public FramedTextPage()
        {
            Padding = new Thickness(20);
            Content = new Frame
            {
                OutlineColor = Color.Accent,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = "I've been framed!",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                }
            };
        }
    }
}