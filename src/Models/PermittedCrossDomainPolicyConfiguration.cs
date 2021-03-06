using OwaspHeaders.Core.Helpers;

namespace OwaspHeaders.Core.Models
{
    public class PermittedCrossDomainPolicyConfiguration : IConfigurationBase
    {
        public string OptionValue { get; set; } = "none;";

        public string BuildHeaderValue()
        {
            if (string.IsNullOrWhiteSpace(OptionValue))
            {
                ArgumentExceptionHelper.RaiseException(nameof(OptionValue));
            }
            return OptionValue;
        }
    }
}