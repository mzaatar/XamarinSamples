using Xamarin.Forms;

namespace Greetings
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            var colors = new[]
            {
                new { value = Color.White, name = "White" },
                new { value = Color.Silver, name = "Silver" },
                new { value = Color.Gray, name = "Gray" },
                new { value = Color.Black, name = "Black" },
                new { value = Color.Red, name = "Red" },
                new { value = Color.Maroon, name = "Maroon" },
                new { value = Color.Yellow, name = "Yellow" },
                new { value = Color.Olive, name = "Olive" },
                new { value = Color.Lime, name = "Lime" },
                new { value = Color.Green, name = "Green" },
                new { value = Color.Aqua, name = "Aqua" },
                new { value = Color.Teal, name = "Teal" },
                new { value = Color.Blue, name = "Blue" },
                new { value = Color.Navy, name = "Navy" },
                new { value = Color.Pink, name = "Pink" },
                new { value = Color.Fuchsia, name = "Fuchsia" },

                new { value = Color.Transparent, name = "Transparent" },
                new { value = Color.Accent, name = "Accent" },
                new { value = Color.Purple, name = "Purple" },
            };

            StackLayout stackLayout = new StackLayout();

            foreach (var color in colors)
            {
                stackLayout.Children.Add(
                new Label
                {
                    Text = color.name,
                    TextColor = color.value,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                });

            }

            Padding = new Thickness(5, Device.GetNamedSize(NamedSize.Large, typeof(Label)));
            Content = new ScrollView()
            {
                Content = stackLayout
            };
        }
    }
}
