using System;
using System.Collections.Generic;

namespace Everyday.Web.Models
{
    public class Category
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Text { get; set; }
        
        public ICollection<TaskCategory> TaskCategories { get; set; }
    }
}