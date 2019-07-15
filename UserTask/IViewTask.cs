using System;
using System.Collections.Generic;

namespace UserTask
{
    public delegate void EmptyDelTask(object sender);
    public delegate bool TestDataTask(object sender, string data);
    public delegate string OnGet_Task(object sender, string data);
  

    public interface IViewTask
    {
        event EventHandler<Task> OnAddTask;
        event EventHandler<Task> OnUpdateTask;
        event EventHandler<Task> OnDeleteTask;
        event EventHandler<string> OnSearchTask;
        event TestDataTask OnTestAddTask;
        event EmptyDelTask OnLoadTask;
        event OnGet_Task OnGetTaskListCount;

        void ShowTask(List<Task> list);
       // event GetData GetDataForAddWindow;
    }
}
