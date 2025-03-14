namespace AotAspNet
{
    public class ImportantSetting1(string setting)
    {
        public const string SectionName = "ImportantSetting1";
        public required string Setting1 { get; set; } = setting;
    }
}
