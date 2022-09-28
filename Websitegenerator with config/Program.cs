using Website_With_Config;
string[] msgToClass = Array.Empty<string>(); // { "Medd 1", "medd 2", "Medd 3", "Meddelande 4" };
string[] courses = { "Kurs 1", "Kurs 2", "Kurs 3", "Kurs 4"}; //Array.Empty<string>();
string className = String.Empty;
string color = String.Empty;

color = "red";
className = ".NET 2022";

WebsiteConfig myConfig = new WebsiteConfig(msgToClass, courses, className, color);
WebsiteGenerator myWebsite = new WebsiteGenerator(myConfig);
StyledWebsiteGenerator styledWebsite = new StyledWebsiteGenerator(myConfig);

Menu.StartMenu(myWebsite, styledWebsite, myConfig);
