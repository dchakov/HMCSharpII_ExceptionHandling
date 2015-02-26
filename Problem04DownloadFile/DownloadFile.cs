//Problem 4. Download file• Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//• Find in Google how to download files in C#.
//• Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Please, enter url");
        string url = Console.ReadLine(); // http://telerikacademy.com/Content/Images/news-img01.png 

        string fileName = url.Substring(url.LastIndexOf('/') + 1, url.Length - url.LastIndexOf('/') - 1);

        try
        {
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(url, fileName);
        }
        catch (WebException we)
        {
            Console.WriteLine(we.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, url);
            Console.WriteLine("Good day");
            
        }
    }
}