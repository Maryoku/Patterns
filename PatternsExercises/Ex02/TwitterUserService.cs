using System;
using System.Linq;
using System.Text.RegularExpressions;
using Patterns.Ex01.ExternalLibs.Twitter;

namespace Patterns.Ex02
{
    public class TwitterUserService : UserService<TwitterUser>
    {
        readonly TwitterClient _client = new TwitterClient();

        //public UserInfo GetUserInfo(String pageUrl)
        //{
        //    var regex = new Regex("twitter.com/(.*)");
        //    var userName = regex.Match(pageUrl).Groups[0].Value;

        //    var userId = GetUserId(userName);

        //    TwitterUser[] subscribers = _client.GetSubscribers(userId);

        //    UserInfo[] friends = subscribers
        //        .Select(c =>
        //        {
        //            UserInfo userInfo = new UserInfo
        //            {
        //                UserId = c.UserId.ToString(),
        //                Name = _client.GetUserNameById(c.UserId)
        //            };
        //            return userInfo;
        //        })
        //        .ToArray();

        //    var result = new UserInfo
        //    {
        //        Name = userName,
        //        UserId = userId.ToString(),
        //        Friends = friends
        //    };
        //    return result;
        //}

        protected override UserInfo[] ConvertToUserInfo(TwitterUser[] user)
        {
            return user.Select(c =>
            {
                var userInfo = new UserInfo
                {
                    UserId = c.UserId.ToString(),
                    Name = _client.GetUserNameById(c.UserId)
                };
                return userInfo;
            }).ToArray();
        }

        protected override string GetName(string userId)
        {
            throw new NotImplementedException();
        }

        protected override TwitterUser[] GetFriendsById(string userId)
        {
            return _client.GetSubscribers(Convert.ToInt64(userId)).ToArray();
        }

        protected override string Parse(string pageUrl)
        {
            var regex = new Regex("twitter.com/(.*)");
            var userName = regex.Match(pageUrl).Groups[0].Value;
            return GetUserId(userName).ToString();
        }

        private long GetUserId(String userName)
        {
            //TODO: Return userId from userName
            return 0;
        }
    }
}