using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_Generator_WPF.Classes
{
    class StyledWebsiteGenerator : WebsiteGenerator
    {
        // En extra egenskap
        string color;

        /*
         * En utökad konstruktor.
         * Vi vill lägga in alla del egenskaper som behövs i base-klassen vi ärvde ifrån
         * Och också lägga in en färg (data) i vår nya egenskap
         */
        public StyledWebsiteGenerator(string className, string color, string[] messageToClass, string[] techniques) : base(className, messageToClass, techniques)
        {
            this.color = color;
        }

        /*
         * Vi skapar en egen version av printStart (override:ar den) för att kunna få resultatet vi önskar
         */
        override protected string printStart()
        {
            return $"<!DOCTYPE html>\n<html>\n<head>\n<style>\np {{ color: {this.color}; }}\n" +
                              "</style>\n</head>\n<body>\n<main>\n";
        }
    }
}
