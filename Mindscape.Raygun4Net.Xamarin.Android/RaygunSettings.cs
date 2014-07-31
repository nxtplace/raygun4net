using System;

namespace Mindscape.Raygun4Net
{
    public class RaygunSettings
    {
        private static RaygunSettings settings;
        private const string DefaultApiEndPoint = "https://api.raygun.io/entries";

        public static RaygunSettings Settings
        {
            get
            {
                return settings ?? (settings = new RaygunSettings { ApiEndpoint = new Uri(DefaultApiEndPoint) });
            }
        }

        public virtual RaygunMessageBuilder CreateMessageBuilder()
        {
            return RaygunMessageBuilder.New;
        }

        public Uri ApiEndpoint { get; set; }
    }
}