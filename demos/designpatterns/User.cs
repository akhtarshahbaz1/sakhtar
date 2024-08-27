using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    public class User
    {
        private List<User> followers = new List<User>();
        public string Username { get; set; }
        public bool Follow(User user)
        {
            return true;
        }

        public bool FollowerAdded(User newFollower)
        {
            Notification notification  = new Notification();
            return notification.NotifyUser(this, $"{newFollower.Username} is now following you");
        }

        public bool NotifyFollowers(User userToFollow)
        {
            bool result = true;
            Notification notification = new Notification();
            foreach (User user in followers) {
                result = notification.NotifyUser(this, $"{this.Username} is now following {userToFollow.Username}");
                if (!result) {
                    break;
                }
            }
            return result;
    }
}
