using ErrorResultPattern.Domain.Abstractions;

namespace ErrorResultPattern.Domain.Followers;

public sealed record FollowerCreatedDomainEvent(Guid UserId, Guid FollowedId) : IDomainEvent;