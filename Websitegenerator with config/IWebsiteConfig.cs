namespace Website_With_Config
{
    internal interface IWebsiteConfig
    {
        string[] GetMessages();
        void SetMessages(string[] messages);
        string[] GetCourses();
        void SetCourses(string[] courses);
        string GetColor();
        void SetColor(string color);
        string GetClassName();
        void SetClassName(string className);
    }
}
