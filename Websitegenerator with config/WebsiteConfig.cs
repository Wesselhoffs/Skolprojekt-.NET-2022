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


        public string GetClassName()
        {
            return ClassName;
        }
        public void SetClassName(string className)
        {
            this.ClassName = className;
        }

        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string color)
        {
            this.Color = color;
        }

        public string[] GetCourses()
        {
            return Courses;
        }
        public void SetCourses(string[] courses)
        {
            this.Courses = courses;
        }

        public string[] GetMessages()
        {
            return MessagesToClass;
        }
        public void SetMessages(string[] messages)
        {
            this.MessagesToClass = messages;
        }
    }
}