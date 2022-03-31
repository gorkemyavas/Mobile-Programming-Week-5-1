using Xamarin.Forms;

namespace Mobile_Programming_Week_5_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Padding = new Thickness(2);
            Content = new Frame
            {
                BorderColor = Color.Accent,
                BackgroundColor = Color.Green,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = "Çerçeve içerisindeki metin !!!",
                    FontSize = Device.GetNamedSize(NamedSize.Header, typeof(Label)),
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.White,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    BackgroundColor = Color.Tomato
                }
            };
        }
    }
}
