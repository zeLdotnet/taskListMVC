using System;
using System.Collections.Generic;

namespace taskListRevistedCapstone4.Models
{
    public partial class UserTask
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Complete { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
