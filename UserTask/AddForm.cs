using System;
using System.Windows.Forms;

namespace UserTask
{
    public delegate string TransferTaskContent1(object sender);

    public partial class AddForm : Form, IViewTaskChild
    {
        private PresenterTaskChild presenterTaskChild;

        public event EventHandler<Task> TransferAddFunctia;
        public event EventHandler<Task> TransferEditFunctia;

        public event GetData GetDataForAddWindow;
        public event GetData GetDataForEditWindow;
        public event GetData GetDataForDeleteWindow;

        public AddForm(bool VisibleOrNot,bool AddTaskButtonVisibleOrNot)
        {
            InitializeComponent();
            presenterTaskChild = new PresenterTaskChild(this, new TaskModelChild());
            presenterTaskChild.InitializationEvent();
            txtUserID.Visible = false;
            UserID.Visible = VisibleOrNot;
            label2.Visible = VisibleOrNot;
            Edit.Visible = VisibleOrNot;
            TaskID.Visible=false;
            AddTaskButton.Visible = AddTaskButtonVisibleOrNot;

        }

        private bool FalseVisibleAddButton(bool visible)
        {
            return AddTaskButton.Visible = visible;
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Description = txtDescription.Text;
            txtUserID.Text = GetDataForAddWindow?.Invoke();
            task.UserID = int.Parse(txtUserID.Text);

            this.TransferAddFunctia?.Invoke(this, task);
            Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Description = txtDescription.Text;
            task.ID = int.Parse(GetDataForDeleteWindow?.Invoke());

            if (UserID.Text.Length == 0)
            {
                UserID.Text = GetDataForEditWindow?.Invoke();
                task.UserID = int.Parse(UserID.Text);

            }
            else
            {
                task.UserID = int.Parse(UserID.Text);
            }
            TransferEditFunctia?.Invoke(this, task);
            Close();

        }

        public void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaskID_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {

        }
    }
}
