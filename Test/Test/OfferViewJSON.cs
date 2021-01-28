using System;
using System.Text;
//using System.Diagnostics;
using Xamarin.Forms;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;

namespace Test
{
    public class OfferViewJSON : ContentPage
    {
        public OfferViewJSON(Offer tappedOffer)
        {

            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, // для красоты убираем null значения
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string offerjson = JsonSerializer.Serialize<Offer>(tappedOffer, options);




            ScrollView scrollView = new ScrollView // прокрутка страницы
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new StackLayout
                {
                    Children =
                {
                    new Label
                    {
                        Text = offerjson,
                    },
                }
                }
            };

            Content = new StackLayout
            {
                Children = { scrollView }
            };
        }
    }
}