using General;
using Main.Interface;
using Main.Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class FriendBusiness : IFriendBusiness
    {
        private readonly FriendRepository friendRepository;
        public FriendBusiness()
        {
            friendRepository = new FriendRepository();
        }
        public bool AddFriend(FriendModel model,string userId)
        {
            var rsBool = false;
            try
            {
                model.ImagePath = model.Image.ConvertTo64();
                if (friendRepository.AddFriend(model, userId) > 0)
                {
                    rsBool = true;
                }
            }
            catch (System.Exception ex)
            {
                CoreLogger.Instance.Error(this.CreateMessageLog(ex.Message));
            }
            return rsBool;
        }

        public bool DelFriend(FriendModel model)
        {
            var rsBool = false;
            try
            {
               
                if (friendRepository.DelFriend(model) > 0)
                {
                    rsBool = true;
                }
            }
            catch (System.Exception ex)
            {
                CoreLogger.Instance.Error(this.CreateMessageLog(ex.Message));
            }
            return rsBool;
        }

        public bool EditFriend(FriendModel model)
        {
            var rsBool = false;
            try
            {
                if (model.Image != null)
                {
                    model.ImagePath = model.Image.ConvertTo64();
                }
                else
                {
                    model.ImagePath = model.ImagePath2;
                }

                if (friendRepository.EditFriend(model) > 0)
                {
                    rsBool = true;
                }
            }
            catch (System.Exception ex)
            {
                CoreLogger.Instance.Error(this.CreateMessageLog(ex.Message));
            }
            return rsBool;
        }

        public List<FriendModel> GetListFriend(string userId)
        {
            List<FriendModel> models = null;
            try
            {
                models = friendRepository.GetFriend(userId).To<FriendModel>();
            }
            catch (System.Exception ex)
            {
                CoreLogger.Instance.Error(this.CreateMessageLog(ex.Message));
            }
            return models;
        }
    }
}
