namespace Website_With_Config
{
    internal interface IWebsiteConfig
    {
        string[] GetMessagesFromConfig();
        string[] GetCoursesFromConfig();
        string GetColorFromConfig();
        string GetClassNameFromConfig();
    }
}
