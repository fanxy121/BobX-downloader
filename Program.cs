using System;
using System.Net;

namespace pacificgirls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Starting to get photos，enjoy the photos!!");
            //2823673  The Ablum start number
            //2825044  The Ablum end number
            //There are pacificgirls_924 ablum number,you can change it yourself
            for (int i = 2823673; i < 2825044; i++)
            {
                string staticUrl = "http://www.bobx.com/av-idol/haruka-pacificgirls/haruka-pacificgirls-0" + i + ".jpg";
                getPhoto(staticUrl, i);
            }
        }

        public static void getPhoto(string photoUrl,int pici)
        {
            try
            {
                string saveName = photoUrl.Replace(photoUrl.Substring(1, photoUrl.LastIndexOf('/')), "");
                string filepath = "Photo\\" + saveName;
                WebClient mywebclient = new WebClient();
                mywebclient.Headers.Add("cookie", "SurferLoyaltyRewards=13216697045213922056");
                mywebclient.Headers.Add("referer", "http://www.bobx.com/av-idol/haruka-pacificgirls/large-haruka-pacificgirls-" + pici + ".html");
                mywebclient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3809.87 Safari/537.36");
                mywebclient.DownloadFile(photoUrl, filepath);
                Console.WriteLine(photoUrl + " done once\r\n");
            }
            catch {
            }
        }
    }
}
