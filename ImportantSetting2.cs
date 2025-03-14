using System.Diagnostics.CodeAnalysis;

namespace AotAspNet
{
    public class ImportantSetting2
    {
        public const string SectionName = "ImportantSetting2";

        [SetsRequiredMembers]
        public ImportantSetting2(string setting2)
        {
            Setting2 = setting2;
        }

        public required string Setting2 { get; set; }
    }
}
