using System;
using System.Collections.Generic;
using System.Text;

namespace CountryMVC
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country( "USA", "North America", new List<string>(){ "red", "white", "blue" } ),
            new Country( "South Korea", "Asia", new List<string>(){ "white", "black", "red", "blue" } ),
            new Country( "France", "Europe", new List<string>(){ "blue", "white", "red" } ),
            new Country( "Japan","Europe", new List<string>(){ "white", "red" } ),
            new Country( "Germany", "Europe", new List<string>(){ "black", "red", "yellow" } ),
            new Country( "Canada", "North America", new List<string>(){ "red", "white" } ),
            new Country( "Greece", "Europe", new List<string>(){ "white", "blue" } )
        };

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            Console.WriteLine("Hello, and welcome to the country app.\n\n");

            while (true)
            {
                Country output;
                string input;
                Console.WriteLine("Please select a country from the following list:\n");
                clv.Display();
                Console.WriteLine();
                try
                {
                    input = UserInput.PromptUser($"Which country would you like to learn about? 1-{CountryDb.Count}");
                    int index = int.Parse(input);
                    output = clv.Countries[index - 1];
                }
                catch
                {
                    Console.WriteLine("Invalid input detected. Please try again.\n");
                    continue;
                }
                CountryAction(output);
                while (true)
                {
                    input = UserInput.PromptUser("Would you like to learn about another country? y/n").ToLower();
                    if (input != "y" && input != "n")
                    {
                        Console.WriteLine("Please use y or n");
                        continue;
                    }
                    break;
                }
                if (input == "n")
                {
                    break;
                }
                Console.Clear();
            }
            Console.WriteLine("Thank you for using the country app. Goodbye!");
        }
    }
}