using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;
using XmlLibrary;
using static System.Console;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("=== XML Reader ===");

            // Path with files to read.
            string path = @"C:\Users\Michael\Downloads\MFaaP Vault\file-monitor\samples";

            // Attempt to find path.
            var directoryInfo = new DirectoryInfo(path);

            // Identify the type of files to search for.
            string searchPattern = "*.xml";
            string[] xPathQuery = { ".//Invoice_number", ".//Invoice_date", ".//PO_number" };

            foreach (var file in directoryInfo.GetFiles(searchPattern))
            {
                XDocument xDocument = XDocument.Load(file.FullName);

            
                    foreach (var matchingElement in xDocument.Root.XPathSelectElements("//Invoice"))
                    {
                        WriteLine($"Found element with name {matchingElement.Name}");

                        foreach (var item in xPathQuery)
                        {
                            foreach (var propertySelector in xDocument.Root.XPathSelectElements(item))
                            {
                                WriteLine($"\tFound property with value {propertySelector.Value}");
                            }
                        }
                    }
            }

            ReadKey(true);
        }


    }
}
