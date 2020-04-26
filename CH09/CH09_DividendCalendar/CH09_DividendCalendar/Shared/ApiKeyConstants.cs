namespace CH09_DividendCalendar.Shared
{
    public struct ApiKeyConstants
    {
        public const string HeaderName = "X-Api-Key";
        public const string MorningstarApiKeyUrl = "https://Keys-APIs.vault.azure.net/secrets/MorningstarApiKey";
        public const int ThrottleMonthDay = 25;
    }
}
