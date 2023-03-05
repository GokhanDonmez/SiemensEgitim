using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;
using static System.Net.WebRequestMethods;
using System.IO;
using vatanBilgisayaeScrape;

namespace vatanBilgisayarScrape
{
    // Research Project

    // Projedeki bugların bulunması ve fix'lenmesi.
    // Kullanılan teknik ve özelliklerin araştırılması.
    // Projeyi modüler hale getirmek : Özellikleri parçalar halinde farklı metotlara dönüştürmek.
    // Projeye yeni scraping özelliklerinin eklenmesi(ayrı metotlar olarak) : Yeni sayfalar, sayfalardan farklı verilerin çıkarımlanması(extraction)
    // Projenin programsal hata olasılıklarının çıkarılması ve bunlara karşı güçlendirilmesi.
    // Projenin çıkarımladığı veriyi(data extraction) TXT olarak saklanması.
    // Projenin bir CLI olarak çalışmasının sağlanması.
    // Main(string[] args) -> args'ı terminal üzerinden kullanmak.
    // "crawl.exe target==abc.com" olarak çalıştırmak.
    /*



        */
    // website : https://www.vatanbilgisayar.com/notebook/
    // website : https://www.vatanbilgisayar.com/
    internal class Program
    {

        private static string product_card_query = "//div[@id='productsLoad']//div[@class='product-list product-list--list-page']";

        private const string BASE_URI = "https://www.vatanbilgisayar.com/notebook/";
        static void Main(string[] args)
        {
            string URL = BASE_URI;
            
            while (true)
            {
                string target = args[0].Split('=')[1];
                if (target == "vatanbilgisayar.com")
                {
                    target = "https://www." + target + "//notebook//";

                    List<Product> product_list = new List<Product>();

                    HtmlWeb web = new HtmlWeb();
                    web.PreRequest += PreRequest;
                    int pageNumber = 1;

                    while (true)
                    {
                        try
                        {
                            NameValueCollection nvc = new NameValueCollection();
                            nvc["page"] = pageNumber.ToString();
                            string preparedUri = target + ToQueryString(nvc);
                            HtmlDocument doc = web.Load(preparedUri);

                            var products = doc.DocumentNode.SelectNodes(product_card_query);
                            if (products == null)
                            {
                                Console.WriteLine("Tarama Bitti");
                                break;
                            }

                            foreach (var productDiv in products)
                            {
                                Product new_product = new Product();


                                var product_url_node = productDiv.SelectSingleNode(".//div[1]//a");


                                if (product_url_node != null)
                                    new_product.ProductUri = BASE_URI + product_url_node.Attributes["href"].Value;

                                var product_image_node =
                                    productDiv.SelectSingleNode(".//div[@class='slider-img']//img");

                                string product_image_url = string.Empty;
                                if (product_image_node != null)
                                    new_product.ProductImageUri = product_image_node.Attributes["data-src"].Value;

                                var title_node =
                                    productDiv.SelectSingleNode(".//div[@class='product-list__product-name']//h3");


                                if (title_node != null)
                                    new_product.ProductTitle = title_node.InnerText;

                                var price_node =
                                    productDiv.SelectSingleNode(".//div[@class='product-list__cost']//span[1]");
                                if (price_node != null)
                                    new_product.ProductPrice = price_node.InnerText;

                                product_list.Add(new_product);

                            }

                            pageNumber++;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.StackTrace);
                            break;
                        }
                    }


                    string dosyaAdi = @"C:\Users\Z004PUVZ\Desktop\proje\Belgeler\veriler.txt";
                    using (StreamWriter writer = new StreamWriter(dosyaAdi))
                    {
                        foreach (var product in product_list)
                        {
                            writer.WriteLine(product.ProductUri);
                        }
                    }

                    Console.WriteLine("Scrape işlemleri başarılı şekilde tamamlandı.");
                    break;
                }
                else
                {
                    Console.WriteLine("Try Again");
                }

            }


        }

        private static bool PreRequest(HttpWebRequest request)
        {
            request.AllowAutoRedirect = false;
            return true;
        }

        public static string ToQueryString(NameValueCollection nvc)
        {
            var array = (
                from key in nvc.AllKeys
                from value in nvc.GetValues(key)
                select string.Format(
                    "{0}={1}",
                    HttpUtility.UrlEncode(key),
                    HttpUtility.UrlEncode(value))
            ).ToArray();
            return "?" + string.Join("&", array);
        }
    }
}
