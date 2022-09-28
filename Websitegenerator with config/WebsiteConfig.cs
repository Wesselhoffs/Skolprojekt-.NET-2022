namespace Website_With_Config
{
    class WebsiteConfig : IWebsiteConfig

    {
        string[] MessagesToClass
        { get; set; }
        string[] Courses
        { get; set; }
        string ClassName
        { get; set; }
        string Color
        { get; set; }

        public WebsiteConfig(string[] msgToClass, string[] courses, string className, string color)
        {
            this.MessagesToClass = msgToClass;
            this.Courses = courses;
            this.ClassName = className;
            this.Color = color;
        }


        public string GetClassNameFromConfig()
        {
            return ClassName;
        }

        public string GetColorFromConfig()
        {
            return Color;
        }

        public string[] GetCoursesFromConfig()
        {
            return Courses;
        }

        public string[] GetMessagesFromConfig()
        {
            return MessagesToClass;
        }
    }
}