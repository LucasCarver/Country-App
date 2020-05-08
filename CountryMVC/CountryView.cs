using System;
using System.Collections.Generic;
using System.Text;

namespace CountryMVC
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public void Display()
        {
            Console.WriteLine("Here's your country's info: \n");

            Console.Write($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nColors: ");



            for (int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                string colorNow = "";

                colorNow = DisplayCountry.Colors[i];

                if (DisplayCountry.Colors[i].ToLower() == "black")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                try
                {
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), char.ToUpper(colorNow[0]) + colorNow.Substring(1));
                }
                catch
                {
                    // DRAW DEFAULT STYLE FOR UNSUPPORTED COLORS

                }
                if (i == 0)
                {
                    Console.Write(char.ToUpper(DisplayCountry.Colors[i][0]) + colorNow.Substring(1));
                }
                else
                {
                    Console.Write(DisplayCountry.Colors[i]);
                }

                Console.ResetColor();
                if (DisplayCountry.Colors.Count == 2 && i == 0)
                {
                    Console.Write(" and ");
                }

                else if (i == DisplayCountry.Colors.Count - 1)
                {
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(", ");
                }
                if (DisplayCountry.Colors.Count > 2 && i == DisplayCountry.Colors.Count - 2)
                {
                    Console.Write("and ");
                }
            }
        }
    }
}