using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Test
{
	[XmlRoot(ElementName = "currency")]
	public class Currency
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "rate")]
		public string Rate { get; set; }
		[XmlAttribute(AttributeName = "plus")]
		public string Plus { get; set; }
	}

	[XmlRoot(ElementName = "currencies")]
	public class Currencies
	{
		[XmlElement(ElementName = "currency")]
		public Currency Currency { get; set; }
	}

	[XmlRoot(ElementName = "category")]
	public class Category
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlText]
		public string Text { get; set; }
		[XmlAttribute(AttributeName = "parentId")]
		public string ParentId { get; set; }
	}

	[XmlRoot(ElementName = "categories")]
	public class Categories
	{
		[XmlElement(ElementName = "category")]
		public List<Category> Category { get; set; }
	}

	[XmlRoot(ElementName = "categoryId")]
	public class CategoryId
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "offer")]
	public class Offer
	{
		[XmlElement(ElementName = "url")]
		public string Url { get; set; }
		[XmlElement(ElementName = "price")]
		public string Price { get; set; }
		[XmlElement(ElementName = "currencyId")]
		public string CurrencyId { get; set; }
		[XmlElement(ElementName = "categoryId")]
		public CategoryId CategoryId { get; set; }
		[XmlElement(ElementName = "picture")]
		public string Picture { get; set; }
		[XmlElement(ElementName = "delivery")]
		public string Delivery { get; set; }
		[XmlElement(ElementName = "local_delivery_cost")]
		public string Local_delivery_cost { get; set; }
		[XmlElement(ElementName = "typePrefix")]
		public string TypePrefix { get; set; }
		[XmlElement(ElementName = "vendor")]
		public string Vendor { get; set; }
		[XmlElement(ElementName = "vendorCode")]
		public string VendorCode { get; set; }
		[XmlElement(ElementName = "model")]
		public string Model { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "manufacturer_warranty")]
		public string Manufacturer_warranty { get; set; }
		[XmlElement(ElementName = "country_of_origin")]
		public string Country_of_origin { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "bid")]
		public string Bid { get; set; }
		[XmlAttribute(AttributeName = "cbid")]
		public string Cbid { get; set; }
		[XmlAttribute(AttributeName = "available")]
		public string Available { get; set; }
		[XmlElement(ElementName = "author")]
		public string Author { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "publisher")]
		public string Publisher { get; set; }
		[XmlElement(ElementName = "series")]
		public string Series { get; set; }
		[XmlElement(ElementName = "year")]
		public string Year { get; set; }
		[XmlElement(ElementName = "ISBN")]
		public string ISBN { get; set; }
		[XmlElement(ElementName = "volume")]
		public string Volume { get; set; }
		[XmlElement(ElementName = "part")]
		public string Part { get; set; }
		[XmlElement(ElementName = "language")]
		public string Language { get; set; }
		[XmlElement(ElementName = "binding")]
		public string Binding { get; set; }
		[XmlElement(ElementName = "page_extent")]
		public string Page_extent { get; set; }
		[XmlElement(ElementName = "downloadable")]
		public string Downloadable { get; set; }
		[XmlElement(ElementName = "performed_by")]
		public string Performed_by { get; set; }
		[XmlElement(ElementName = "performance_type")]
		public string Performance_type { get; set; }
		[XmlElement(ElementName = "storage")]
		public string Storage { get; set; }
		[XmlElement(ElementName = "format")]
		public string Format { get; set; }
		[XmlElement(ElementName = "recording_length")]
		public string Recording_length { get; set; }
		[XmlElement(ElementName = "artist")]
		public string Artist { get; set; }
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "media")]
		public string Media { get; set; }
		[XmlElement(ElementName = "starring")]
		public string Starring { get; set; }
		[XmlElement(ElementName = "director")]
		public string Director { get; set; }
		[XmlElement(ElementName = "originalName")]
		public string OriginalName { get; set; }
		[XmlElement(ElementName = "country")]
		public string Country { get; set; }
		[XmlElement(ElementName = "worldRegion")]
		public string WorldRegion { get; set; }
		[XmlElement(ElementName = "region")]
		public string Region { get; set; }
		[XmlElement(ElementName = "days")]
		public string Days { get; set; }
		[XmlElement(ElementName = "dataTour")]
		public List<string> DataTour { get; set; }
		[XmlElement(ElementName = "hotel_stars")]
		public string Hotel_stars { get; set; }
		[XmlElement(ElementName = "room")]
		public string Room { get; set; }
		[XmlElement(ElementName = "meal")]
		public string Meal { get; set; }
		[XmlElement(ElementName = "included")]
		public string Included { get; set; }
		[XmlElement(ElementName = "transport")]
		public string Transport { get; set; }
		[XmlElement(ElementName = "place")]
		public string Place { get; set; }
		[XmlElement(ElementName = "hall")]
		public Hall Hall { get; set; }
		[XmlElement(ElementName = "hall_part")]
		public string Hall_part { get; set; }
		[XmlElement(ElementName = "date")]
		public string Date { get; set; }
		[XmlElement(ElementName = "is_premiere")]
		public string Is_premiere { get; set; }
		[XmlElement(ElementName = "is_kids")]
		public string Is_kids { get; set; }
	}

	[XmlRoot(ElementName = "hall")]
	public class Hall
	{
		[XmlAttribute(AttributeName = "plan")]
		public string Plan { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "offers")]
	public class Offers
	{
		[XmlElement(ElementName = "offer")]
		public List<Offer> Offer { get; set; }
	}

	[XmlRoot(ElementName = "shop")]
	public class Shop
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "company")]
		public string Company { get; set; }
		[XmlElement(ElementName = "url")]
		public string Url { get; set; }
		[XmlElement(ElementName = "currencies")]
		public Currencies Currencies { get; set; }
		[XmlElement(ElementName = "categories")]
		public Categories Categories { get; set; }
		[XmlElement(ElementName = "local_delivery_cost")]
		public string Local_delivery_cost { get; set; }
		[XmlElement(ElementName = "offers")]
		public Offers Offers { get; set; }
	}

	[XmlRoot(ElementName = "yml_catalog")]
	public class Yml_catalog
	{
		[XmlElement(ElementName = "shop")]
		public Shop Shop { get; set; }
		[XmlAttribute(AttributeName = "date")]
		public string Date { get; set; }
	}

}

