using ErrorResultPattern.Domain.Abstractions;

namespace ErrorResultPattern.Domain.Users;
public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;