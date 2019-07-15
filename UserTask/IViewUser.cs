using System;
using System.Collections.Generic;

namespace UserTask
{
    public delegate bool TestDataUser(object sender, string data);
    public delegate void EmptyDel(object sender);
    public delegate string OnGet_User(object sender, string data);

    internal interface IViewUser
    {
        event EventHandler<User> OnAddUser;
        event EventHandler<User> OnUpdateUser;
        event EventHandler<User> OnDeleteUser;
        event EventHandler<string> OnSearchUser;
        event EmptyDel OnLoadUser;
        event TestDataUser OnTestRemoveUser;
        event OnGet_User OnGetUserListCount;
        void ShowUser(List<User> list);
    }
}
