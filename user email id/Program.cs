// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmailAddressValidationConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emailAddresses = new List<string>
            {
                // Valid email addresses based on regex defined
                "raji@example.com",
                "raji.balusupati@example.net",
                "raji.balusupati@example.gov",
                "RAJI@BALUSUPATI.GOV",

                // Invalid email addresses based on regex defined
                "raji@example",
                "rajiexample.co.uk",
                "raji@example.me"
            };

            foreach (var emailAddress in emailAddresses)
            {
                Console.WriteLine($"{emailAddress} is" + (IsValid(emailAddress) ? " a valid" : " an invalid") + " email address.");
            }

            Console.ReadLine();
        }

        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
    }
}