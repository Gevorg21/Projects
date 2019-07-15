using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask
{
    public delegate string GetData();

    interface IViewTaskChild
    {
        event EventHandler<Task> TransferAddFunctia;
        event EventHandler<Task> TransferEditFunctia;
        event GetData GetDataForAddWindow;
        event GetData GetDataForEditWindow;
        event GetData GetDataForDeleteWindow;
        

    }
}
