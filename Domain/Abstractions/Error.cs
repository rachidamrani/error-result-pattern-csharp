namespace ErrorResultPattern.Domain.Abstractions;

public record Error(string Code, string? Description = default)
{
    public static readonly Error None = new (string.Empty);
    
    // Returns a Result object based on error object
    public static implicit operator Result(Error error) => Result.Failure(error);
}