using ErrorResultPattern.Domain.Abstractions;

namespace ErrorResultPattern.Domain.Followers;

public static class FollowerErrors
{
    public static readonly Error SameUser =  new Error(
        "Followers.SameUser", 
        "Can't follow yourself");
    
    public static readonly Error NonPublicProfil = new Error(
        "Followers.NonPublicProfil", 
        "Can't follow non-public profile");
    
    public static readonly Error AlreadyFollowing =  new Error(
        "Followers.AlreadyFollowing", 
        "Already following");
}