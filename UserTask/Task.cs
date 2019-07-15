using System;

namespace UserTask
{
    public class Task : EventArgs
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int? UserID { get; set; }
    }
}
