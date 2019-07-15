using System;
using System.Collections.Generic;

namespace UserTask
{
    internal class PresenterUser
    {
        private IViewUser view;
        private UserModel userModel;
        public PresenterUser(IViewUser view, UserModel userModel)
        {
            this.view = view;
            this.userModel = userModel;
        }

        public void InitializationUserEvent()
        {
            view.OnAddUser += AddUser;
            view.OnUpdateUser += UpdateUser;
            view.OnDeleteUser += DeleteUser;
            view.OnSearchUser += SearchUser;
            view.OnLoadUser += GetAllUser;
            view.OnTestRemoveUser += TestRemoveUser;
            view.OnGetUserListCount += GetUserListCount;
        }

        public PresenterUser()
        {

        }

        public void AddUser(object sender, User user)
        {
            userModel.Add(user);
            view.ShowUser(userModel.GetAll());
        }

        public void UpdateUser(object sender, User user)
        {
            userModel.Update(user);
             view.ShowUser(userModel.GetAll());
        }

        public void DeleteUser(object sender, User user)
        {

            userModel.Delete(user);
            view.ShowUser(userModel.GetAll());
        }

        public void SearchUser(object sender, string text)
        {
            view.ShowUser(userModel.Search(text));
        }

        public void GetAllUser(object sender )
        {
            view.ShowUser(userModel.GetAll());
        }

        public bool TestRemoveUser(object sender,string txtUserID)
        {
            return userModel.TestRemoveUser(txtUserID);
        }

       
        public string GetUserListCount(object sender,string txtSearch)
        {
            if (txtSearch.Length == 0)
                return userModel.GetAll().Count.ToString();
            else
                return userModel.Search(txtSearch).Count.ToString();
        }
    }
}