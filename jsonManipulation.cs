using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleAppForTesting
{
    internal class JsonManipulation
    {
        public void Execute()
        {
            const string url = "https://api.spaceflightnewsapi.net/v3/articles?_limit=100";
            const string fileName = @"C:\articles.json";
            ReadFromUrl(url);
            ReadFromFile(fileName);
        }

        private static void ReadFromUrl(string url)
        {
            var json = new WebClient().DownloadString(url);
            var items = JsonConvert.DeserializeObject<List<Item>>(json);

            if (items == null) return;

            GetArticlesPerPubisherPerMonth(items);
        }

        private static void ReadFromFile(string fileName)
        {
            try
            {
                if (!File.Exists(fileName)) return;
                using (var r = new StreamReader(fileName))
                {
                    var json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<Item>>(json);

                    if (items == null) return;

                    GetArticlesPerPubisherPerMonth(items);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
        }

        private static void GetArticlesPerPubisherPerMonth(IEnumerable<Item> items)
        {
            var sb = new StringBuilder();
            var articles = items.GroupBy(x => new
            {
                x.publishedAt.Month,
                x.newsSite
            }, (key, group) => new
            {
                Key1 = key.Month,
                Key2 = key.newsSite,
                Result = group.ToList()
            });

            foreach (var article in articles)

            {
                sb.AppendLine(article.Result[0].publishedAt.ToString("MMMM yyyy") + "\t" +
                           article.Result[0].newsSite + "\t" +
                           article.Result.Count);
            }

            Console.WriteLine(sb.ToString());
            Console.Read();
        }
    }

    public class Item
    {
        public int id;
        public string newsSite;
        public DateTime publishedAt;
        public string title;
    }
}