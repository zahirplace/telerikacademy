using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security;

namespace ReadAllText
{
    class ReadAllText
    {
        static void Main(string[] args)
        {
            /*
             Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
             reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
             Be sure to catch all possible exceptions and print user-friendly error messages.
            */

            try
            {                                                  
                Console.WriteLine("Enter the path to the file:");
                string fileName = Console.ReadLine();
                string fileContent = File.ReadAllText(fileName);
                Console.WriteLine("Content of the file:");                 
                Console.WriteLine(fileContent);              
            }

            catch (ArgumentNullException) //path is null. 
            {
                Console.WriteLine("Path is null!");
            }
            catch (ArgumentException) //path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars. 
            {
                Console.WriteLine("Path is a zero-length string, contains only white space or invalid characters!");
            }

            catch (PathTooLongException) //The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. 
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length!");
            }
            catch (FileNotFoundException) //The file specified in path was not found. 
            {
                Console.WriteLine("The file specified in path was not found!");
            }
            catch (DirectoryNotFoundException) //The specified path is invalid (for example, it is on an unmapped drive). 
            {
                Console.WriteLine("The specified path is invalid!");
            }

            catch (IOException) //An I/O error occurred while opening the file.
            {
                Console.WriteLine("An I/O error occurred while opening the file!");
            }

            catch (UnauthorizedAccessException) //An I/O error occurred while opening the file.
            {
                Console.WriteLine("ReadAllText-only File / This is a directory / You don't have permissions!");
            }

            catch (NotSupportedException) //path is in an invalid format. 
            {
                Console.WriteLine("Path is in an invalid format!");
            }

            catch (SecurityException) //The caller does not have the required permission. 
            {
                Console.WriteLine("The caller does not have the required permission!");
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("Good Bye!");
            }

        }
    }
}
