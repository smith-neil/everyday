using System;
using System.Collections.Generic;

namespace Everyday.Core.Models {
    public class Task : BaseModel {
        public string Text { get; set; }
        public ICollection<Category> Categories { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}