using Website_To_File;

WebsiteGenerator myWebsite = new WebsiteGenerator();
StyledWebsiteGenerator styledWebsite = new StyledWebsiteGenerator();

myWebsite.PrintWebsite();
Console.WriteLine("------------------------------------");
styledWebsite.PrintWebsite();

myWebsite.SaveWebsiteToFile();
styledWebsite.SaveWebsiteToFile();