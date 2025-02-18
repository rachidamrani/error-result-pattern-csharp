using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ErrorResultPattern.Domain.Users;

public static class Ensure
{
    public static void NotNullOrEmpty(
        [NotNull] string? value,
        [CallerArgumentExpression("value")] string? paramName = default)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException(paramName);
        }
    }
}