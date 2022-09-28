namespace Website_With_Config
{
    internal interface IWebsiteGenerator    
    {
        public void PrintWebsite();
        public void SaveWebsiteToFile();
        void UpdateValues(WebsiteConfig config);
    }
}
