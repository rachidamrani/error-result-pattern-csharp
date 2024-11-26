using ErrorResultPattern.Domain.Abstractions;

namespace ErrorResultPattern.Domain.Followers;

public sealed class Follower : Entity
{
    public Guid UserId { get; private set; }
    public Guid FollowerId { get; private set; }
    public DateTime CreatedOnUtc { get; private set; }

    public Follower(Guid userId, Guid followerId, DateTime createdOnUtc) : base(userId)
    {
        UserId = userId;
        FollowerId = followerId;
        CreatedOnUtc = createdOnUtc;
    }

    public static Follower Create(Guid userId, Guid followerId, DateTime createdOnUtc)
    {
        Follower follower = new Follower(userId, followerId, createdOnUtc);
        
        follower.Raise(new FollowerCreatedDomainEvent(userId, followerId));

        return follower;
    }
}