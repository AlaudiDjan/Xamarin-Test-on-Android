using Xamarin.Forms;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
//using System.Diagnostics;
using System.IO;

namespace Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Label header = new Label
            {
                Text = "Список офферов",
                TextColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            header.HorizontalOptions = LayoutOptions.Center;

            List<Offer> x = new List<Offer>(GetXml().Result.Shop.Offers.Offer.Count);
            foreach(Offer offer in GetXml().Result.Shop.Offers.Offer)
            {
                x.Add(offer); // собираем в лист все офферы
            }

            var listView = new ListView // отображаем список номеров офферов
            { 
                IsPullToRefreshEnabled = true,
                RefreshControlColor = Color.Gray,
                ItemsSource = x,
                SelectionMode = ListViewSelectionMode.None,
                ItemTemplate = new DataTemplate(() =>
                {
                    TextCell textCell = new TextCell { TextColor = Color.Blue};
                    textCell.SetBinding(TextCell.TextProperty, "Id");
                    return textCell;
                })
            };
            listView.ItemTapped += OfferJSON;
            this.Content = new StackLayout { Children = { header, listView } };
        }

        private async void OfferJSON(object sender, ItemTappedEventArgs e) // открытие нового экрана при нажатии на номер оффера
        {
            Offer tappedItem = e.Item as Offer;
            await Navigation.PushAsync(new OfferViewJSON(tappedItem));
        }

        public Task<Yml_catalog> GetXml() // получаем xml с сервера
        {
            HttpClient client = new HttpClient();
            Yml_catalog catalog;
            var xmlstring = Task.Run(async () =>
            {
                using (StreamReader reader = new StreamReader(await client.GetStreamAsync("http://partner.market.yandex.ru/pages/help/YML.xml"), System.Text.Encoding.GetEncoding(1251)))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Yml_catalog));
                    catalog = (Yml_catalog)xs.Deserialize(reader);
                }
                return catalog;
            });
            return xmlstring;
        }
    }
}