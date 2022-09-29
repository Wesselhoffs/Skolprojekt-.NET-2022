namespace Website_With_Config
{
    internal static class Menu
    {

        public static void StartMenu(WebsiteGenerator myWebsite, WebsiteGenerator styledWebsite, WebsiteConfig myConfig)
        {
            bool keeprunning = true;
            bool displayError = false;
            do
            {
                Console.Clear();
                Console.Write($"\n" +
                              $"       WEBSITE GENERATOR  \n" +
                              $"###############################\n" +
                              $"\nMenu\n" +
                              $"--------\n" +
                              $"1. Preview ordinary website\n" +
                              $"2. Preview styled website\n" +
                              $"3. Save ordinary website to file\n" +
                              $"4. Save styled website to file\n" +
                              $"5. Preview the website configuration\n" +
                              $"6. Change the website configuration\n" +
                              $"7. Exit the program\n\n");
                if (displayError)
                {
                    displayError = false;
                    WriteOutError();
                }
                else
                {
                    Console.Write($"\nSelection: ");
                }
                string? selection = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(selection))
                {
                    displayError = true;
                }
                else
                {
                    switch (selection)
                    {
                        case "1":
                            Console.Clear();
                            myWebsite.UpdateValues(myConfig);
                            myWebsite.PrintWebsite();
                            Console.WriteLine("\n\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            break;
                        case "2":
                            Console.Clear();
                            styledWebsite.UpdateValues(myConfig);
                            styledWebsite.PrintWebsite();
                            Console.WriteLine("\n\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            break;
                        case "3":
                            Console.Clear();
                            myWebsite.UpdateValues(myConfig);
                            myWebsite.SaveWebsiteToFile();
                            Console.WriteLine("\n\nOrdinary website saved with filename \"Website.html\"!" +
                                              "\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            break;
                        case "4":
                            Console.Clear();
                            styledWebsite.UpdateValues(myConfig);
                            styledWebsite.SaveWebsiteToFile();
                            Console.WriteLine("\n\nOrdinary website saved with filename \"StyledWebsite.html\"!" +
                                              "\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            break;
                        case "5":
                            Console.Clear();
                            PreviewConfig(myConfig);
                            Console.WriteLine("\n\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            break;
                        case "6": ChangeConfig(myConfig); break;
                        case "7": Environment.Exit(0); break;
                        default: displayError = true; break;
                    }
                }
            } while (keeprunning);
        }


        private static void PreviewConfig(WebsiteConfig myConfig)
        {
            Console.WriteLine($"Classname\n-----------------\n{myConfig.GetClassName()}");
            Console.WriteLine($"\n\nMessages to class\n-----------------");
            if (myConfig.GetMessages() != null && myConfig.GetMessages().Any())
            {
                int counter = 0;
                foreach (string msg in myConfig.GetMessages())
                {
                    if (!string.IsNullOrWhiteSpace(msg))
                    {
                        Console.WriteLine($"Meddelande {++counter}: {msg}");
                    }
                }
            }
            Console.WriteLine($"\n\nCourses\n-----------------");
            if (myConfig.GetCourses() != null && myConfig.GetCourses().Any())
            {
                int counter = 0;
                foreach (string course in myConfig.GetCourses())
                {
                    if (!string.IsNullOrWhiteSpace(course))
                    {
                        Console.WriteLine($"Kurs {++counter}: {course}");
                    }
                }
            }
            Console.WriteLine($"\n\nColor\n---------\n{myConfig.GetColor()}");
        }

        private static void ChangeConfig(WebsiteConfig myConfig)
        {
            Console.Write($"New classname: ");
            string newClassname = Console.ReadLine();
        }
        private static void WriteOutError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error - Invalid input");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"Selection: ");
        }
        private static bool YesOrNoMethod()
        {
            bool displayError = false, keepRunning = true, choice = false;
            while (keepRunning)
            {
                if (displayError)
                {
                    displayError = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nError - Invalid input");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write($"\nY/N: ");
                }
                else
                {
                    Console.Write($"\n\nY/N: ");
                }
                if (char.TryParse(Console.ReadLine(), out char yesOrNo))
                {
                    yesOrNo = char.Parse(yesOrNo.ToString().ToUpper());
                    if (yesOrNo == 'Y') { keepRunning = false; choice = true; }
                    else if (yesOrNo == 'N') { keepRunning = false; choice = false; }
                    else { displayError = true; }
                }
                else displayError = true;
            }
            return choice;
        }

    }
}
