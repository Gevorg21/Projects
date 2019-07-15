namespace UserTask
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addUser = new System.Windows.Forms.Button();
            this.editUser = new System.Windows.Forms.Button();
            this.removeUser = new System.Windows.Forms.Button();
            this.addTask = new System.Windows.Forms.Button();
            this.txtAddUser = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tasks = new System.Windows.Forms.TabPage();
            this.SearchTaskCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchTask = new System.Windows.Forms.TextBox();
            this.Users = new System.Windows.Forms.TabPage();
            this.CountUSERS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTask = new System.Windows.Forms.Button();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateTask = new System.Windows.Forms.Button();
            //       this.blueNetDataSet = new UserTask.blueNetDataSet();
            this.blueNetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blueNetDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DataTimeNow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Tasks.SuspendLayout();
            this.Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            // ((System.ComponentModel.ISupportInitialize)(this.blueNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNetDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(12, 144);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 23);
            this.addUser.TabIndex = 0;
            this.addUser.Text = " Add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // editUser
            // 
            this.editUser.Location = new System.Drawing.Point(93, 143);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(75, 23);
            this.editUser.TabIndex = 1;
            this.editUser.Text = "Edit User";
            this.editUser.UseVisualStyleBackColor = true;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // removeUser
            // 
            this.removeUser.Location = new System.Drawing.Point(174, 143);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(75, 23);
            this.removeUser.TabIndex = 2;
            this.removeUser.Text = "Remove User";
            this.removeUser.UseVisualStyleBackColor = true;
            this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(12, 371);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(75, 23);
            this.addTask.TabIndex = 3;
            this.addTask.Text = "Add Task";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // txtAddUser
            // 
            this.txtAddUser.Location = new System.Drawing.Point(12, 66);
            this.txtAddUser.Name = "txtAddUser";
            this.txtAddUser.Size = new System.Drawing.Size(100, 20);
            this.txtAddUser.TabIndex = 4;
            this.txtAddUser.TextChanged += new System.EventHandler(this.txtAddUser_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(118, 66);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(112, 20);
            this.ID.TabIndex = 5;
            this.ID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "UserName*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 400);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTaskToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editTaskToolStripMenuItem
            // 
            this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editTaskToolStripMenuItem.Text = "Edit";
            this.editTaskToolStripMenuItem.Click += new System.EventHandler(this.editTaskToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Task";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 317);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(97, 20);
            this.txtDescription.TabIndex = 12;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(118, 317);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 13;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descreption";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "UserID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Controls.Add(this.Tasks);
            this.tabControl1.Controls.Add(this.Users);
            this.tabControl1.Location = new System.Drawing.Point(350, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 462);
            this.tabControl1.TabIndex = 17;
            // 
            // Tasks
            // 
            this.Tasks.Controls.Add(this.SearchTaskCount);
            this.Tasks.Controls.Add(this.label8);
            this.Tasks.Controls.Add(this.txtSearchTask);
            this.Tasks.Controls.Add(this.dataGridView1);
            this.Tasks.Location = new System.Drawing.Point(4, 22);
            this.Tasks.Name = "Tasks";
            this.Tasks.Padding = new System.Windows.Forms.Padding(3);
            this.Tasks.Size = new System.Drawing.Size(758, 436);
            this.Tasks.TabIndex = 0;
            this.Tasks.Text = "Tasks";
            this.Tasks.UseVisualStyleBackColor = true;
            this.Tasks.Click += new System.EventHandler(this.Tasks_Click);
            // 
            // SearchTaskCount
            // 
            this.SearchTaskCount.AutoSize = true;
            this.SearchTaskCount.Location = new System.Drawing.Point(521, 16);
            this.SearchTaskCount.Name = "SearchTaskCount";
            this.SearchTaskCount.Size = new System.Drawing.Size(0, 13);
            this.SearchTaskCount.TabIndex = 11;
            this.SearchTaskCount.Click += new System.EventHandler(this.SearchTaskCount_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Search";
            // 
            // txtSearchTask
            // 
            this.txtSearchTask.Location = new System.Drawing.Point(72, 10);
            this.txtSearchTask.Name = "txtSearchTask";
            this.txtSearchTask.Size = new System.Drawing.Size(417, 20);
            this.txtSearchTask.TabIndex = 9;
            this.txtSearchTask.TextChanged += new System.EventHandler(this.TxtSearchTask_TextChanged);
            // 
            // Users
            // 
            this.Users.Controls.Add(this.CountUSERS);
            this.Users.Controls.Add(this.label9);
            this.Users.Controls.Add(this.txtSearchUser);
            this.Users.Controls.Add(this.dataGridView2);
            this.Users.Location = new System.Drawing.Point(4, 22);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(3);
            this.Users.Size = new System.Drawing.Size(758, 436);
            this.Users.TabIndex = 1;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // CountUSERS
            // 
            this.CountUSERS.AutoSize = true;
            this.CountUSERS.Location = new System.Drawing.Point(616, 12);
            this.CountUSERS.Name = "CountUSERS";
            this.CountUSERS.Size = new System.Drawing.Size(0, 13);
            this.CountUSERS.TabIndex = 3;
            this.CountUSERS.Click += new System.EventHandler(this.CountUSERS_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Search";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchUser.Location = new System.Drawing.Point(78, 9);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(411, 20);
            this.txtSearchUser.TabIndex = 1;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Location = new System.Drawing.Point(3, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(752, 442);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1,
            this.addTaskToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(123, 48);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addTaskToolStripMenuItem.Text = "Add Task";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.addTaskToolStripMenuItem_Click);
            // 
            // removeTask
            // 
            this.removeTask.Location = new System.Drawing.Point(118, 371);
            this.removeTask.Name = "removeTask";
            this.removeTask.Size = new System.Drawing.Size(75, 23);
            this.removeTask.TabIndex = 9;
            this.removeTask.Text = "Remove";
            this.removeTask.UseVisualStyleBackColor = true;
            this.removeTask.Click += new System.EventHandler(this.removeTask_Click);
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(224, 317);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(100, 20);
            this.txtTaskID.TabIndex = 18;
            this.txtTaskID.TextChanged += new System.EventHandler(this.txtTaskID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "TaskID";
            // 
            // UpdateTask
            // 
            this.UpdateTask.Location = new System.Drawing.Point(224, 371);
            this.UpdateTask.Name = "UpdateTask";
            this.UpdateTask.Size = new System.Drawing.Size(75, 23);
            this.UpdateTask.TabIndex = 20;
            this.UpdateTask.Text = "Update";
            this.UpdateTask.UseVisualStyleBackColor = true;
            this.UpdateTask.Click += new System.EventHandler(this.UpdateTask_Click);
            // 
            // blueNetDataSet
            // 
            //    this.blueNetDataSet.DataSetName = "blueNetDataSet";
            //    this.blueNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blueNetDataSetBindingSource
            // 
            //    this.blueNetDataSetBindingSource.DataSource = this.blueNetDataSet;
            this.blueNetDataSetBindingSource.Position = 0;
            // 
            // blueNetDataSetBindingSource1
            // 
            //      this.blueNetDataSetBindingSource1.DataSource = this.blueNetDataSet;
            this.blueNetDataSetBindingSource1.Position = 0;
            // 
            // DataTimeNow
            // 
            this.DataTimeNow.AutoSize = true;
            this.DataTimeNow.Location = new System.Drawing.Point(208, 453);
            this.DataTimeNow.Name = "DataTimeNow";
            this.DataTimeNow.Size = new System.Drawing.Size(81, 13);
            this.DataTimeNow.TabIndex = 21;
            this.DataTimeNow.Text = "Data Time Now";
            this.DataTimeNow.Click += new System.EventHandler(this.DataTimeNow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 481);
            this.Controls.Add(this.DataTimeNow);
            this.Controls.Add(this.UpdateTask);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTaskID);
            this.Controls.Add(this.removeTask);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtAddUser);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.removeUser);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.addUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Tasks.ResumeLayout(false);
            this.Tasks.PerformLayout();
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            //   ((System.ComponentModel.ISupportInitialize)(this.blueNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNetDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.Button removeUser;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.TextBox txtAddUser;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tasks;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button removeTask;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UpdateTask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchTask;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label SearchTaskCount;
        private System.Windows.Forms.Label CountUSERS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource blueNetDataSetBindingSource;
        //    private blueNetDataSet blueNetDataSet;
        private System.Windows.Forms.BindingSource blueNetDataSetBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.Label DataTimeNow;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
    }
}

