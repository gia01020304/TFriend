using Main.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Interface
{
    public interface IFriendBusiness
    {
        List<FriendModel> GetListFriend(string userId);
        bool AddFriend(FriendModel model, string userId);
        bool EditFriend(FriendModel model);
        bool DelFriend(FriendModel model);
    }
}
