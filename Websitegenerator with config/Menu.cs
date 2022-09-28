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
                Console.SetOut(Console.Out);
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
                            myWebsite.PrintWebsite();
                            Console.WriteLine("\n\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            break;
                        case "2":
                            Console.Clear();
                            styledWebsite.PrintWebsite();
                            Console.WriteLine("\n\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            break;
                        case "3":
                            myWebsite.SaveWebsiteToFile();
                            Console.WriteLine("\n\nOrdinary website saved with filename \"Website.html\"!" +
                                              "\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            break;
                        case "4":
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
                        case "6": ChangeConfig(); break;
                        case "7": Environment.Exit(0); break;
                        default: displayError = true; break;
                    }
                }
            } while (keeprunning);
        }


        private static void PreviewConfig(WebsiteConfig myConfig)
        {
            // (string[] msgToClass, string[] courses, string className, string color)
            Console.WriteLine($"Classname\n-----------------\n{myConfig.GetClassNameFromConfig()}");
            Console.WriteLine($"\n\nMessages to class\n-----------------");
            if (myConfig.GetMessagesFromConfig() != null && myConfig.GetMessagesFromConfig().Any())
            {
                int counter = 0;
                foreach (string msg in myConfig.GetMessagesFromConfig())
                {
                    if (!string.IsNullOrWhiteSpace(msg))
                    {
                        Console.WriteLine($"Meddelande {++counter}: {msg}");
                    }
                }
            }
            Console.WriteLine($"\n\nCourses\n-----------------");
            if (myConfig.GetCoursesFromConfig() != null && myConfig.GetCoursesFromConfig().Any())
            {
                int counter = 0;
                foreach (string course in myConfig.GetCoursesFromConfig())
                {
                    if (!string.IsNullOrWhiteSpace(course))
                    {
                        Console.WriteLine($"Kurs {++counter}: {course}");
                    }
                }
            }
            Console.WriteLine($"\n\nColor\n---------\n{myConfig.GetColorFromConfig()}");
        }

        private static void ChangeConfig()
        {
            
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
