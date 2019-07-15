using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask
{
    class PresenterTaskChild
    {
       private IViewTaskChild viewTaskChild;
       private TaskModelChild taskModelChild;


        public PresenterTaskChild(IViewTaskChild viewTaskChild, TaskModelChild taskModelChild)
        {
            this.viewTaskChild = viewTaskChild;
            this.taskModelChild = taskModelChild;
        }

        public void AddTaskChildPresenter(object sender, Task task)
        {       
            taskModelChild.AddTaskChild(task);
        }

        public void EditTasakChildPresenter(object sender,Task task)
        {
            taskModelChild.UpdateTaskChilde(task);
        }

        public void InitializationEvent()
        {
            viewTaskChild.TransferAddFunctia += AddTaskChildPresenter;
            viewTaskChild.TransferEditFunctia += EditTasakChildPresenter;
        }
        
        
    }
}
