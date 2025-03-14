namespace AotAspNet
{
    public static class ConfigureExtensions
    {
        public static void ConfigureApp(this WebApplicationBuilder builder)
        {
            var _ = builder.Configuration.GetSection(ImportantSetting1.SectionName).Get<ImportantSetting1>();
            var __ = builder.Configuration.GetSection(ImportantSetting2.SectionName).Get<ImportantSetting2>();
            var ___ = builder.Configuration.GetSection(ImportantSetting3.SectionName).Get<ImportantSetting3>();
        }
    }
}
