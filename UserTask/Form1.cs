using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserTask
{
    public partial class Form1 : Form, IViewUser, IViewTask 
    {
  //      private DataReader dataReader = new DataReader();
        private PresenterUser presenterUser;
        private PresenterTask presenterTask;

        public Form1()
        {
            InitializeComponent();

            presenterUser = new PresenterUser(this, new UserModel());
            presenterUser.InitializationUserEvent();
            presenterTask = new PresenterTask(this, new TaskModel());
            presenterTask.InitializationTaskEvent();
            this._onLoadUser(this);
            this._onLoadTask(this);
            EnabledAddUserButton();
            EnabledUpdateUserButton();
            EnabledRemoveUserButton();
            EnabledAddTaskButton();
            EnabledRemoveTaskButton();
            EnabledUpdateTaskButton();

            DataTimeNow.Text = DateTime.UtcNow.ToLongDateString();
        }
        public event EventHandler<User> OnAddUser;
        public event EventHandler<User> OnUpdateUser;
        public event EventHandler<User> OnDeleteUser;
        public event EventHandler<string> OnSearchUser;
        public event TestDataUser OnTestRemoveUser;
        public event OnGet_User OnGetUserListCount;
        /********************************************/
        public event EventHandler<Task> OnAddTask;
        public event EventHandler<Task> OnUpdateTask;
        public event EventHandler<Task> OnDeleteTask;
        public event EventHandler<string> OnSearchTask;
        public event TestDataTask OnTestAddTask;
        public event OnGet_Task OnGetTaskListCount;

        private EmptyDelTask _onLoadTask;
        event EmptyDelTask IViewTask.OnLoadTask
        {
            add
            {
                _onLoadTask += value;
            }
            remove
            {
                _onLoadTask -= value;
            }
        }

        private EmptyDel _onLoadUser;
        event EmptyDel IViewUser.OnLoadUser
        {
            add
            {
                _onLoadUser += value;
            }

            remove
            {
                _onLoadUser -= value;
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                FullName = txtAddUser.Text
            };

            this.OnAddUser?.Invoke(this, user);

            ID.Clear();
            txtAddUser.Clear();

            _onLoadUser.Invoke(this);
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            var user = new User()
            {
                ID = int.Parse(ID.Text),
                FullName = txtAddUser.Text
            };
            this.OnUpdateUser?.Invoke(this, user);

            ID.Clear();
            txtAddUser.Clear();

            _onLoadUser.Invoke(this);
        }

        private void removeUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                ID = int.Parse(ID.Text)
            };

            if (this.OnTestRemoveUser.Invoke(this, ID.Text) == true)
                this.OnDeleteUser?.Invoke(this, user);
            else
                MessageBox.Show("This user has a link to it");

            ID.Clear();
            txtAddUser.Clear();

            _onLoadUser.Invoke(this);
        }

      

        private void EnabledUpdateUserButton()
        {
            bool success = Int32.TryParse(ID.Text, out int number);

            if (success)
            {
                if (ID.Text.Length > 0 && txtAddUser.Text.Length > 0)
                {
                    editUser.Enabled = true;
                }
                else editUser.Enabled = false;
            }
            else editUser.Enabled = false;
        }


        private void EnabledRemoveUserButton()
        {
            ID.Enabled = false;
            bool success = Int32.TryParse(ID.Text, out int number);
            if (success)
            {
                if (ID.Text.Length > 0)
                    removeUser.Enabled = true;
                else removeUser.Enabled = false;
            }
            else removeUser.Enabled = false;
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            Task task = new Task()
            {
                Description = txtDescription.Text
            };
            if (int.TryParse(txtUserID.Text, out int val))
            {
                task.UserID = val;
            }

            if (OnTestAddTask.Invoke(this, txtUserID.Text) == true)
                OnAddTask.Invoke(this, task);
            else MessageBox.Show("This user has not been found");

            txtDescription.Clear();
            txtUserID.Clear();
            txtTaskID.Clear();
            _onLoadTask.Invoke(this);
        }

        private void UpdateTask_Click(object sender, EventArgs e)
        {
            Task task = new Task()
            {
                Description = txtDescription.Text,
                UserID = int.Parse(txtUserID.Text),
                ID = int.Parse(txtTaskID.Text)
            };

            OnUpdateTask.Invoke(this, task);
            _onLoadTask.Invoke(this);
            txtDescription.Clear();
            txtUserID.Clear();
            txtTaskID.Clear();
        }

        private void removeTask_Click(object sender, EventArgs e)
        {
            Task task = new Task()
            {
                ID = int.Parse(txtTaskID.Text)
            };

            OnDeleteTask.Invoke(this, task);
            _onLoadTask.Invoke(this);


            txtDescription.Clear();
            txtUserID.Clear();
            txtTaskID.Clear();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtTaskID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                txtUserID.Text = dataGridView1.Rows[e.RowIndex].Cells["UserID"].FormattedValue.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;

                txtAddUser.Text = dataGridView2.Rows[e.RowIndex].Cells["FullName"].FormattedValue.ToString();
                txtUserID.Text = dataGridView2.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                ID.Text = dataGridView2.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();

            }
        }

        private void EnabledAddUserButton()
        {
            if (txtAddUser.Text.Length > 0)
                addUser.Enabled = true;
            else
                addUser.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EnabledAddTaskButton()
        {
            if (txtDescription.Text.Length > 0 && txtUserID.Text.Length > 0)
            {
                addTask.Enabled = true;
            }

            else addTask.Enabled = false;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            EnabledAddTaskButton();
            EnabledUpdateTaskButton();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            EnabledAddTaskButton();
            EnabledUpdateTaskButton();
        }

        private void Tasks_Click(object sender, EventArgs e)
        {

        }

        private void txtTaskID_TextChanged(object sender, EventArgs e)
        {
            EnabledRemoveTaskButton();
            EnabledUpdateTaskButton();
        }

        private void EnabledUpdateTaskButton()
        {
            bool success = Int32.TryParse(txtTaskID.Text, out int number);
            if (success)
            {
                if (txtDescription.Text.Length > 0 && txtTaskID.Text.Length > 0)
                {
                    UpdateTask.Enabled = true;
                }

                else UpdateTask.Enabled = false;
            }
            else UpdateTask.Enabled = false;
        }
        private void EnabledRemoveTaskButton()
        {
            txtTaskID.Enabled = false;
            bool success = Int32.TryParse(txtTaskID.Text, out int number);
            if (success)
            {
                if (txtTaskID.Text.Length > 0)
                    removeTask.Enabled = true;

                else removeTask.Enabled = false;
            }
            else removeTask.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            EnabledUpdateUserButton();
            EnabledRemoveUserButton();
        }

        private void txtAddUser_TextChanged(object sender, EventArgs e)
        {
            EnabledAddUserButton();
            EnabledUpdateUserButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          /*  TextBox textBox = new TextBox();
            textBox.Click += delegate (object send, EventArgs eventArgs)
              {
                  if (txtSearchUser.Text.Length > 0)
                  {
                      this.OnSearchUser?.Invoke(this, txtSearchUser.Text);
                  }

                  else
                  {
                    _onLoadUser.Invoke(this);
                  }
                  this.Controls.Add(txtSearchUser);
                  CountUSERS.Text = $"Find { OnGetUserListCount(this, txtSearchUser.Text)} user ";

                  //  SearchTaskCount.Text = $"Find {OnGetTaskListCount(this, txtSearchTask.Text)} task";

              };*/
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUser.Text.Length > 0)
            {
                this.OnSearchUser?.Invoke(this, txtSearchUser.Text);
            }
            else
            {
                _onLoadUser.Invoke(this);

            }

            CountUSERS.Text = $"Find { OnGetUserListCount(this, txtSearchUser.Text)} user ";
        }

        private void TxtSearchTask_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchTask.Text.Length > 0)
            {
                OnSearchTask.Invoke(this, txtSearchTask.Text);
            }
            else
            {
                _onLoadTask.Invoke(this);
            }
            SearchTaskCount.Text = $"Find {OnGetTaskListCount(this, txtSearchTask.Text)} task";
        
        }

        private void SearchTaskCount_Click(object sender, EventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {

        }

        private void CountUSERS_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task task = new Task()
            {
                ID = int.Parse(txtTaskID.Text)
            };
            if (MessageBox.Show("Are you sure To delate data", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OnDeleteTask.Invoke(this, task);
                _onLoadTask.Invoke(this);
                txtDescription.Clear();
                txtUserID.Clear();
                txtTaskID.Clear();
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                ID = int.Parse(ID.Text)
            };

            if (MessageBox.Show("Are you sure To delate data", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (OnTestRemoveUser(this,ID.Text) == true)
                    OnDeleteUser.Invoke(this, user);
                else
                    MessageBox.Show("This user has a link to it");
            }

            ID.Clear();
            txtAddUser.Clear();
            _onLoadUser.Invoke(this);
        }

        public string TransferUserID()
        {
            return txtUserID.Text;
        }

        public string TransferTaskID()
        {
            return txtTaskID.Text;
        }
       
        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(false,true);
            addForm.GetDataForAddWindow += this.GetDattaForAdd;
                addForm.ShowDialog();
            _onLoadTask.Invoke(this);
;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DataTimeNow_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(true,false);
            
            addForm.GetDataForDeleteWindow += GetDataForDelete;
            addForm.GetDataForEditWindow += GetDattaForAdd;
            addForm.ShowDialog();
            _onLoadTask.Invoke(this);
        }

        public void ShowUser(List<User> list)
        {
            dataGridView2.DataSource = list;
        }

        public void ShowTask(List<Task> list)
        {
            dataGridView1.DataSource = list;
        }

        public string txtUserIDTransferChild(object sender)
        {
            return txtUserID.Text;
        }

        public string GetDattaForAdd()
        {
            return txtUserID.Text;
        }

        public string GetDataForDelete()
        {
            return txtTaskID.Text;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

