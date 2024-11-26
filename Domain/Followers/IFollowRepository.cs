namespace ErrorResultPattern.Domain.Followers;

public interface IFollowerRepository
{
    Task<bool> IsAlreadyFollowingAsync(Guid userId, Guid followerId, CancellationToken cancellationToken);

    void Insert(Follower follower);
}