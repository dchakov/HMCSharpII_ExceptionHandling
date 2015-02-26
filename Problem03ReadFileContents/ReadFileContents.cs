//Problem 3. Read file contents
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.Text;
using System.IO;
using System.Security;

class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Please, enter file path");
        string path = Console.ReadLine(); // C:\WINDOWS\win.ini
        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentNullException arn)
        {
            Console.WriteLine(arn.Message); ;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message); ;
        }
        catch (PathTooLongException pat)
        {
            Console.WriteLine(pat.Message); ;
        }
        catch (DirectoryNotFoundException dir)
        {
            Console.WriteLine(dir.Message); ;
        }
        catch (FileNotFoundException fil)
        {
            Console.WriteLine(fil.Message); ;
        }
        catch (IOException io)
        {
            Console.WriteLine(io.Message); ;
        }
        catch (UnauthorizedAccessException ua)
        {
            Console.WriteLine(ua.Message); ;
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message); ;
        }
        catch (SecurityException sec)
        {
            Console.WriteLine(sec.Message); ;
        }
    }
   
}
