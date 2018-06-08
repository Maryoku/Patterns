namespace Patterns.Ex02
{
    public class VkUserService : UserService<VkUser>
    {

        //public UserInfo GetUserInfo(string pageUrl)
        //{
        //    var userId = Parse(pageUrl);
        //    UserInfo result = new UserInfo
        //    {
        //        Name = GetName(userId),
        //        UserId = userId
        //    };

        //    VkUser[] users = GetFriendsById(result.UserId);
        //    UserInfo[] friends = ConvertToUserInfo(users);
        //    result.Friends = friends;
        //    return result;
        //}

        protected override string GetName(string userId)
        {
            return "NAME";
        }

        protected override VkUser[] GetFriendsById(string userId)
        {
            return new VkUser[0];
        }

        protected override string Parse(string pageUrl)
        {
            return "USER_ID";
        }

        protected override UserInfo[] ConvertToUserInfo(VkUser[] friends)
        {
            return new UserInfo[0];
        }
    }
}