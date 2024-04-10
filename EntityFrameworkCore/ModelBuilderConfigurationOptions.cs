using JetBrains.Annotations;

namespace Greenglobal.Erp.EntityFrameworkCore
{
    public class ModelBuilderConfigurationOptions
    {
        public ModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string? schema = null)
        {
        }
    }
}