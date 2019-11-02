//Author: Kyle McDonald
//Date:   11/2/2019
//CTEC 135: Microsoft Software Development with C# 

//Module 6, Programming Assignment 5, Problem 2

//XML Using LINQ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        #region IPO
        // description: Program that familiarizes us with XML document building
        //through LINQ
        // Inputs: Grocery List and various items and quantities. Vehicle list
        //containg multiple years makes and models
        // Outputs: Output 1 returns the list of vehicles and output 2 returns
        //the grocery list for good measure!
        // Behavior: Using System.XML and System.XML.LINQ the program is able 
        //to make use of XDocuments XComments and XElements to build a series 
        //of methods containing lists. Each list is able to be saved when ran 
        //using .Save. The load method is then called to load a xml file and
        //print its contents
        #endregion
        static void Main(string[] args)
        {
            //call CreateXmlDoc method to save list to memory
            CreateXmlDoc();
            //call MakeXmlDocFromArray method to save list to memory
            MakeXmlDocFromArray();
            //call LoadXml mehthod to load and print the previous lists
            LoadXml();
        }
        //Create a static method that creates an XML document and saves it
        static void CreateXmlDoc()
        {
            //use XDocument to create a new XDocument
            XDocument groceryListDoc =
            new XDocument(
            //populate the document using XComments, XElements and XAttributes
            new XComment("Grocery List!"),
            new XElement("My_Grocery_List",
            new XElement("Produce", new XAttribute("Items", "4"),
            new XElement("Apples", new XAttribute("Quantity", "10")),
            new XElement("Bananas", new XAttribute("Quantity", "6")),
            new XElement("Carrots", new XAttribute("Quantity", "8")),
            new XElement("Potatos", new XAttribute("Quantity", "4"))
            ),
            new XElement("Grains", new XAttribute("Items", "3"),
            new XElement("Bread", new XAttribute("Loafs", "2")),
            new XElement("Rice", "10lbs"),
            new XElement("Pasta", "Lots_of_it")
            ),
            new XElement("Dairy", new XAttribute("Items", "5"),
            new XElement("Milk", new XAttribute("Cartons", "2")),
            new XElement("Cheese", new XAttribute("Packs", "1")),
            new XElement("Yogurt", new XAttribute("Quantity", "4")),
            new XElement("Sour_Cream", new XAttribute("Ounces", "8")),
            new XElement("Cottage_Cheese", new XAttribute("Ounces", "8"))
            )
            )
            );
            // Save to disk.
            groceryListDoc.Save("GroceryList.xml");
        }

        //Create a static method that creates an XML document from an array
        //and saves it
        static void MakeXmlDocFromArray()
        {
            // Create an anonymous array of anonymous types and populate it
            var vehicle = new[]
            {
                new { Make = "Ford", Model = "Mustang GT", Year = 1967},
                new { Make = "Dodge", Model = "Charger", Year = 1969 },
                new { Make = "Chevrolet", Model = "Chevelle", Year = 1970 },
                new { Make = "Plymouth", Model = "Barracuda", Year = 1964}
            };
            //use XDocument to create a new XDocument
            XElement vehicleDoc =
            new XElement("My-Vehicles",
            //populate the document using XComments, XElements and XAttributes
            //and the array above
            from car in vehicle
            select new XElement("Vehicle", new XAttribute("Year", car.Year),
                new XElement("Make", car.Make), new XElement("Model", 
                car.Model))
            );
            Console.WriteLine();
            // Save to disk.
            vehicleDoc.Save("Vehicle.xml");
        }

        //Create a static method that loads an XML document and prints it to
        //the screen. 
        static void LoadXml()
        {

            Console.WriteLine("--------------------------");
            Console.WriteLine("Loading a list of vehicles");
            Console.WriteLine("--------------------------");
            //load vehicle document
            XDocument myDoc = XDocument.Load("Vehicle.xml");
            //print vehicle document
            Console.WriteLine(myDoc);
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Loading a grocery list");
            Console.WriteLine("----------------------");
            //load grocery list
            XDocument myDoc2 = XDocument.Load("GroceryList.xml");
            //print grocery list
            Console.WriteLine(myDoc2);
        }
    }
}
