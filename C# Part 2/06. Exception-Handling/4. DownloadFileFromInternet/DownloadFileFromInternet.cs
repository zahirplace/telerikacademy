using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace DownloadFileFromInternet
{
    class DownloadFileFromInternet
    {
        static void Main(string[] args)
        {
            /*
             Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and 
             stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and 
             to free any used resources in the finally block.
            */

            string remoteUri = "http://www.devbg.org/img/Logo-BASD.jpg";
            string fileCopy = @"..\..\Logo-BASD.jpg";

            // Create a WebClient instance
            WebClient webClient = new WebClient();

            try
            {
                // Download the Web resource and save it into the a file fileCopy                       
                webClient.DownloadFile(remoteUri, fileCopy);
                // webClient.DownloadFileAsync(new Uri(remoteUri), fileCopy);
                Console.WriteLine("The file is successfully downloaded!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                webClient.Dispose();  //free the resource 
                Console.WriteLine("End!");
            }


        }

    }
}
