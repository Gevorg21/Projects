using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask
{
    class PresenterTask
    {
        private IViewTask view;
        private TaskModel taskModel;
        public PresenterTask(IViewTask view, TaskModel taskModel)
        {
            this.view = view;
            this.taskModel = taskModel;
        }

        public void InitializationTaskEvent()
        {
            view.OnAddTask += AddTask;
            view.OnUpdateTask += UpdateTask;
            view.OnDeleteTask += DeleteTask;
            view.OnSearchTask += SearchTask;
            view.OnLoadTask += GetAllTask;
            view.OnTestAddTask += TestAddTask;
            view.OnGetTaskListCount += GetUserListCount;

        }

        public PresenterTask()
        {

        }

        public void AddTask(object sender,Task task)
        {
            taskModel.Add(task);
            view.ShowTask(taskModel.GetAll());
        }

        public void UpdateTask(object sender, Task task)
        {
           taskModel.Update(task);
            view.ShowTask(taskModel.GetAll());
        }

        public void DeleteTask(object sender, Task task)
        {
           taskModel.Delete(task);
            view.ShowTask(taskModel.GetAll());
        }

        public void SearchTask(object sender, string text)
        {
            view.ShowTask(taskModel.Search(text));
        }

        public void GetAllTask(object sender)
        {
            view.ShowTask(taskModel.GetAll());
        }

        public bool TestAddTask(object sender,string txtUsereID)
        {
          return taskModel.TestAddTask(txtUsereID);
        }

        public string GetUserListCount(object sender, string txtSearch)
        {
            if (txtSearch.Length == 0)
                return taskModel.GetAll().Count.ToString();
            else
                return taskModel.Search(txtSearch).Count.ToString();
        }

       
    }
}
